using System.Drawing;

namespace ds.test.impl {
    /// <summary>
    /// Базовый класс плагина
    /// </summary>
    internal abstract class PluginBase : IPlugin {
        /// <summary>
        /// Название плагина
        /// </summary>
        public string PluginName => GetType().Name;
        /// <summary>
        /// Версия плагина
        /// </summary>
        public abstract string Version { get; }
        /// <summary>
        /// Изображение плагина
        /// </summary>
        public abstract Image Image { get; }
        /// <summary>
        /// Описание плагина
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Выполнить математическую операцию
        /// </summary>
        /// <param name="input1">Первое число</param>
        /// <param name="input2">Второе чисто</param>
        /// <returns>Результат математической операции</returns>
        public abstract int Run(int input1, int input2);
    }
}