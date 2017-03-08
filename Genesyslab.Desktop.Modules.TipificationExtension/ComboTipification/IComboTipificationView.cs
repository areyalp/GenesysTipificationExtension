using Genesyslab.Desktop.Infrastructure;

namespace Genesyslab.Desktop.Modules.TipificationExtension.ComboTipification
{
    public interface IComboTipificationView : IView
    {
        IComboTipificationViewModel Model { get; set; }
    }
}
