using System;
using System.Drawing;

namespace ds.test.impl.OperationPlugins {
    /// <summary>
    /// Плагин логарифм
    /// </summary>
    internal class LogarithmPlugin : PluginBase {
        public override string Version => "1.0.0";
        public override Image Image => null;
        public override string Description => "Plugin for logarithm numbers. Rounding down.";

        /// <summary>
        /// Логарифмирование по основанию
        /// </summary>
        /// <param name="input1">Логарифм числа</param>
        /// <param name="input2">Основание</param>
        /// <returns>Результат логарифмирования</returns>
        public override int Run(int input1, int input2) {
            return checked((int)Math.Log(input1, input2));
        }
    }
}