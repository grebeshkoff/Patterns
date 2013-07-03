using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Controls
{
    internal interface IUIFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }
}
