//Дано словник.
//Видалити елемент з найбільшим ключом.
//Значення найменшого ключа замінити на видалене значення найбільшого ключа.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ukrainianCities = new Dictionary<int, string>()
            {
                {1, "Kyiv" },
                {2, "Kharkiv" },
                {3, "Odesa" },
                {4, "Dnipro" },
                {5, "Donetsk" },
                {6, "Zaporizhzhia" },
                {7, "Lviv" },
                {8, "Kryvyi Rih" },
                {9, "Mykolayiv" },
                {10, "Mariupol" }
            };

            Console.WriteLine("The most populated Ukrainian cities: ");
            PrintDictionary(ukrainianCities);

            int maxKey = ukrainianCities.Keys.Max();
            int minKey = ukrainianCities.Keys.Min();

            Console.WriteLine("\nThe most populated city key: " + maxKey);
            Console.WriteLine("The least populated city key: " + minKey);


            ukrainianCities[minKey] = ukrainianCities[maxKey];
            Console.WriteLine("The biggest key element was changed to the least key element");
            PrintDictionary(ukrainianCities);

            ukrainianCities.Remove(maxKey);

            Console.WriteLine("\nThe biggest key element " + maxKey + " is deleted");

            PrintDictionary(ukrainianCities);

            Console.ReadKey();

        }

        private static void PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            Console.WriteLine();
            dictionary
                .ToList()
                .ForEach(item => Console.WriteLine(item.Key + " - " + item.Value));
        }
    }
}
