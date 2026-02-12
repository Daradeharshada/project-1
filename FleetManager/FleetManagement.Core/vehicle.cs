namespace FleetManagement.Core;

public abstract class Vehicle
{
    private double _fuelLevel;

    public int Id { get; }
    public string Make { get; }
    public string Model { get; }

    public double FuelLevel
    {
        get => _fuelLevel;
        protected set
        {
            if (value < 0)
                throw new ArgumentException("Fuel level cannot be below zero");
            _fuelLev_
