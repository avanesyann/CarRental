namespace CarRental
{
    class RentalService
    {
        public List<Vehicle> Vehicles { get; set; }

        public RentalService()
        {
            Vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void ShowAllVehicles()
        {
            Console.WriteLine("\nAll Vehicles:");
            foreach (var vehicle in Vehicles)
            {
                vehicle.DisplayInfo();
            }
        }
        public void ShowAvailableVehicles()
        {
            Console.WriteLine("\nAvailable Vehicles:");
            foreach (var vehicle in Vehicles)
            {
                if (!vehicle.IsRented)
                    vehicle.DisplayInfo();
            }
        }

        public void RentVehicle(string model)
        {
            var vehicle = Vehicles.FirstOrDefault(x => x.Model == model);
            if (vehicle != null && vehicle.Rent())
                Console.WriteLine($"\nYou rented: {vehicle.Model}");
            else
                Console.WriteLine("\nVehicle not available.");
        }

        public void ReturnVehicle(string model)
        {
            var vehicle = Vehicles.FirstOrDefault(x => x.Model == model && x.IsRented);
            if (vehicle != null)
            {
                vehicle.Return();
                Console.WriteLine($"\nYou returned: {vehicle.Model}");
            }
            else
            {
                Console.WriteLine("\nVehicle not found or not rented.");
            }
        }
    }
}
