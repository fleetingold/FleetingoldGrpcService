﻿using MagicOnion;

namespace FleetingoldGrpcService.Shared
{
    // Defines .NET interface as a Server/Client IDL.
    // The interface is shared between server and client.
    public interface IFleetingoldService : IService<IFleetingoldService>
    {
        // The return type must be `UnaryResult<T>`.
        UnaryResult<int> SumAsync(int x, int y);
    }
}
