using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Builder
{
    public class Director
    {
        private IComputerBuilder _builder;

        public Director(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructComputer()
        {
            _builder.SetCPU();
            _builder.SetRAM();
            _builder.SetStorage();
            _builder.SetGPU();
            _builder.SetOS();
        }

        public Computer GetComputer()
        {
            return _builder.GetComputer();
        }
    }

}
