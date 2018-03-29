using System;

namespace Structural.Creatinonal.Singleton
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Singleton Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Object are the same instance");
            }

            Console.ReadKey();

        }

        /// <summary>
        /// The 'Singleton' class
        /// </summary>
        class Singleton
        {
            private static Singleton _instance;

            // Constructor is 'protected'
            protected Singleton()
            {

            }

            public static Singleton Instance()
            {
                // Uses lazy initialization.
                // Note: this is not thread safe.
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }
}
