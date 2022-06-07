using System;
using System.Collections.Generic;


namespace Garage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        // public string MainColor { get; set; }
        // public int MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public double CurrentTankPercentage { get; set; } = 64.2;
        public override void Turn(string direction)
        {
            Console.WriteLine($"Your vehicle turns {direction}");

        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives ...");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Vehicle rolls to a stop.");
        }
    }

}