using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle(string objType)
        {
            IVehicle vehicle = null;
            if(objType.ToLower().Equals("bike"))
            {
                vehicle = new Bike();
            }
            else if (objType.ToLower().Equals("car"))
            {
                vehicle = new Car();
            }
            return vehicle; 


        }
    }
}
