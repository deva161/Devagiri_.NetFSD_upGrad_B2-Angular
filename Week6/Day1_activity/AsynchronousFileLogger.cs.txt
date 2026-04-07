using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnW6D1
{
    internal class AsynchronousFileLogger
    {
        public static async Task WriteLogAsync(string message)
        {
            Console.WriteLine($"Start writing: {message}");

            await Task.Delay(2000); 

            Console.WriteLine($"Finished writing: {message}");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Logging started...\n");

            Task t1 = WriteLogAsync("User logged in");
            Task t2 = WriteLogAsync("File uploaded");
            Task t3 = WriteLogAsync("Error occurred");

            Console.WriteLine("Main thread is free...\n");

            await Task.WhenAll(t1, t2, t3);

            Console.WriteLine("\nLogging completed.");
        }
    }
}
