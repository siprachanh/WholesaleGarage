using System;
using System.Collections.Generic;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        // public string MainColor { get; set; }
        // public int MaximumOccupancy { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public double CurrentTankPercentage { get; set; } = 98.3;
        public override void Drive()
        {
            Console.WriteLine("Zoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna flashes by...");
        }

        public override void Stop()
        {
            Console.WriteLine("The {Vehicle} rolls down the runway for a mile and stops.");
        }
    }
}