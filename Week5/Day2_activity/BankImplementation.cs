using Microsoft.VisualBasic;
using System;


namespace StudentRecords
{
    class InsuffecientBalanceException(string message) : Exception(message)
    {

    }
    class Bank
    {
        private double balance = 2500;
        public void withdraw(double amount)
        {
            try
            { 
                if (amount > balance)
                {
                    throw new InsuffecientBalanceException("Insuffecient Balance Exception.");
                }
                else
                {
                    balance -= amount;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                display();
            }
        }
        public void display()
        {
            Console.WriteLine(balance);
        }
    }
    internal class BankImplementation
    {

        static void Main()
        {
            Bank b = new Bank();

            Console.WriteLine("Enter amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            b.withdraw(amount);

        }

    }
}