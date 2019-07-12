using System;
using System.Threading;
using Grpc.Core;
using MagicOnion;

namespace TheServer.Interfaces
{
    public interface IMyFirstService:IService<IMyFirstService>
    {
        UnaryResult<int> SumAsync(int x, int y);
        
    }
}
