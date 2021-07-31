using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Cars
{
    class Corolla : Car
    {
        public string Age { get; set; }
        public bool DoorsLocking { get; set; }

        public void CleanYourCar()
        {
            Console.WriteLine("Do you need to clean your car?");
            var answer = Console.ReadLine();
        }

        public void CarAge()
        {
            Console.WriteLine("How old is this car?");
            Age = Console.ReadLine();
        }
    }
}
