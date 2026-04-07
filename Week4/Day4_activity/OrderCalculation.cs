using System;


namespace Assignments
{
    internal class OrderCalculation
    {
        static double CalculateFinalAmount(int price, byte quantity,out double subtotal,out double discountPrice, int discount = 0, int shippingCharges = 50)
        {
            subtotal = price * quantity;
            discountPrice= ((price * quantity) / 100) * discount;
            return subtotal+discountPrice+ shippingCharges;
        }
    static void Main()
        {
            int shippingPrice = 50;
            double subtotal, discountPrice, FinalAmount;
            Console.Write("Enter price of a product : ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity : ");
            byte quantity = Convert.ToByte(Console.ReadLine());
            FinalAmount = CalculateFinalAmount(price, quantity,out subtotal,out discountPrice);

            Console.WriteLine("Before Discount");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"subtotal : {subtotal}\nDiscountPrice : {discountPrice}\nShipping Price : {shippingPrice}\nFinalAmount : {FinalAmount}\n");
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter Discount : ");
            int discount = Convert.ToInt32(Console.ReadLine());

            FinalAmount = CalculateFinalAmount(price, quantity, out subtotal, out discountPrice, discount: discount);
            Console.WriteLine("After Discount ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"subtotal : {subtotal}\nDiscountPrice : {discountPrice}\nShipping Price : {shippingPrice}\nFinalAmount : {FinalAmount}");
            Console.WriteLine("------------------------------------------");
        }
    }
}
