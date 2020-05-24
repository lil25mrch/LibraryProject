using System;
using System.Drawing;

namespace ds.test.impl.OperationPlugins {
    /// <summary>
    /// Плагин определения большего числа
    /// </summary>
    internal class MaxPlugin : PluginBase {
        public override string Version => "1.0.0";
        public override Image Image => null;
        public override string Description => "Plugin defining a larger number.";

        /// <summary>
        /// Определить большее число из двух
        /// </summary>
        /// <param name="input1">Первое число</param>
        /// <param name="input2">Второе число</param>
        /// <returns>Большее из двух число</returns>
        /// <exception cref="System.OverflowException">Ошибка в случае переполнения в результате операции определения большего числа</exception>
        public override int Run(int input1, int input2) {
            return checked(Math.Max(input1, input2));
        }
    }
}