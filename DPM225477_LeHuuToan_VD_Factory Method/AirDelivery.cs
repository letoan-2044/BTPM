using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Factory_Method
{
    using System;

    public class AirDelivery : IDelivery
    {
        public void Deliver(string package)
        {
            Console.WriteLine($"Giao hàng '{package}' bằng máy bay ✈️");
        }
    }

}
