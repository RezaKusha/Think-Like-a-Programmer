using System;

namespace Automobile
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            Automobile car = new Automobile();
            Automobile car2 = new Automobile();
            
            car.CompleteInformation("BMW","Z4",1999);
            Console.Write(car.GetAge());
            Console.WriteLine();
            
            car2.CompleteInformation("Chevrolet","Impala",1965);
            Console.Write(car2.GetAge());
            Console.WriteLine();
        }
    }
}