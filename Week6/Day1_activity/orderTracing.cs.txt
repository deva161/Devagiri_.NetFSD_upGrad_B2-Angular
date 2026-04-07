using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HandsOnW6D1
{
    internal class orderTracing
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new TextWriterTraceListener("order_log.txt"));
            Trace.AutoFlush = true;

            try
            {
                Trace.TraceInformation("Order processing started");

                ValidateOrder();
                ProcessPayment();
                UpdateInventory();
                GenerateInvoice();

                Trace.TraceInformation("Order processed successfully");
            }
            catch (Exception ex)
            {
                Trace.WriteLine("ERROR: " + ex.Message);
            }

            Console.WriteLine("Check 'order_log.txt' for trace logs.");
        }

        static void ValidateOrder()
        {
            Trace.WriteLine("Step 1: Validating Order...");
           
        }

        static void ProcessPayment()
        {
            Trace.WriteLine("Step 2: Processing Payment...");
          
        }

        static void UpdateInventory()
        {
            Trace.WriteLine("Step 3: Updating Inventory...");
        }

        static void GenerateInvoice()
        {
            Trace.WriteLine("Step 4: Generating Invoice...");
            
        }
    }
}
