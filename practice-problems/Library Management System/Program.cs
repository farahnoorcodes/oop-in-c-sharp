using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    abstract class LibarayItem
    {
        private string title;
        public LibarayItem(string t)
        {
            this.title = t;
        }
        public string Title
        {
            get { return title; }
        }

        public abstract void DisplayDetail();
    }
    class book : LibarayItem
    {
        private string author;
        public book(string title, string authorName) : base(title)
        {
            this.author = authorName;
        }
        public override void DisplayDetail()
        {
            Console.WriteLine("Item type : Book");
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Author : " + author);
        }
    }
    class magazine : LibarayItem
    {
        private int issueNumber;
        public magazine(string title, int issue) : base(title)
        {
            this.issueNumber = issue;
        }
        public override void DisplayDetail()
        {
            Console.WriteLine("Item type : Magazine");
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Issue Number : " + issueNumber);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name : Farah Noor\nRoll Number : 2025-CPE-18");
            Console.WriteLine("-----Library Management System-----");
            string loop = "y";
            while (loop == "y")
            {
                Console.WriteLine("what you want to add in library record ?\n 1. Book \n 2. Magazine \n 3. something else\n 4. exit");
                Console.Write("Enter your choice : ");
                string choice = Console.ReadLine().ToLower();
                if (choice == "1" || choice == "book")
                {
                    try
                    {

                        Console.Write("enter book title : ");
                        string Title = Console.ReadLine();
                        Console.Write("enter  Author Name: ");
                        string Author = Console.ReadLine();
                        book b1 = new book(Title, Author);
                        Console.WriteLine("---------Libaray Record--------");
                        b1.DisplayDetail();
                    }
                    catch
                    {
                        Console.WriteLine("An error occurred: ");
                    }
                    finally
                    {
                        Console.WriteLine("program completed.");
                        Console.ReadKey();
                    }
                }
                if (choice == "2" || choice == "magazine")
                {
                    try
                    {
                        Console.Write("enter magazine title : ");
                        string Title = Console.ReadLine();
                        Console.Write("enter  Issue Number: ");
                        int issueNumber = Convert.ToInt32(Console.ReadLine());
                        magazine m1 = new magazine(Title, issueNumber);
                        Console.WriteLine("---------Libaray Record--------");
                        m1.DisplayDetail();
                    }
                    catch
                    {
                        Console.WriteLine("An error occurred: ");
                    }
                    finally
                    {
                        Console.WriteLine("program completed.");
                        Console.ReadKey();
                    }
                }
                else if (choice == "3" || choice == "something else")
                {
                    try
                    {
                        Console.WriteLine("You can add other items in the library record.");
                        Console.WriteLine("Please provide the details of the item you want to add.");
                        Console.Write("Enter item : "); string item = Console.ReadLine();
                        Console.Write("Enter title : "); string Title = Console.ReadLine();
                        Console.Write("Enter  Author Name: "); string Author = Console.ReadLine();
                        Console.Write("Enter  Issue Number: "); string issueNumber = Console.ReadLine();
                        Console.WriteLine("---------Libaray Record--------");
                        Console.WriteLine("Item type : " + item);
                        Console.WriteLine("Title : " + Title);
                        Console.WriteLine("Author : " + Author);
                        Console.WriteLine("Issue Number : " + issueNumber);
                    }
                    catch
                    {
                        Console.WriteLine("An error occurred, please enter valid input.");
                    }


                    finally
                    {
                        Console.WriteLine("program completed.");
                        Console.ReadKey();

                    }
                }
                else if (choice == "4" || choice == "exit")
                {
                    Console.WriteLine("Exiting the program.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                loop = Console.ReadLine().ToLower();
            }
        }

    }
}
