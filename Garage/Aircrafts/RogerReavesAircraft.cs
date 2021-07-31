using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Aircrafts
{
    class RogerReavesAircraft : Aircraft
    {
        public string Drugs { get; set; }
        public string Client { get; set; }

        public void WhatAreYouCarrying()
        {
            Console.WriteLine("Roger, what kind of drugs are you carrying in your plane today?");
            Drugs = Console.ReadLine();
        }

        public void WhosPayingForTheDrugs()
        {
            Console.WriteLine("Roger, whose drugs are you carrying in your plane today?");
            Client = Console.ReadLine();
        }
    }
}
