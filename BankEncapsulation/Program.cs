using System;

namespace BankEncapsulation
{
    class Program
    {
        
        
        static double amount;
        static void Main(string[] args)
        {
            BankAccount bank1 = new BankAccount();
            string yes;
            do
            {
                Console.WriteLine("Welcome to Bank Account");
                Console.WriteLine("\n1:Deposit\n2:Withdraw\n3:Balance\n4:Exit");
                Console.Write("\nPick a number to continue:");
                int n;
                bool optionValid  = int.TryParse(Console.ReadLine(), out n);
                while (!optionValid)
                {
                  Console.Write("Please choose a number from the options above:");
                  optionValid = int.TryParse(Console.ReadLine(), out n);

                }
                switch (n)
                {
                    case 1:

                        bool amt = isNumberValid("Please enter amount to be deposited:");

                        while (!amt)
                        {
                            amt = isNumberValid("Please enter a valid amount to be deposited:");
                        }
                        bank1.Deposit(amount);
                        Console.WriteLine($"Current Balance: {bank1.GetBalance()}");
                        break;

                    case 2:
                        bool amt1 = isNumberValid("Amount to be withdrawn:");

                        while (!amt1)
                        {
                            amt1 = isNumberValid("Please enter valid amount to withdraw:");
                        }
                        if (bank1.GetBalance()>amount)
                        {
                            bank1.Withdraw(amount);
                            Console.WriteLine($"Current Balance: {bank1.GetBalance()}");
                        }
                        else
                            Console.WriteLine("You dont have enough balance to withdraw!!");
                        break;

                    case 3:
                        Console.WriteLine($"Current Balance: {bank1.GetBalance()}");
                        break;

                    case 4:
                        Console.WriteLine("You are exited from the program");
                        break;


                    default:
                        Console.WriteLine("Case not handled!!");

                        break;
                }
                Console.Write("Do you want to continue(yes/no):");
                 yes = Console.ReadLine().ToLower();
                if(yes!="yes")
                {
                    Console.WriteLine("you are exiting from the program!!");
                    break;
                }
                
            } while (yes=="yes");

        }
        public static bool isNumberValid(string msg)
        {
            Console.Write(msg);
            return double.TryParse(Console.ReadLine(), out amount);

        }
    }
}

