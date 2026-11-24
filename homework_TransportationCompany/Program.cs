enum FuelType
{
    Petrol,
    Diesel,
    Electric
}

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public FuelType Fuel { get; set; }

    public static int Count = 0;

    public Vehicle(string brand, string model, int year, FuelType fuel)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Fuel = fuel;
       
        Count++;
    }

    public virtual void StartEngine()
    {
        Console.WriteLine("Vehicle engine started.");
    }

    public string Info()
    {
        return $"Brand: {Brand}, Model: {Model}, Year: {Year}, Fuel Type: {Fuel}";
    }
}

class Car : Vehicle
{ public Car (string brand, string model, int year, FuelType fuel) : base(brand, model, year, fuel)
    {
    }
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }
}

class Truck : Vehicle
{
    public Truck(string brand, string model, int year, FuelType fuel) : base(brand, model, year, fuel)
    {
    }
    public override void StartEngine()
    {
        Console.WriteLine("Truck engine started.");
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string brand, string model, int year, FuelType fuel) : base(brand, model, year, fuel)
    {
    }
    public override void StartEngine()
    {
        Console.WriteLine("Motorcycle engine started.");
    }
}

class Program
{
    static void Main()
    {
        Vehicle[] fleet =
            [
                new Car("Togg", "T10x", 2024, FuelType.Electric),
                new Truck("Ford", "F-150", 2019, FuelType.Diesel),
                new Motorcycle("Harley-Davidson", "Street 750", 2021, FuelType.Petrol)

            ];

        foreach (Vehicle vehicle in fleet)
        {
            Console.WriteLine(vehicle.Info());
            vehicle.StartEngine();
            Console.WriteLine();
        }
        Console.WriteLine($"Total vehicles created: {Vehicle.Count}");
    }
}

