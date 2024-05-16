using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Bike : IVehicle
    {
        private readonly int wheels;
        public Bike()
        {
            this.wheels = 2;
        }
        public int NumberOfWheels()
        {
           return this.wheels;
        }

        public string VehicleType()
        {
            return "Bike"; 
        }
    }
}
