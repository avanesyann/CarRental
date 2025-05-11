namespace CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentalService service = new RentalService();

            service.AddVehicle(new Car("Toyota", "Camry", 2019, 4));
            service.AddVehicle(new Car("BMW", "M3", 2018, 4));
            service.AddVehicle(new Motorcycle("Harley", "Iron883", 2019, false));
            service.AddVehicle(new Van("Toyota", "Sienna", 2025, false));

            service.ShowAvailableVehicles();

            service.RentVehicle("Camry");
            service.RentVehicle("Iron883");
            service.RentVehicle("Sienna");

            service.ShowAllVehicles();

            service.ReturnVehicle("M3");
            service.ReturnVehicle("Camry");
            service.ShowAvailableVehicles();
        }
    }
}
