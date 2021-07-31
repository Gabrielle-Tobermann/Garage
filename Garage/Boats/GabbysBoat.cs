using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Boats
{
    class GabbysBoat : WaterCraft
    {
        public string sizeOfJacuzzi { get; set; }
        
        public void WhatsTheSizeOfJacuzzi()
        {
            Console.WriteLine("Gabby, how big is the jacuzzi on your boat?");
            sizeOfJacuzzi = Console.ReadLine();
        }
    }
}
