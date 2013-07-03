using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory;
using AbstractFactory.Controls.Linux;
using AbstractFactory.Controls.Windows;

namespace AbstractFactory.Controls
{
    class WindowsUIFacktory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WindowsCheckBox();
        }
    }
}
