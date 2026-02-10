using System.Threading;

namespace FleetManagement.Core;

public static class IdGenerator
{
    private static int _id = 0;

    public static int NextId()
    {
        return Interlocked.Increment(ref _id);
    }
}
