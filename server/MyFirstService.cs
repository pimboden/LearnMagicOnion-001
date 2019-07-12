using System.Threading.Tasks;
using MagicOnion;
using MagicOnion.Server;
using TheServer.Interfaces;

namespace TheServer.Server
{
    public class MyFirstService : ServiceBase<IMyFirstService>, IMyFirstService
    {
        public async UnaryResult<int> SumAsync(int x, int y)
        {
            await Task.Yield();
            return x+y;
        }

    }
}
