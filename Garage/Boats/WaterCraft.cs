using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Boats
{
    class WaterCraft : Vehicles.Vehicle
    {
        public string FuelCapacity { get; set; }

        public override void Refuel()
        {
            Console.WriteLine("How do you even refuel a boat");
        }

        public override void Driving()
        {
            Console.WriteLine("Driving a boat");
        }
    }
}
