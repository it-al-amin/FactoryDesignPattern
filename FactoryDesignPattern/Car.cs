using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Car : IVehicle
    {
        private readonly int wheels;//can initialize one time then it will be read only
        public Car()
        {
            this.wheels = 4;
        }
        public int NumberOfWheels()
        {
            return this.wheels;
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
}
