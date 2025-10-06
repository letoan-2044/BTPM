using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225500_DuongTriVi_Real10_Command
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
