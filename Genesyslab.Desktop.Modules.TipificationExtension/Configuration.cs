using Genesyslab.Desktop.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesyslab.Desktop.Modules.TipificationExtension
{
    class Configuration
    {

        readonly IConfigManager confManager;
        readonly bool pluginState = false;

        public Configuration(IConfigManager confManager)
        {
            this.confManager = confManager;
            pluginState = (bool) this.confManager.GetValue("custom.role.module.tipification");
        }

        public bool isPluginActive()
        {
            return this.pluginState;
        }

        public List<String> getList(string listName)
        {
            string rawList = this.confManager.GetValue("custom.role.module.list." + listName) as string;
            if (String.IsNullOrEmpty(rawList))
            {
                return new List<String>();
            }
            var arrayList = rawList.Split(',');
            return arrayList.ToList<String>();
        }

    }
}
