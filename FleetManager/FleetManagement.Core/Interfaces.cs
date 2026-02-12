namespace FleetManagement.Core;

public interface IMaintainable
{
    void ScheduleMaintenance();
}

public interface ITrackable
{
    string GetLocation();
}
