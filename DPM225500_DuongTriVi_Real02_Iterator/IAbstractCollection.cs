using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225500_DuongTriVi_Real02_Iterator
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
