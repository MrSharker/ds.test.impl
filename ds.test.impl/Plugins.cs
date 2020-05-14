using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    public static class Plugins
    {
        static List<IPlugin> pluginsList = new List<IPlugin>() { new Sum(), new Sub(), new Multiply(), new Division(), new Degree()};
        public static int PluginsCount { get { return pluginsList.Count; } }
        public static string[] GetPluginNames 
        { 
            get
            {
                if (PluginsCount != 0)
                {
                    List<string> namePlug = new List<string>();
                    foreach (var plug in pluginsList)
                    {
                        namePlug.Add(plug.PluginName);
                    }
                    return namePlug.ToArray();
                }
                else return null;
            }
        }
        public static IPlugin GetPlugin(string pluginName) 
        {
            foreach (var plug in pluginsList)
            {
                if (plug.PluginName == pluginName) return plug;
            }
            return null;
        }
    }
}
