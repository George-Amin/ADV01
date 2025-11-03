using ADV01.EX01;
using System.ComponentModel.Design;

namespace ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EX01 Swip Generic Method
            // int a = 10;
            //int b = 20;
            //Helper.Swip(ref a, ref b);
            //Console.WriteLine( a);
            //Console.WriteLine( b);
            //decimal a = 10.10m;
            //decimal b = 20.20m;
            //Helper.Swip<decimal>(ref a, ref b); // can not use ref with decimal type because Helper.Swip only accept int type
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Point p01 = new Point();
            //p01.NameOne = "George";
            //p01.NameTwo = "Amin";
            //Console.WriteLine($"p01 NameOne{p01.NameOne}");//
            //Console.WriteLine($"p01 Nametwo{p01.NameTwo}");

            //Console.WriteLine("-----------------------------");
            //Point p02 = new Point();
            //p02.NameOne = "Youssef";
            //p02.NameTwo = "Shokry";
            //Console.WriteLine($"p02 NameOne{p02.NameOne}");
            //Console.WriteLine($"p02 Nametwo{p02.NameTwo}");
            //Console.WriteLine(p01.GetHashCode() + "hashCode");
            //Console.WriteLine(p02.GetHashCode() + "hashCode");
            //Helper.Swip<Point>(ref p01, ref p02);
            //Console.WriteLine($"p01 NameOne{p01.NameOne}");
            //Console.WriteLine($"p01 Nametwo{p01.NameTwo}");

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine($"p02 NameOne{p02.NameOne}");
            //Console.WriteLine($"p02 Nametwo{p02.NameTwo}");
            //Console.WriteLine(p01.GetHashCode());
            //Console.WriteLine(p02.GetHashCode());
            //Point p01 = new Point();
            //Point p02 = new Point();
            //Console.WriteLine(p01.GetHashCode());
            //Console.WriteLine(p02.GetHashCode());
            //Helper<string>.Print("Hello Generic Method"); // write the data type in the class level
            //Helper<int>.Print(55); // write the data type in the class level

            #region Using the generic type 'Helper<T>' requires 1 type arguments
            //decimal str1 = 10.10m;
            //Console.WriteLine(str1.GetHashCode());
            //int num = 100;
            //Console.WriteLine(num.GetHashCode());

            //Helper<decimal, int>.Swip(ref str1, ref num);

            //Console.WriteLine(str1.GetHashCode());
            //Console.WriteLine(num.GetHashCode()); 
            //decimal str1 = 10.10m;
            //Console.WriteLine(str1.GetHashCode());
            //int num = 100;
            //Console.WriteLine(num.GetHashCode());

            //Helper<decimal, int>.Swip(ref str1, ref num);

            //Console.WriteLine(str1.GetHashCode());
            //Console.WriteLine(num.GetHashCode());
            #endregion

            #endregion

        }
    }
}
