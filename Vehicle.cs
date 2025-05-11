namespace CarRental
{
    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsRented { get; private set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            IsRented = false;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"\n{Year} {Make} {Model} - Rented: {IsRented}");
        }

        public bool Rent()
        {
            if (IsRented) return false;
            IsRented = true;

            return true;
        }
        public void Return()
        {
            IsRented = false;
        }
    }
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int year, int doors) : base(make, model, year)
        {
            NumberOfDoors = doors;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Car - Doors: {NumberOfDoors}");
        }
    }
    class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, int year, bool hasSidecar) : base(make, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Motorcycle - Has Sidecar: {HasSidecar}");
        }
    }
    class Van : Vehicle
    {
        public bool HasSlidingDoor { get; set; }
        public Van(string make, string model, int year, bool hasSlidingDoor) : base(make, model, year)
        {
            HasSlidingDoor = hasSlidingDoor;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Van - Has Sliding Door: {HasSlidingDoor}");
        }
    }
}
