using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Abstract_Factory
{
    public class Application
    {
        private Button _button;
        private Checkbox _checkbox;

        public Application(GUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void RenderUI()
        {
            _button.Paint();
            _checkbox.Paint();
        }
    }

}
