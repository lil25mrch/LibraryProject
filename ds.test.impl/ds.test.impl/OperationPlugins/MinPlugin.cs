using System;
using System.Drawing;

namespace ds.test.impl.OperationPlugins {
    /// <summary>
    /// Плагин определения меньшего числа
    /// </summary>
    internal class MinPlugin : PluginBase {
        public override string Version => "1.0.0";
        public override Image Image => null;
        public override string Description => "Plugin for summing numbers.";

        /// <summary>
        /// Определить меньшее число
        /// </summary>
        /// <param name="input1">Первое число</param>
        /// <param name="input2">Второе число</param>
        /// <returns>Меньшее число</returns>
        public override int Run(int input1, int input2) {
            return checked(Math.Min(input1, input2));
        }
    }
}

