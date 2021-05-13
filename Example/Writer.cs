using System;

namespace Example
{
    /// <summary>
    /// Класс, отвечающий за вывод на консоль
    /// </summary>
    class Writer
    {
        #region Конструктор

        /// <summary>
        /// Класс, отвечающий за вывод на консоль
        /// </summary>
        public Writer(string text)
        {
            Console.WriteLine(text);
        }

        #endregion
    }
}
