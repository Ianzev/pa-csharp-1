using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public int PollutionIndicator { get; set; }

        public Bus(int id, string licensePlate, int maxCapacity, DateTime lastServiceDate, int pollutionIndicator)
        : base(id, licensePlate, maxCapacity, "Gas", lastServiceDate)
        {
            PollutionIndicator = pollutionIndicator;

            int monthsLastService = (DateTime.Now.Year - lastServiceDate.Year) * 12 + DateTime.Now.Month - lastServiceDate.Month;

            if (monthsLastService <= 6)
            {
                if (pollutionIndicator > 5)
                {
                    Status = "In operation";
                }
                else if (pollutionIndicator >= 3 && pollutionIndicator <= 5)
                {
                    Status = "Need repair";
                }
                else
                {
                    Status = "For scrap";
                }
            }
            else if (monthsLastService <= 12)
            {
                if (pollutionIndicator >= 3 && pollutionIndicator <= 5)
                {
                    Status = "Need repair";
                }
                else
                {
                    Status = "For scrap";
                }
            }
            else
            {
                Status = "For scrap";
            }
        }
    }
}
