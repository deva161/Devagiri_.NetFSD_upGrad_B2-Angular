using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day1
{
    internal class VehicleImplementation
    {
        static void Main()
        {
            Car car = new Car("Toyota", 2000);
            Bike bike = new Bike("Yamaha", 500);

            Console.WriteLine("Car Rental: " + car.CalculateRental(3));
            Console.WriteLine("Bike Rental: " + bike.CalculateRental(3));
        }
    }
}
