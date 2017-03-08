using System;
using System.Collections.Generic;

namespace Genesyslab.Desktop.Modules.TipificationExtension.ComboTipification
{
    public interface IComboTipificationViewModel
    {
        List<String> Products { get; set; }
        List<String> Tipifications { get; set; }
    }
}
