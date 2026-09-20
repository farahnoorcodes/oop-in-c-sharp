using System;
namespace _5_protected_internal_access_modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Base class object: Program is not derived, but it is in the same
            // project, so the internal rule allows direct access to the fields.
            protected_internal_vehicle v1 = new protected_internal_vehicle();
            v1.vehicle_name = "Bus";
            v1.vehicle_model = "Hino 2022";
            v1.engine_type = "Diesel";
            v1.ShowVehicle();

            Console.WriteLine();

            // Derived class object: set_car_details assigns the fields
            // through the protected rule, inside the car class.
            car c1 = new car();
            c1.set_car_details("Toyota Corolla", "Petrol", "2023");
            c1.ShowVehicle();
        }
    }
}