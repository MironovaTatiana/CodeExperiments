using System;


namespace Example
{
    /// <summary>
    /// Студент
    /// </summary>
    class Student : Person
    {
        #region Поля

        private readonly Writer field = new("Student field");

        private static readonly Writer staticField = new("Student static field");

        #endregion 

        #region Свойства
        public Writer Property => new("Student property");

        #endregion

        #region Конструкторы

        public Student()
        {
            Console.WriteLine("Student constructor");
        }
        static Student()
        {
            Console.WriteLine("Student static constructor");
        }

        #endregion

        #region Методы

        public override void Method()
        {
            Console.WriteLine("Student override method");
        }

        #endregion
    }
}
