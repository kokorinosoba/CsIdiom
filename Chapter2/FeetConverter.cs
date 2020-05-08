using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Chapter2
{
    static class FeetConverter
    {
        private const double ratio = 0.3048;
        public static double FromMeter(double meter)
        {
            return meter / ratio;
        }

        public static double ToMeter(double feet)
        {
            return feet * ratio;
        }
    }
}
