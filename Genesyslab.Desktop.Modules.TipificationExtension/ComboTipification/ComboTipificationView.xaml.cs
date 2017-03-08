using Genesyslab.Desktop.Infrastructure.Configuration;
using Genesyslab.Desktop.Infrastructure.DependencyInjection;
using System.Windows.Controls;

namespace Genesyslab.Desktop.Modules.TipificationExtension.ComboTipification
{
    /// <summary>
    /// Interaction logic for ComboTipification.xaml
    /// </summary>
    public partial class ComboTipificationView : UserControl, IComboTipificationView
    {

        readonly IConfigManager confManager;
        readonly IObjectContainer container;

        public ComboTipificationView(IComboTipificationViewModel viewModel, IConfigManager confManager, IObjectContainer container)
        {
            this.confManager = confManager;
            this.container = container;
            InitializeComponent();
        }

        public IComboTipificationViewModel Model
        {
            get { return this.DataContext as IComboTipificationViewModel; }
            set { this.DataContext = value; }
        }

        public object Context { get; set; }

        public bool LoadList()
        {
            var Configuration = container.Resolve<Configuration>();
            this.Model.Products = Configuration.getList("products");
            this.Model.Tipifications = Configuration.getList("tipifications");
            return (this.Model.Products != null && this.Model.Tipifications != null);
        }

        public void Create()
        {
            if (!LoadList())
            {
                return;
            }
        }

        public void Destroy()
        {
        }
    }
}
