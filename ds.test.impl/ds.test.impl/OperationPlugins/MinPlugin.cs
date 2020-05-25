using System;

namespace ds.test.impl.OperationPlugins {
    /// <summary>
    /// Плагин определения меньшего числа
    /// </summary>
    internal class MinPlugin : PluginBase {
        public MinPlugin()
            : base("PluginsImage\\min.png") { }

        public override string Version => "1.0.0";
        public override string Description => "Plugin for determining a smaller number.";

        /// <summary>
        /// Определить меньшее число
        /// </summary>
        /// <param name="input1">Первое число</param>
        /// <param name="input2">Второе число</param>
        /// <returns>Меньшее число</returns>
        public override int Run(int input1, int input2) {
            return Math.Min(input1, input2);
        }
    }
}