using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnW6D1
{
    internal class orderProcessing
    {
        public static async Task VerifyPaymentAsync()
        {
            Console.WriteLine("Payment verification started...");
            await Task.Delay(2000);
            Console.WriteLine("Payment verified!");
        }

        public static async Task CheckInventoryAsync()
        {
            Console.WriteLine("Inventory check started...");
            await Task.Delay(1500);
            Console.WriteLine("Inventory available!");
        }

        public static async Task ConfirmOrderAsync()
        {
            Console.WriteLine("Order confirmation started...");
            await Task.Delay(1000);
            Console.WriteLine("Order confirmed!");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Order processing started...\n");

            
            await VerifyPaymentAsync();
            await CheckInventoryAsync();
            await ConfirmOrderAsync();

            Console.WriteLine("\nOrder processed successfully!");
        }
    }
}
