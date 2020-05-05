using System;
using System.Collections.Generic;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Chapter1sub.Product karinto = new Chapter1sub.Product(123, "かりんとう", 180);
            Console.WriteLine(karinto.GetPriceIncludingTax());
        }
    }
}
