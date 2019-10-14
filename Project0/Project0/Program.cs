using System;
using Project0.DataAccess;
using BusinessLogic;

namespace Project0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ClothesEncounters!");

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your street address?");
            string street = Console.ReadLine();
            
            Console.WriteLine("What is your city?");
            string city = Console.ReadLine();

            Console.WriteLine("What is your state?");
            string state = Console.ReadLine();

            Console.WriteLine("What is your zipcode?");
            string zip = Console.ReadLine();

            string userSelection1;

            do
            {

                MainMenu(out userSelection1);

                switch (userSelection1)
                {
                    case "1":
                        StoreSelectionMenu();

                        int b;
                        string userSelection2 = Console.ReadLine();
                        bool success2 = int.TryParse(userSelection1, out b);
                        if (success2)
                        {
                            switch (b)
                            {
                                case 1:
                                    //set to store #101, display inventory
                                    break;
                                case 2:

                                    break;

                            }
                            if (b == 1)
                            {
                                //set to store #101, display inventory
                            }

                            if (b == 2)
                            {
                                //set to store #102, display inventory
                            }

                            if (b == 3)
                            {
                                //set to store #103, display inventory
                            }

                            if (b == 4)
                            {
                                //set to store #104, display inventory
                            }

                            if (b == 5)
                            {
                                //set to store #105, display inventory
                            }

                            if (b == 6)
                            {
                                //display previous me
                            }
                        }
                        break;
                    case "2":
                        //display inventory from default store

                        break;
                    //case "3":
                    //    break;
                }

            } while (userSelection1 == "3"); //exit the program

            Address address = new Address(street, city, state, zip);
            Customer newCustomer = new Customer(firstName, lastName, address);
            
        }

        public static void StoreSelectionMenu()
        {
            Console.WriteLine("Choose the store you would like to shop at: ");
            Console.WriteLine("1 - Store #101");
            Console.WriteLine("2 - Store #102");
            Console.WriteLine("3 - Store #103");
            Console.WriteLine("4 - Store #104");
            Console.WriteLine("5 - Store #105");
            Console.WriteLine("6 - Return to previous menu");
            Console.WriteLine("Type your selection");

        }
        public static void MainMenu(out string userSelection1)
        {
            Console.WriteLine(" \n" +
                "The default store is Store #101. Would you like to: \n" +
                "1 - Switch Stores\n" +
                "2 - Start Shopping\n" +
                "3 - Exit\n" +
                "Type your selection: ");

            userSelection1 = Console.ReadLine();


        }
    }






}
