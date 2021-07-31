using System;
using System.Collections.Generic;
using Garage.Aircrafts;
using Garage.Boats;
using Garage.Cars;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            var jimsPlane = new Aircraft();
            var caseysPlane = new Aircraft();
            var chiesPlane = new Aircraft();

            var lindseysCar = new Car();
            var tadsCar = new Car();
            var matthewsCar = new Car();

            var mitchellsBoat = new WaterCraft();
            var katysBoat = new WaterCraft();
            var seansBoat = new WaterCraft();

            // Build a collection of all vehicles that fly
            var vehiclesThatFly = new List<Aircraft>() { jimsPlane, caseysPlane, chiesPlane };
            // With a single `foreach`, have each vehicle Fly()
            foreach (var v in vehiclesThatFly )
            {
                v.Flying();
            }

            // Build a collection of all vehicles that operate on roads
            var cars = new List<Car>() { lindseysCar, tadsCar, matthewsCar };
            // With a single `foreach`, have each road vehicle Drive()
            foreach (var c in cars)
            {
                c.Driving();
            }
            // Build a collection of all vehicles that operate on water
            var boats = new List<WaterCraft>() { mitchellsBoat, seansBoat, katysBoat };
            // With a single `foreach`, have each water vehicle Drive()
            foreach (var b in boats)
            {
                b.Driving();
            }
        }
    }
}
