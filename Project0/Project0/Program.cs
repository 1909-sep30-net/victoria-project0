using business;
using System;

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

            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();

            int a;

            do
            {
                Console.WriteLine("The default store is Store #101. Would you like to: ");
                Console.WriteLine("1 - Switch Stores");
                Console.WriteLine("2 - Start Shopping");
                Console.WriteLine("3 - Exit");
                Console.WriteLine("Type your selection");

                string userSelection1 = Console.ReadLine();
               
                bool success = int.TryParse(userSelection1, out a);
                if (success)
                {
                    if (a == 1)
                    {
                        Console.WriteLine("Choose the store you would like to shop at: ");
                        Console.WriteLine("1 - Store #101");
                        Console.WriteLine("2 - Store #102");
                        Console.WriteLine("3 - Store #103");
                        Console.WriteLine("4 - Store #104");
                        Console.WriteLine("5 - Store #105");
                        Console.WriteLine("6 - Return to previous menu");
                        Console.WriteLine("Type your selection");

                        int b;
                        string userSelection2 = Console.ReadLine();
                        bool success2 = int.TryParse(userSelection1, out b);
                        if (success2)
                        {
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
                                //display previous menu
                            }
                        }



                    }
                    else if (a ==2)
                    {
                        //display inventory from default store
                    }
        

                }
       

            } while (a == 3); //exit the program
            


              
           
        
      



            new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address
            
            };

           







            {
            }
            

        }
    }

   


}
