// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using FleetManagement.Core;

var vehicles = new List<Vehicle>
{
    new Car("Toyota", "Corolla", 10),
    new Truck("Volvo", "FH", 20)
};

foreach (var vehicle in vehicles)
{
    vehicle.Start();
    Console.WriteLine(
        $"{vehicle.GetType().Name} {vehicle.Id} started. Fuel left: {vehicle.FuelLevel}"
    );
}
