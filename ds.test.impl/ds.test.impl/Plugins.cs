using System;
using System.Collections.Generic;
using System.Linq;
using ds.test.impl.OperationPlugins;

namespace ds.test.impl {
    /// <summary>
    /// Класс плагинов
    /// </summary>
    public static class Plugins {
        /// <summary>
        /// Словарь для хранения названий плагинов и их интерфейсов
        /// </summary>
        private static readonly Dictionary<string, IPlugin> _pluginsByName = new Dictionary<string, IPlugin>();

        /// <summary>
        /// Добавление экземпляров плагинов в словарь
        /// </summary>
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

        /// <summary>
        /// Количество плагинов
        /// </summary>
        public static int PluginsCount => _pluginsByName.Count;

        /// <summary>
        /// Массив названий плагинов
        /// </summary>
        public static string[] GetPluginNames => _pluginsByName.Keys.ToArray();

        /// <summary>
        /// Получить плагин из словаря по названию
        /// </summary>
        /// <param name="pluginName">Название плагина</param>
        /// <returns>Плагин</returns>
        /// <exception cref="ArgumentException">Сообщение об отсутствии плагина с таким названием</exception>
        public static IPlugin GetPlugin(string pluginName) {
            if (!_pluginsByName.TryGetValue(pluginName, out IPlugin result)) {
                throw new ArgumentException($"Unknown plugin name : {pluginName}");
            }

            return result;
        }
    }
}