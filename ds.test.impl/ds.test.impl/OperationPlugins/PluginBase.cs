using System.Drawing;
using System.IO;

namespace ds.test.impl {
    /// <summary>
    /// Базовый класс плагина
    /// </summary>
    internal abstract class PluginBase : IPlugin {
        private Image _image;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="filePath">Путь к файлу с изображением</param>
        public PluginBase(string filePath) {
            if (File.Exists(filePath)) {
                _image = Image.FromFile(filePath);
            }
        }

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
        public Image Image => _image;

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