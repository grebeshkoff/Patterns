using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Controls.Linux
{
    class LinuxCheckBox : ICheckBox
    {
        public void SetVisibility(bool visible)
        {
            Console.WriteLine(visible ? "Linux CheckBox is Visibil" : "Linux CheckBox isn't Visibil");
        }
    }
}
