using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Abstract_Factory
{
    public interface GUIFactory
    {
        Button CreateButton();
        Checkbox CreateCheckbox();
    }

}
