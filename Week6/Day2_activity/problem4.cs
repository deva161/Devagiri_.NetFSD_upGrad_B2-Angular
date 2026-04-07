using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IPrint
    {
        void Print();
    }
    interface IScan
    {
        void Scan();
    }
    interface IFax
    {
        void Fax();
    }

    class BasicPrinter : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Basic Printer can only Prints");
        }
    }

    class AdvancedPrinter : IPrint, IFax, IScan
    {
        public void Fax()
        {
            Console.WriteLine("AdvancedPrinter can Fax");
        }

        public void Print()
        {
            Console.WriteLine("AdvancedPrinter can Print");
        }

        public void Scan()
        {
            Console.WriteLine("AdvancedPrinter can Scan");
        }
    }

    internal class problem4
    {

        static void Main()
        {
            BasicPrinter basicPrinter = new BasicPrinter();
            basicPrinter.Print();

            AdvancedPrinter advancedPrinter = new AdvancedPrinter();
            advancedPrinter.Print();
            advancedPrinter.Fax();
            advancedPrinter.Scan();
        }
    }
}
