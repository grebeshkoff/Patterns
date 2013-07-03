using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Controls.Windows
{
    class WindowsButton : IButton
    {
        public void SetVisibility(bool visible)
        {
            Console.WriteLine(visible ? "Windows Button is Visibil" : "Windows Button isn't Visibil");
        }
    }
}
