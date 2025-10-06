using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Abstract_Factory
{
    public class WindowsFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WindowsButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }

}
