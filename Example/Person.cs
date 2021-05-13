using System;

namespace Example
{
    /// <summary>
    /// Человек
    /// </summary>
    class Person
    {
        #region Конструкторы

        public Person()
        {
            Console.WriteLine("Person constructor");
        }
        static Person()
        {
            Console.WriteLine("Person static constructor");
        }

        #endregion

        #region Методы

        public virtual void Method()
        {
            Console.WriteLine("Person virtual method");
        }

        #endregion
    }
}
