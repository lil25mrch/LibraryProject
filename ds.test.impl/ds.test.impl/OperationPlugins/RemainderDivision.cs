using System;
using System.Drawing;

namespace ds.test.impl.OperationPlugins {
    /// <summary>
    /// Плагин остаток от деления
    /// </summary>
    internal class RemainderDivision : PluginBase {
        public override string Version => "1.0.0";
        public override Image Image => Image.FromFile("PluginsImage\\remainder.jpg");
        public override string Description => "Plugin for dividing two numbers with the remainder";

        /// <summary>
        /// Остаток от деления двух чисел
        /// </summary>
        /// <param name="input1">Числитель</param>
        /// <param name="input2">Знаменатель</param>
        /// <returns>Остаток от деления</returns>
        /// <exception cref="ArgumentException">Ошибка при введении знаменателя равного нулю</exception>
        public override int Run(int input1, int input2) {
            if (input2 == 0) {
                throw new ArgumentException("Denominator can't be 0");
            }

            return Math.DivRem(input1, input2, out int _);
        }
    }
}