using System;
using System.Collections.Generic;
using System.Linq;
using ds.test.impl.OperationPlugins;

namespace ds.test.impl {
    /// <summary>
    /// Класс с плагинами
    /// </summary>
    public static class Plugins {
        private static readonly Dictionary<string, IPlugin> _pluginsByName = new Dictionary<string, IPlugin>();

        static Plugins() {
            var plugins = new List<IPlugin> {
                new DivisionPlugin(),
                new MinusPlugin(),
                new MultiplyPlugin(),
                new SummPlagin(),
                new PowerPlugin(),
                new RemainderDivision(),
                new LogarithmPlugin(),
                new MinPlugin(),
                new MaxPlugin()
            };

            foreach (IPlugin plugin in plugins) {
                _pluginsByName.Add(plugin.PluginName, plugin);
            }
        }

        public static int PluginsCount => _pluginsByName.Count;
        public static string[] GetPluginNames => _pluginsByName.Keys.ToArray();

        public static IPlugin GetPlugin(string pluginName) {
            if (!_pluginsByName.TryGetValue(pluginName, out IPlugin result)) {
                throw new ArgumentException($"Unknown plugin name : {pluginName}");
            }

            return result;
        }
    }
}