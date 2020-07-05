using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3ProxyDriveAndTestAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            GetProxy(new InfoProxy());

            auto.Start();
            auto.Right();
            auto.IncreaseSpeed(10);
            auto.Left();
            auto.ReduceSpeed(20);
            auto.Stop();
            Console.ReadLine();

        }

        static void GetProxy(IInformationFunc proxy)
        {
            proxy.GetPoint();
            proxy.GetStatusGasoline();
        }
    }
}
