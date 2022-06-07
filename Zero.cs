using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        // public string MainColor { get; set; }
        // public int MaximumOccupancy { get; set; }
        public double CurrentChargePercentage { get; set; } = 70;
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }
}