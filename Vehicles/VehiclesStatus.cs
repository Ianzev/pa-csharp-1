using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class VehiclesStatus
    {
        public List<Vehicle> vehicles;

        public VehiclesStatus()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public int VehiclesStatusCounter(string vehicleType, string status)
        {
            int count = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                string currentVehicleType = vehicle.GetType().Name;
                if (currentVehicleType == vehicleType && vehicle.Status == status)
                {
                    count++;
                }
            }

            return count; ;
        }
    }
}
