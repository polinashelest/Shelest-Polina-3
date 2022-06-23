//Дано текстовий файл.
//Створіть список, кожен елемент якого
//містить кількість символів у відповідному рядку тексту.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)

        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\Admin\\Documents\\1курс\\2сем\\ОП\\Lab3\\Lab3\\TextFile.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            string[] file = File.ReadAllLines("C:\\Users\\Admin\\Documents\\1курс\\2сем\\ОП\\Lab3\\Lab3\\TextFile.txt");


            List<int> symbolCount = new List<int>();


            foreach (string s in file)
                symbolCount.Add(s.Trim().ToCharArray().Length);


            for (int i = 0; i < symbolCount.Count; i++)
                Console.WriteLine($"\nРядок { i + 1 } мiстить { symbolCount[i] } символiв");
            Console.ReadKey();
        }
    }
}
