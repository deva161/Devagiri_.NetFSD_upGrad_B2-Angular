using System;


namespace Day5
{
    internal class BankImplementation
    {
        static double Amount()
        {
            Console.Write("Enter Amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());
            return amount;
        }
        static void Main()
        {
            double amount;
            Console.Write("1.ShowBalance\n2.Deposit\n3.Withdraw\nEnter operation : ");
            byte operation = Convert.ToByte(Console.ReadLine());
            Bank bank = new Bank();

            switch (operation)
            {
                case 1:
                    bank.GetBalance();
                    break;
                case 3:
                    amount=Amount();
                    bank.Withdraw(amount);
                    break;
                case 2:
                    amount =  Amount();
                    bank.Deposit(amount);
                    break;
                default:
                    Console.WriteLine("Enter only 1,2,3");
                    break;
            }
        }
    }
}
