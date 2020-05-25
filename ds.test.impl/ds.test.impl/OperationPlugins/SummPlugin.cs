namespace ds.test.impl.OperationPlugins {
    /// <summary>
    /// Плагин сложение
    /// </summary>
    internal class SummPlugin : PluginBase {
        public SummPlugin()
            : base("PluginsImage\\plus.jpg") { }

        public override string Version => "1.0.0";
        public override string Description => "Plugin for summing numbers.";

        /// <summary>
        /// Сложение двух чисел
        /// </summary>
        /// <param name="input1">Первое число</param>
        /// <param name="input2">Второе число</param>
        /// <returns>Результат сложения</returns>
        /// <exception cref="System.OverflowException">Ошибка в случае переполнения в результате операции сложения</exception>
        public override int Run(int input1, int input2) {
            return checked(input1 + input2);
        }
    }
}