using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Factory_Method
{
    public abstract class DeliveryFactory
    {
        public abstract IDelivery CreateDelivery();
    }

}
