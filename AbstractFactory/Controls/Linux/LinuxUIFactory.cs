using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Controls.Linux;

namespace AbstractFactory.Controls
{
    class LinuxUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new LinuxCheckBox();
        }
    }
}
