using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Routes
    {
        public List<string> Stops { get; }
        public List<Vehicle> Vehicles { get; }

        public Routes(List<string> stops)
        {
            Stops = stops;
            Vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle.Status == "In operation")
            {
                Vehicles.Add(vehicle);
            }
        }
    }
}
