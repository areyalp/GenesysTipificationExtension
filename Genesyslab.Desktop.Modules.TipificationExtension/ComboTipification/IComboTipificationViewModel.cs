using Genesyslab.Desktop.Modules.Core.Model.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesyslab.Desktop.Modules.TipificationExtension.ComboTipification
{
    public interface IComboTipificationViewModel
    {
        string Header { get; set; }
        IInteraction Interaction { get; set; }
        ICase Case { get; set; }
    }
}
