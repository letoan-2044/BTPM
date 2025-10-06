using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Builder
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU() => _computer.CPU = "Intel Core i5";
        public void SetRAM() => _computer.RAM = "16GB";
        public void SetStorage() => _computer.Storage = "512GB SSD";
        public void SetGPU() => _computer.GPU = "Integrated Graphics";
        public void SetOS() => _computer.OS = "Windows 10";

        public Computer GetComputer() => _computer;
    }

}
