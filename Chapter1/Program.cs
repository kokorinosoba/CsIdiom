using System;
using System.Collections.Generic;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass  myClass  = new MyClass  { X = 1,  Y = 2  };
            MyStruct myStruct = new MyStruct { X = 10, Y = 20 };
            PrintObjects(myClass, myStruct);
            PrintObjects(myClass, myStruct);
        }

        static void PrintObjects(MyClass myClass, MyStruct myStruct)
        {
            myClass.X *= 2;
            myClass.Y *= 2;
            myStruct.X *= 2;
            myStruct.Y *= 2;

            Console.WriteLine("MyClass X:" + myClass.X + "\tMyClass Y:" + myClass.Y);
            Console.WriteLine("MyStruct X:" + myStruct.X + "\tMyStruct Y:" + myStruct.Y);
        }
    }
}
