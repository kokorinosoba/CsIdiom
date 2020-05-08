using System;
using System.Linq;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[] { "-tom" };

            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(1, 10);
            }
            else
            {
                PrintMeterToFeetList(1, 10);
            }

        }

        static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }

        static double MeterToFeet(int meter)
        {
            return meter / 0.3048;
        }

        static void PrintFeetToMeterList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                Console.WriteLine("{0,2} ft = {1:0.0000} m", feet, FeetConverter.ToMeter(feet));
            }
        }

        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                Console.WriteLine("{0,2} m = {1: 00.0000} ft", meter, FeetConverter.FromMeter(meter));
            }
        }
    }
}
