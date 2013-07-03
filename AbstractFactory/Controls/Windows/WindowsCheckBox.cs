using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Controls.Windows
{
    class WindowsCheckBox :ICheckBox
    {
        public void SetVisibility(bool visible)
        {
            Console.WriteLine(visible ? "Windows CheckBox is Visibil" : "Windows CheckBox isn't Visibil");
        }
    }
}
