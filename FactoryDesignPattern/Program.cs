using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Vehicle Type");
            string userInput=Console.ReadLine();   
            IVehicle Type=VehicleFactory.GetVehicle(userInput);
            Console.WriteLine("Vehicle Type is "+ Type.VehicleType());
            Console.WriteLine("Vehicle Wheels are " + Type.NumberOfWheels());
            Console.ReadLine();
        }
    }
}
