using System;
namespace atmProject
{
    class program 
    {
        public static void Main(string[] args)
        {

            int amount = 100000, deposit, withdraw;
            int choice, pin = 0000, x = 0000;
            Console.WriteLine("Enter Your 4 digit pin ");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("***Welcome to KolaBank ATM Service***\n");
                Console.WriteLine("1. Check your bank Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Change your pin\n");
                Console.WriteLine("5. Quit\n");
                Console.WriteLine("********\n\n");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Your Bank Bance is $ : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n Enter Withdrawal Amount: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n Please enter the amount in multiples of 1000");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\n Insufficient Balance");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n Please take your cash");
                            Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR BALANCE IS {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\nChange your password", pin);
                        pin = int.Parse(Console.ReadLine());
                        if ((pin % 100) != 0000)
                            Console.WriteLine("INCORRECT PASSWORD");
                        break;
                    case 5:
                        Console.WriteLine("\n THANK YOU FOR USING KOLABANK ATM");
                        break;
                }
            }
            Console.WriteLine("\n\n THANKS FOR USING OUR ATM SERVICE");
        }
    }
}


