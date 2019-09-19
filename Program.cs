using System;
// Name:Justin Hartman
// Date: 9/18/2019
// Assignment: Methods Deliverable

namespace MethodsDeliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks for the users input 
            Console.WriteLine("Please enter your name: ");
            string input = Console.ReadLine();
            // consoles then reads the users input and stores under input

            // try catch block begins
            try
            {
                Console.WriteLine("___________________________________");
                // this is the return method which returns a message for the user.
                string get_user_name = User_name(input);

                // this is a void method that says goodbye to the user and executes automatically
                Goodbye_User_name(get_user_name);

                Console.WriteLine("___________________________________");

                Console.WriteLine("Press any key to leave");
                Console.ReadKey(true);

            }

            catch
            {
                Console.WriteLine("Please enter a string");
                Console.WriteLine("Press any key to leave");
                Console.ReadKey(true);
            }


        }

        // This is a static method which cannot be instantiated with a key word of new. Private is only within containing class
        private static string User_name(string get_name)
        {
            Console.WriteLine("Hello " + get_name + "!");
            return get_name;
            // returns message to user
        }

        private static void Goodbye_User_name(string get_name)
        {
            Console.WriteLine("__________________________________");
            Console.WriteLine("This is a void method below");
            Console.WriteLine("GoodBye " + get_name + " !");
            // auto returns message
        }

        }
    }

