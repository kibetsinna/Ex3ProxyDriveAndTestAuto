using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3ProxyDriveAndTestAuto
{
    public interface IDriveFunction
    {
        void Start();
        void Stop();

        void IncreaseSpeed(int delta);
        void ReduceSpeed(int delta);

        void Right();

        void Left();
    }
}
