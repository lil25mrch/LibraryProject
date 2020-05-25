using System.Drawing;

namespace ds.test.impl.OperationPlugins {
    /// <summary>
    /// Плагин умножение
    /// </summary>
    internal class MultiplyPlugin : PluginBase {
        public override string Version => "1.0.0";
        public override Image Image => Image.FromFile("PluginsImage\\multiply.jpg");
        public override string Description => "Plugin for multiply numbers";

        /// <summary>
        /// Умножение двух чисел
        /// </summary>
        /// <param name="input1">Первое число</param>
        /// <param name="input2">Второе число</param>
        /// <returns>Результат умножения</returns>
        /// <exception cref="System.OverflowException">Ошибка переполнения в результате операции умножения</exception>
        public override int Run(int input1, int input2) {
            return checked(input1 * input2);
        }
    }
}