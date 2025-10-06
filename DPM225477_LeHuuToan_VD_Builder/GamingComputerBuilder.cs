using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Builder
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU() => _computer.CPU = "Intel Core i9";
        public void SetRAM() => _computer.RAM = "32GB";
        public void SetStorage() => _computer.Storage = "1TB SSD";
        public void SetGPU() => _computer.GPU = "RTX 4080";
        public void SetOS() => _computer.OS = "Windows 11";

        public Computer GetComputer() => _computer;
    }

}
