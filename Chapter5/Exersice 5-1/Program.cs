using System;

namespace Automobile
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            Automobile car = new Automobile();
            Automobile car2 = new Automobile();
            
            car.SetName("peykan");
            car.SetYear(1980);
            car.SetCompanyName("IKCO");
            
            car2.SetName("S500");
            car2.SetYear(2015);
            car2.SetCompanyName("Benz");

            Console.WriteLine($"{car.GetCompanyName()} {car.GetName()} {car.GetYear()}");
            Console.WriteLine($"{car2.GetCompanyName()} {car2.GetName()} {car2.GetYear()}");
        }
    }
}