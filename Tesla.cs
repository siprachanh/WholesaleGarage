using System;
using System.Collections.Generic;


namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        // public string MainColor { get; set; }
        // public int MaximumOccupancy { get; set; }
        // now any instance of Tesla will have both of those props on it automatically
        public double CurrentChargePercentage { get; set; } = 100;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"Your vehicle turns {direction}");

        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives ...");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Vehicle rolls to a stop.");
        }
    }
}