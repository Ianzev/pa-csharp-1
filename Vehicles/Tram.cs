using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Tram : Vehicle
    {
        public int YearsInService { get; set; }

        public Tram(int id, string licensePlate, int maxCapacity, DateTime lastServiceDate, int yearsInService)
        : base(id, licensePlate, maxCapacity, "Electric", lastServiceDate)
        {
            YearsInService = yearsInService;
        }
    }
}
