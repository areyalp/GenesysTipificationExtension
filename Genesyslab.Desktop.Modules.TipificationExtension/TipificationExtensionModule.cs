﻿using Genesyslab.Desktop.Infrastructure;
using Genesyslab.Desktop.Infrastructure.Configuration;
using Genesyslab.Desktop.Infrastructure.DependencyInjection;
using Genesyslab.Desktop.Infrastructure.ViewManager;
using Genesyslab.Desktop.Modules.Core.Model.Interactions;
using Genesyslab.Desktop.Modules.Windows.Event;
using Genesyslab.Platform.Commons.Logging;
using System.Windows.Forms;
using Genesyslab.Desktop.Modules.TipificationExtension.ComboTipification;

namespace Genesyslab.Desktop.Modules.TipificationExtension
{
    public class TipificationExtensionModule : IModule
    {

        readonly IInteractionManager interactionManager;
        readonly IConfigManager confManager;
        readonly IObjectContainer container;
        readonly IViewManager viewManager;
        readonly IViewEventManager viewEventManager;
        ILogger log;
        

        public TipificationExtensionModule(IInteractionManager interactionManager, IConfigManager confManager, IObjectContainer container, IViewManager viewManager, IViewEventManager viewEventManager, ILogger log)
        {
            this.interactionManager = interactionManager;
            this.confManager = confManager;
            this.container = container;
            this.viewManager = viewManager;
            this.viewEventManager = viewEventManager;
            this.log = log.CreateChildLogger("Extensions");
        }

        public void Initialize()
        {
            var configuration = container.Resolve<Configuration>();

            if (configuration.isPluginActive())
            {
                MessageBox.Show("Plugin activo");
                container.RegisterType<IComboTipificationViewModel, ComboTipificationModel>();
                container.RegisterType<IComboTipificationView, ComboTipificationView>();

                viewManager.ViewsByRegionName["InteractionDetailsRegion"].Insert(0, new ViewActivator() { ViewType = typeof(IComboTipificationView), ViewName = "ComboTipification", ActivateView = true });
            } else
            {
                MessageBox.Show("Plugin Inactivo");
            }
        }
    }
}
