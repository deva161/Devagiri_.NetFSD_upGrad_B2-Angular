using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    interface IDiscountStrategy
    {
        double CalculateDiscount(double amount);
    }
    class RegularCustomerDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount - (amount / 100 * 10);
        }
    }


    class PremiumCustomerDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount - (amount / 100 * 15);
        }
    }

    class VipCustomerDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return amount - (amount / 100 * 25);
        }
    }
    internal class problem2
    {
        static void Main()
        {
            int amount = 2500;
            RegularCustomerDiscount reg = new RegularCustomerDiscount();
            PremiumCustomerDiscount pre = new PremiumCustomerDiscount();
            VipCustomerDiscount vip = new VipCustomerDiscount();
            Console.WriteLine($"Final Amount after Discount for regular Customer : {reg.CalculateDiscount(amount)}");
            Console.WriteLine($"Final Amount after Discount for premium customer : {pre.CalculateDiscount(amount)}");
            Console.WriteLine($"Final Amount after Discount for Vip Customer : {vip.CalculateDiscount(amount)}");
        }
    }
}
