using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            Console.WriteLine("---3.1.1---");
            if (numbers.Exists(x => x % 8 == 0 || x % 9 == 0)) Console.WriteLine("true"); else Console.WriteLine("false");

            Console.WriteLine("---3.1.2---");
            numbers.ForEach(x => Console.WriteLine(x / 2.0));

            Console.WriteLine("---3.1.3---");
            numbers.Where(x => x >= 50).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("---3.1.4---");
            var list = numbers.Select(x => x * 2).ToList();
            list.ForEach(Console.WriteLine);

            var names = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            Console.WriteLine("---3.2.1---");
            Console.Write("入力した都市のインデックスを調べる:");
            var city = Console.ReadLine();
            Console.WriteLine(names.FindIndex(s => s == city));

            Console.WriteLine("---3.2.2---");
            Console.WriteLine(names.Count(s => s.Contains("o")));

            Console.WriteLine("---3.2.3---");
            names.Where(s => s.Contains("o")).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("---3.2.4---");
            names.Where(s => s.StartsWith("B")).Select(s => s.Length).ToList().ForEach(Console.WriteLine);
        }
    }
}
