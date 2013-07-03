using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Controls.Linux
{
    class LinuxButton: IButton
    {
        public void SetVisibility(bool visible)
        {
            Console.WriteLine(visible ? "Linux Button is Visibil" : "Linux Button isn't Visibil");
        }
    }
}
