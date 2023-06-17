using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Trolleybus : Vehicle
    {
        public Trolleybus(int id, string licensePlate, int maxCapacity, string fuelType, DateTime lastServiceDate)
        : base(id, licensePlate, maxCapacity, fuelType, lastServiceDate)
        {
            if (fuelType != "Gas" && fuelType != "Electric")
            {
                Console.WriteLine("Invalid fuel type for a Trolleybus.");
            }
        }
    }
}
