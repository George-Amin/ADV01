using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01.EX01
{
    // no need to instantiate this class ( Utility class )
    internal static class Helper <T> // GENERIC CLASS in Class Level
    {
        // GENERIC METHOD
        public static void Swip/*<T>*/(ref T _x, ref T _y) // <T> is a placeholder for any data type in Method Level
        {
            T Temp = _x;
            _x = _y;
            _y = Temp;

        }
        public static void Print(T _writeAnyThing) // no need to write <T> after Print because the class is already generic
        {
            Console.WriteLine(_writeAnyThing);
        }
    }
}
