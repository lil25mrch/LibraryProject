namespace ds.test.impl.OperationPlugins {
    /// <summary>
    /// Плагин вычитание
    /// </summary>
    internal class MinusPlugin : PluginBase {
        public MinusPlugin()
            : base("PluginsImage\\minus.jpg") { }

        public override string Version => "1.0.0";
        public override string Description => "Plugin for minus numbers";

        /// <summary>
        /// Вычитание двух чисел
        /// </summary>
        /// <param name="input1">Первое число</param>
        /// <param name="input2">Второе число</param>
        /// <returns>Результат вычитания</returns>
        /// <exception cref="System.OverflowException">Ошибка в случае переполнения в результате операции вычитания</exception>
        public override int Run(int input1, int input2) {
            return checked(input1 - input2);
        }
    }
}