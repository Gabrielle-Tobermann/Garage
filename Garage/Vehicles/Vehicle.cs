using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Vehicles
{
    abstract class Vehicle
    {
        public string Fuel { get; set; }
        public string Color { get; set; }
        public string PassengerOccupancy { get; set; }

        public virtual void Refuel()
        {
            Console.WriteLine("I'm refueling");
        }

        public virtual void Driving()
        {
            Console.WriteLine("I'm driving");
        }

    }
}
