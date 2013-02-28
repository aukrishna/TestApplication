using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cashier
{
    /// <summary>
    /// This class simulates a cashier and prompts user to pay money through several payment options.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Generating a Random number under 1000 using Random class and its Next method.  And declaring other variables.
            Random r = new Random((int)DateTime.Now.Ticks);
            int amount = r.Next(1000);
            int option;

            //Greeting the customer and printing menu.
            Console.WriteLine("Greetings!  How would you like to pay today?  Choose an options from the below options:");
            Console.WriteLine("1. Cash\n2. Check\n3. Debit Card\n4. Credit Card\n5. I do not want to buy it today.\n\n");

            //Reading user option and converting it to integer value
            option = Convert.ToInt32(Console.ReadLine());

            if (option > 0 && option < 6)
            {


                switch (option)
                {
                    case 1:
                        Console.WriteLine("You have choose to pay amount ${0} through Cash", amount);
                        break;

                    case 2:
                        Console.WriteLine("You have chose to pay amount ${0} through Check", amount);
                        break;

                    case 3:
                        Console.WriteLine("You have chose to pay amount ${0} through Debit card", amount);
                        //if user selects Debit Card option, asking him if he needs any cash back
                        Console.WriteLine("Do you want any cash back? choose \n1.Yes\n2.No");
                        string CashWant = Console.ReadLine();
                        if (CashWant == "Yes"||CashWant=="yes"||CashWant=="1")
                        {
                            Console.WriteLine("Enter the amount of cash you want:");
                            int CashBack = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("you total amount to pay is {0}",CashBack+amount);
                        }
                        else
                        {
                            Console.WriteLine("Thanks for shopping with us.  Please pay ${0}", amount);
                        }
                        break;

                    case 4:
                        Console.WriteLine("You have chose to pay amount ${0} through Credit card", amount);
                        break;

                    case 5:
                        Console.WriteLine("You have chose not to buy anything today.  Have a good day!", amount);
                        break;
                }
            }
            else
            {
                Console.WriteLine("You have not entered a valid choice");
            }
            Console.WriteLine("Thanks for shopping with use today!!");
            Console.ReadLine();
        }
    }
}
