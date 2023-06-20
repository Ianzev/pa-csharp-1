using Vehicles;
namespace pa_csharp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime lastServiceDate = new DateTime(2021, 3, 15);
            Bus bus = new Bus(1, "DZG56106", 50, lastServiceDate, 7);
            Console.WriteLine(bus.Status);

            VehiclesStatus vehicleStatus = new VehiclesStatus();

            vehicleStatus.AddVehicle(new Bus(1,"KRKRKR", 50, DateTime.Now.AddMonths(-1), 6));
            vehicleStatus.AddVehicle(new Bus(1, "KRKRKR", 50, DateTime.Now.AddMonths(-12), 3));
            vehicleStatus.AddVehicle(new Trolleybus(2, "KWIKWI", 30, "Electric", DateTime.Now.AddMonths(-10)));
            vehicleStatus.AddVehicle(new Trolleybus(4, "KWIKWI", 35, "Gas", DateTime.Now.AddMonths(-4)));
            vehicleStatus.AddVehicle(new Tram(6, "KCBKBC", 80, DateTime.Now.AddMonths(-3), 5));
            vehicleStatus.AddVehicle(new Tram(8, "KCBKBC", 70, DateTime.Now.AddMonths(-1), 6));

            int busesInOperationCount = vehicleStatus.VehiclesStatusCounter("Bus", "In operation");
            int busesNeedRepairCount = vehicleStatus.VehiclesStatusCounter("Bus", "Need repair");
            int trolleybusesInOperationCount = vehicleStatus.VehiclesStatusCounter("Trolleybus", "In operation");
            int tramsForScrapCount = vehicleStatus.VehiclesStatusCounter("Tram", "For scrap");


            Console.WriteLine($"Buses in operation: {busesInOperationCount}");
            Console.WriteLine($"Buses need repair: {busesNeedRepairCount}");
            Console.WriteLine($"Trolleybuses in operation: {trolleybusesInOperationCount}");
            Console.WriteLine($"Trams for scrap: {tramsForScrapCount}");

            List<string> stops = new List<string> { "Kraków", "Wieliczka", "Bochnia" };
            Routes routes = new Routes(stops);


            Bus bus1 = new Bus(1, "KRCKRC", 500, DateTime.Now.AddDays(-120), 6);
            Bus bus2 = new Bus(1, "KKRKKR", 500, DateTime.Now.AddDays(-400), 6);
            Trolleybus trolleybus1 = new Trolleybus(2, "KRKKR", 500, "Electric", DateTime.Now.AddMonths(-1));
            Trolleybus trolleybus2 = new Trolleybus(2, "KRKRKR", 500, "Electric", DateTime.Now.AddMonths(-10));


            routes.AddVehicle(bus1);
            routes.AddVehicle(bus2);
            routes.AddVehicle(trolleybus1);
            routes.AddVehicle(trolleybus2);


            Console.WriteLine("Stops on the route:");
            foreach (string stop in routes.Stops)
            {
                Console.WriteLine(stop);
            }

            Console.WriteLine("Operating vehicles on the route:");
            foreach (Vehicle vehicle in routes.Vehicles)
            {
                Console.WriteLine($"Vehicle: {vehicle.LicensePlate}, Type: {vehicle.GetType().Name}");
            }
        }
    }
}