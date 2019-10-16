using System;
using Project0.DataAccess;
using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using Project0.DataAccess.Entities;
using System.Collections.Generic;

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
                    Console.WriteLine("Here are a list of our existing customers.");
                    Console.WriteLine("Tell us who you are by typing your first name.");
                    var customers = dbrepo.GetAllCustomers();
                    int a = 1;
                    foreach (Customer c in customers)
                    {
                        Console.WriteLine($"{a} - {c.FirstName} {c.LastName} ");
                        a++;
                    }
                    string firstname = Console.ReadLine();
                    Customer cust = dbrepo.GetCustomerByFirstName(firstname);

                    break;

            }


            {
                Console.WriteLine(" \n" +
                    "The default store is Store #101. Would you like to: \n" +
                    "1 - Switch Stores\n" +
                    "2 - Start Shopping\n" +
                    "3 - Exit\n" +
                    "Type your selection: ");

                string q2 = Console.ReadLine();

                switch (q2)
                {
                    case "1":
                        Console.WriteLine("These are our stores.");
                        Console.WriteLine("Make your selection.");
                        var stores = dbrepo.GetAllStores();
                        int b = 1;
                        foreach (Store s in stores)
                        {
                            Console.WriteLine($"{b} - Store # { s.StoreId } ");
                            b++;
                        }

                        string str = Console.ReadLine();

                        //string firstname = Console.ReadLine();

                        switch (str)
                        {
                            case "1":
                                //store 101 iventory
                                Dictionary<Shirt, int> invent101 = dbrepo.GetInventoryByStoreId(101);
                                PrintInventory(invent101);
                                Console.WriteLine("Okay! Now that you know our inventory, let's shop!");
                                break;
                            case "2":
                                //store 102 inventory
                                Dictionary<Shirt, int> invent102 = dbrepo.GetInventoryByStoreId(102);
                                PrintInventory(invent102);
                                Console.WriteLine("Okay! Now that you know our inventory, let's shop!");
                                break;
                            case "3":
                                Dictionary<Shirt, int> invent103 = dbrepo.GetInventoryByStoreId(103);
                                PrintInventory(invent103);
                                Console.WriteLine("Okay! Now that you know our inventory, let's shop!");
                                //store 103 inventory
                                break;
                            case "4":
                                Dictionary<Shirt, int> invent104 = dbrepo.GetInventoryByStoreId(104);
                                PrintInventory(invent104);
                                Console.WriteLine("Okay! Now that you know our inventory, let's shop!");
                                //store 104 inventory
                                break;
                            case "5":
                                Dictionary<Shirt, int> invent105 = dbrepo.GetInventoryByStoreId(105);
                                PrintInventory(invent105);
                                Console.WriteLine("Okay! Now that you know our inventory, let's shop!");
                                //store 105 inventory
                                break;
                        }


                        break;

                    case "2":
                        //display store 101 inventory
                        Dictionary<Shirt, int> inventory101 = dbrepo.GetInventoryByStoreId(101);
                        PrintInventory(inventory101);
                        break;

                    case "3":
                        Console.WriteLine("Goodbye. Have a great day :)");
                        
                        System.Environment.Exit(1);
                        break;

                }


            }






            //Address address = new Address(street, city, state, zip);
            //Customer newCustomer = new Customer(FirstName, LastName, street,  );

            //}






            static void PrintInventory(Dictionary<Shirt, int> invent101)
            {
                foreach (var item in invent101)
                {
                    Console.WriteLine($" Product: {item.Key.Name} Stock: {item.Value} Price: ${item.Key.Price}");
                    Console.WriteLine("Okay! Now that you know our inventory, let's shop!");
                }
            }

            //static void PlaceOrder();
            //{

            //}


        
        }

        
    }
}
