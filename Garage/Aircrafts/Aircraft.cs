using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Aircrafts
{
    class Aircraft : Vehicles.Vehicle
    {
        public string FuelCapacity { get; set; }
        //public string PassengerOccupancy { get; set; }
        //public string Color { get; set; }

        public override void Refuel()
        {
            Console.WriteLine("I'm refueling. Going to make sure to delay the flight by 6 hours.");
        }

        public void Flying()
        {
            Console.WriteLine("We're literally flying right now");
        }

        public void Landing()
        {
            Console.WriteLine("I don't know how to land a plane...");
        }
    }
}
