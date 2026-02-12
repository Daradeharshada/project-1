namespace FleetManagement.Core;

public class Truck : Vehicle
{
    public Truck(string make, string model, double fuel)
        : base(make, model, fuel)
    {
    }

    public override void Start()
    {
        if (FuelLevel < 2)
            throw new InvalidOperationException("Truck needs at least 2 fuel");

        FuelLevel -= 2;
    }
}
