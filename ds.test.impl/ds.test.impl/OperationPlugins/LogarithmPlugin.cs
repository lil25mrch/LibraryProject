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
        /// <exception cref="ArgumentException">Ошибка при введении основания меньше 0</exception>
        public override int Run(int input1, int input2) {
            if (input2 < 0 || input1 < 0 ) {
                throw new ArgumentException ("Values for logarithm cannot be negative");
            }
            return checked((int)Math.Log(input1, input2));
        }
    }
}