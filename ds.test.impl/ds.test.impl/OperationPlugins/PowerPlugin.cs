using System;
using System.Drawing;

namespace ds.test.impl.OperationPlugins {
    /// <summary>
    /// Плагин возведение в степень
    /// </summary>
    internal class PowerPlugin : PluginBase {
        public override string Version => "1.0.0";
        public override Image Image => null;
        public override string Description => "Plugin for raising a number to a power of a number";

        /// <summary>
        /// Возведение в степень
        /// </summary>
        /// <param name="input1">Основание</param>
        /// <param name="input2">Степень</param>
        /// <returns>Результат возведения числа в степень</returns>
        /// <exception cref="System.OverflowException">Ошибка переполнения в результате операции возведения в степень</exception>
        public override int Run(int input1, int input2) {
            return checked((int)Math.Pow(input1, input2));
        }
    }
}