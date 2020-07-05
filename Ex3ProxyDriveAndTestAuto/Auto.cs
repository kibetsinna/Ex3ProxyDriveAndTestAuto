using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3ProxyDriveAndTestAuto
{
    class Auto : IDriveFunction, IInformationFunc

    {
        private int speed = 0;
        private int gasoline = 50;
        private DestCoordinateWaze dc = new DestCoordinateWaze(32.4f, 35.8f);


        public void Start()
        {
            speed = 50;
            Console.WriteLine("Start. " + "Speed=" + GetSpeed());
        }

        public void Stop()
        {

            speed = 0;
            Console.WriteLine("Stop. " + "Speed=" + GetSpeed());
        }

        public void IncreaseSpeed(int delta)
        {
            speed = speed + delta;
            Console.WriteLine("IncreaseSpeed. " + "Speed=" + GetSpeed());
        }

        public void ReduceSpeed(int delta)
        {
            speed = speed - delta;
            Console.WriteLine("ReduceSpeed. " + "Speed=" + GetSpeed());
        }

        public void Right()
        {
            Console.WriteLine("Right");
        }

        public void Left()
        {
            Console.WriteLine("Left");
        }

        public DestCoordinateWaze GetPoint()
        {
            Console.WriteLine("GetPoint= " + dc);
            return dc;
        }

        public int GetStatusGasoline()
        {
            Console.WriteLine("GetStatusGasoline= " + gasoline);
            return gasoline;
        }
        public int GetSpeed()
        {
            return speed;
        }
    }
}
