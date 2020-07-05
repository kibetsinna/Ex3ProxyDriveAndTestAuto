using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3ProxyDriveAndTestAuto
{
    public class InfoProxy : IInformationFunc
    {
        public InfoProxy()
        {
        }


        public DestCoordinateWaze GetPoint()
        {
            IInformationFunc infoAuto = new Auto();
            return infoAuto.GetPoint();
        }

        public int GetStatusGasoline()
        {
            IInformationFunc infoAuto = new Auto();
            return infoAuto.GetStatusGasoline();
        }
    }
}
