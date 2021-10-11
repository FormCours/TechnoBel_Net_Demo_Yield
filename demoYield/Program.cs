using System;
using System.Collections.Generic;

namespace demoYield
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> d1 = Demo1();

            foreach(string e in d1)
            {
                Console.WriteLine(e);
            }

            IEnumerable<int> d2 = Generateur();

            foreach (int e in d2)
            {
                Console.WriteLine(e);
            }
        }

        private static IEnumerable<string> Demo1()
        {
            List<string> textes = new List<string>()
            {
                "Riri", "Fifi", "Zaza", "Della", "Gontran"
            };

            foreach(string element in textes) {
                yield return element.ToUpper();
            }
        }

        private static IEnumerable<int> Generateur()
        {
            yield return 42;
            yield return 13;
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
            yield return 42;
        }
    }
}
