using System;
using Project0.DataAccess;
using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using Project0.DataAccess.Entities;

namespace Project0
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<ClothesEncountersContext> options = new DbContextOptionsBuilder<ClothesEncountersContext>()
                .UseSqlServer(connectionString)
                .Options;

            using var context = new ClothesEncountersContext(options);

            DataRepository dbrepo = new DataRepository(context);

            //dbrepo.viewallcustomers return list

            Console.WriteLine("Welcome to ClothesEncounters!");

            Console.WriteLine("Are you a new customer?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");
            Console.WriteLine("Type your selection");
            string q1 = Console.ReadLine();

            switch (q1)
            {
                case "1":
                        Console.WriteLine("Awesome! What is your first name?");
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

                        Customer customer = new Customer(firstName, lastName, street, city, state, zip);
                        dbrepo.AddNewCustomer(customer);


                    break;

                case "2":
                    Console.WriteLine("Here are a list of our existing customers. /n" + 
                        "Tell us who you are by typing your full name");
                    var customers = dbrepo.GetAllCustomers();
                    int a = 0;
                    foreach (Customer c in customers)
                    {
                        Console.WriteLine($"{a} {c.FirstName} {c.LastName} ");
                        a++;
                    }
                    string firstname = Console.ReadLine();
                    dbrepo.GetCustomerByFirstName(firstname);

                    
                    break;



            }






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

            //Address address = new Address(street, city, state, zip);
            //Customer newCustomer = new Customer(FirstName, LastName, street,  );

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
