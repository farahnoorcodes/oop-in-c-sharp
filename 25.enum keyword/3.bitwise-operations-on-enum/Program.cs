using System;
namespace _3.bitwise_operations_on_enum
{
    internal class Program
    {//we can perform operations on enum values using bitwise operators.
        //The bitwise operators are used to perform operations on the binary representations of the enum values. The most commonly used bitwise operators for enums are:
        // 1. Bitwise AND (&): This operator is used to check if a specific flag is set in an enum value. It returns true if the flag is set, and false otherwise.
        // 2. Bitwise OR (|): This operator is used to set a specific flag in an enum value. It returns a new enum value with the specified flag set.
        // 3. Bitwise XOR (^): This operator is used to toggle a specific flag in an enum value. It returns a new enum value with the specified flag toggled.
        // 4. Bitwise NOT (~): This operator is used to invert all the flags in an enum value. It returns a new enum value with all the flags inverted.
        [Flags]
        //The [Flags] attribute is used to indicate that an enum can be treated as a bit field, meaning that it can represent a combination of values. When an enum is decorated with the [Flags] attribute, it allows for more intuitive and readable code when working with combinations of enum values.
        enum Permission
        {
            None = 0,   // 000
            Read = 1,   // 001
            Write = 2,   // 010
            Execute = 4    // 100
        }
        //predefined combination of flags can be created by using the bitwise OR operator to combine multiple flags. For example, we can create a combination of Read and Write permissions like this:
        [Flags]
        enum Permission1
        {
            None = 0,
            Read = 1,
            Write = 2,
            Execute = 4,
            ReadWrite = Read | Write,
            All = Read | Write | Execute
        }
        static void Main(string[] args)
        {
            Permission userPermission = Permission.Read | Permission.Write;
            // Check if the user has Read permission
            bool hasReadPermission = (userPermission & Permission.Read) == Permission.Read;
            Console.WriteLine($"Has Read Permission: {hasReadPermission}");
            // Check if the user has Execute permission
            bool hasExecutePermission = (userPermission & Permission.Execute) == Permission.Execute;
            Console.WriteLine($"Has Execute Permission: {hasExecutePermission}");
            // Add Execute permission to the user
            userPermission |= Permission.Execute;
            Console.WriteLine($"Updated Permissions: {userPermission}");
            // Remove Write permission from the user
            userPermission &= ~Permission.Write;
            Console.WriteLine($"Updated Permissions after removing Write: {userPermission}");

            Permission1 userPermission1 = Permission1.Read | Permission1.Write;
            Console.WriteLine($"User Permissions: {userPermission1}");
            // Check if the user has ReadWrite permission
            bool hasReadWritePermission = (userPermission1 & Permission1.ReadWrite) == Permission1.ReadWrite;
            Console.WriteLine($"Has ReadWrite Permission: {hasReadWritePermission}");
            // Check if the user has All permission
            bool hasAllPermission = (userPermission1 & Permission1.All) == Permission1.All;
            Console.WriteLine($"Has All Permission: {hasAllPermission}");
            userPermission1 |= Permission1.Execute;// Add Execute permission to the user
            Console.WriteLine($"Updated Permissions: {userPermission1}");
            //check if the user has All permission after adding Execute
            hasAllPermission = (userPermission1 & Permission1.All) == Permission1.All;
            Console.WriteLine($"Has All Permission after adding Execute: {hasAllPermission}");
        }
    }
}
