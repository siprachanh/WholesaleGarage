using System;
using System.Collections.Generic;

namespace Garage

{
    public interface IGasVehicle

    {
        double CurrentTankPercentage { get; set; }


        void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        double FuelCapacity { get; set; }
    }
}
