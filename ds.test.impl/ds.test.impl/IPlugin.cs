using System.Drawing;

namespace ds.test.impl {
    /// <summary>
    /// Интерфейс плагина
    /// </summary>
    public interface IPlugin {
        /// <summary>
        /// Название плагина
        /// </summary>
        string PluginName { get; }

        /// <summary>
        /// Версия плагина
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Изображение плагина
        /// </summary>
        Image Image { get; }

        /// <summary>
        /// Описание плагина
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Выполнение оперании
        /// </summary>
        /// <param name="input1">Первое число</param>
        /// <param name="input2">Второе число</param>
        /// <returns>Результат операции</returns>
        int Run(int input1, int input2);
    }
}