using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Abstract_Factory
{
    public class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }

}
