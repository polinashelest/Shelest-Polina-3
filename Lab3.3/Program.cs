//Дана послідовність цілих чисел.
//з неї всі додатні двозначні числа,
//відсортувавши їх по зростанню

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Enumerable
                .Range(0, 200)
                .OrderByDescending(x => x)
                .ToArray();
            Console.WriteLine("Input sequence: \n");
            PrintSequence(sequence);
            

            var result = sequence
                .Where(x => x >= 10 && x < 100)
                .OrderBy(x => x)
                .ToArray();
            Console.WriteLine("Result sequence: \n");
            PrintSequence(result);

            Console.ReadLine();
        }

        private static void PrintSequence(int[] sequence)
        {
            Console.WriteLine(string.Join(", ", sequence));
            Console.WriteLine();
        }
    }
}
