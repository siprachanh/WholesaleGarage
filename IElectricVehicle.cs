using System;
using System.Collections.Generic;

namespace Garage
{
    public interface IElectricVehicle

    {
        // public double BatteryKWh { get; set; }

        double CurrentChargePercentage { get; set; }

        void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }
}