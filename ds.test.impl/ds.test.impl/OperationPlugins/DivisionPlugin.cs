using System;

namespace ds.test.impl.OperationPlugins {
    /// <summary>
    /// Плагин деление
    /// </summary>
    internal class DivisionPlugin : PluginBase {
        public DivisionPlugin()
            : base("PluginsImage\\dividing.jpg") { }

        public override string Version => "1.0.0";
        public override string Description => "Plugin for division numbers. Rounding down.";

        /// <summary>
        /// Деление двух чисел
        /// </summary>
        /// <param name="input1">Числитель</param>
        /// <param name="input2">Знаменатель</param>
        /// <returns>Результат деления</returns>
        /// <exception cref="ArgumentException">Ошибка при введении знаменателя равного нулю</exception>
        public override int Run(int input1, int input2) {
            if (input2 == 0) {
                throw new ArgumentException("Denominator can't be 0");
            }

            return input1 / input2;
        }
    }
}