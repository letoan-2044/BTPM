using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225500_DuongTriVi_Real05_Observer
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
