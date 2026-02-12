using FleetManagement.Core;
using Xunit;

namespace FleetManagement.Tests;

public class VehicleTests
{
    [Fact]
    public void Car_Start_DecreasesFuelByOne()
    {
        var car = new Car("Honda", "City", 5);

        car.Start();

        Assert.Equal(4, car.FuelLevel);
    }

    [Fact]
    public void Truck_Start_DecreasesFuelByTwo()
    {
        var truck = new Truck("MAN", "TGX", 6);

        truck.Start();

        Assert.Equal(4, truck.FuelLevel);
    }

    [Fact]
    public void Vehicle_Cannot_Start_With_Zero_Fuel()
    {
        var car = new Car("Ford", "Focus", 0);

        Assert.Throws<InvalidOperationException>(() => car.Start());
    }
}
