using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Cars
{
    class Car : Vehicles.Vehicle
    {
        //public string Fuel { get; set; }
        public string BatteryCapacity{ get; set; }
        //public string Color { get; set; }

        public override void Refuel()
        {
            Console.WriteLine("I'm refueling my car right now");
        }

        public override void Driving()
        {
            Console.WriteLine("I'm driving my car right now");
        }

        public void Braking()
        {
            Console.WriteLine("Oops... almost hit somebody lol");
        }
    }
}
