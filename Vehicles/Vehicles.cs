namespace Vehicles
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public int MaxCapacity { get; set;}
        public string Status { get; set; }
        public string FuelType { get; set; }
        public DateTime LastServiceDate { get; set; }

        public Vehicle(int id, string licensePlate, int maxCapacity, string fuelType, DateTime lastServiceDate)
        {
            Id = id;
            LicensePlate = licensePlate;
            MaxCapacity = maxCapacity;
            FuelType = fuelType;
            LastServiceDate = lastServiceDate;

            if ((DateTime.Now - lastServiceDate).TotalDays <= 180)
            {
                Status = "In operation";
            }
            else if ((DateTime.Now - lastServiceDate).TotalDays <= 1095)
            {
                Status = "Need repair";
            }
            else
            {
                Status = "For scrap";
            }
        }

    }
}