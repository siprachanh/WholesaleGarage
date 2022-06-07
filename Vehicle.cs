using System;
using System.Collections.Generic;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"Your vehicle turns {direction}");

        }

        public virtual void Stop()

        {
            Console.WriteLine($"Your vehicle stops.");
        }
    }
}