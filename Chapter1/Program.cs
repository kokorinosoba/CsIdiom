using System;
using System.Collections.Generic;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> objects = new List<object>();
            objects.Add(new Employee { Name = "労働者" });
            objects.Add(new Person { Name = "人" });
            objects.Add(new Product(123, "かりんとう", 180));
            foreach (var obj in objects)
            {
                Console.WriteLine(obj.Name);
            }
        }
    }
}
