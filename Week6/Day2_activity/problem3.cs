using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IShape
    {
        double CalculateArea();
    }
    class Rectangle : IShape
    {
        public double CalculateArea()
        {
            int length = 25;
            int breadth = 10;
            return length*breadth;
        }
    }
    class Circle : IShape
    {
        public double CalculateArea()
        {
            return 3.14 * 6 * 6;
        }
    }

    class Application
    {
        public Application(IShape shape)
        {
           Console.WriteLine (shape.CalculateArea());
        }
    }
    
    internal class problem3
    {
        static void Main()
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Console.Write("Area Of Circle : ");
            Application app1 = new Application(circle);
            Console.WriteLine();
            Console.Write("Area Of Rectangle : ");
            Application app2 = new Application(rectangle);
        }
    }
}
