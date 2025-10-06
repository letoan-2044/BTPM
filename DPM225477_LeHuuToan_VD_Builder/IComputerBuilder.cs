using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Builder
{
    public interface IComputerBuilder
    {
        void SetCPU();
        void SetRAM();
        void SetStorage();
        void SetGPU();
        void SetOS();
        Computer GetComputer();
    }

}
