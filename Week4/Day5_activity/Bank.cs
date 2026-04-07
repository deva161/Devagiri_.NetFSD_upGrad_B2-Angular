using System;


namespace Day5
{
    internal class Bank
    {
        private double balance=2500;

        public double Balance
        {
            get { return balance; }
            set
            {
                balance = value;
            }
            
        }
        public void Deposit(double amount)
        {
            Balance += amount ;
            GetBalance();
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficent Balance");
            }
            else
            {
                Balance -= amount;
                GetBalance();
            }
        }

        public void GetBalance()
        {
            Console.WriteLine($"Final Balance : { balance}");
        }
    }
}
