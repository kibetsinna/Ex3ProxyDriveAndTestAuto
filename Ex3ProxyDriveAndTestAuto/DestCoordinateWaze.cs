using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3ProxyDriveAndTestAuto
{
    public class DestCoordinateWaze
    {
        private float latitude;
        private float longitude;
        public DestCoordinateWaze(float x, float y)
        {
            latitude = x;
            longitude = y;
        }
        public override string ToString()
        {
            return "Latitude=" + latitude.ToString() + ". Longitude=" + longitude.ToString();
        }

    }
}
