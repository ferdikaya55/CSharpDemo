using System;

namespace VirtualAndOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            OldCar oldCar = new OldCar();
            Console.WriteLine("Car Price: " + car.Price());
            Console.WriteLine("Old Car Price: "+ oldCar.Price());
        }
    }
}
