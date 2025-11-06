using ADV01.EX01;
using ADV01.EX02V2;
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

            #region Searching value

            //int[] arr = null;
            //int num = 300;
            //Console.WriteLine(Search.SearchValue(arr, num));

            //TwoPoints[] points =
            //{
            //    new TwoPoints (1,2),
            //    new TwoPoints (10,20),
            //    new TwoPoints (100,200),
            //};
            //TwoPoints val = new TwoPoints(10, 20);
            //int index = Search.SearchValue(points, val);


            //Employee emp1 = new Employee(1, null, 5000m);
            //Employee emp2 = new Employee(2, "George", 5111m);
            //Employee emp3 = new Employee(1, "Mina", 5000m);
            //Employee emp3 = new Employee(3, "Youssef", 5111m);
            //emp3 = emp1; // now both emp1 and emp3 refer to the same object in memory
            //int x = emp1.GetHashCode();
            //int v = emp3.GetHashCode();
            ////int v = emp3.GetHashCode();

            //Console.WriteLine(x);
            //Console.WriteLine(v);
            //if (emp1 == emp3) // by default it compare the reference not the content with  classes 
            //// if you want to compare the content you have to overload the == operator in struct
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //Employee[] arrOfEmp = new Employee[]
            //{
            //    new Employee(1, "Mina", 5000m),
            //    new Employee(2, "George", 6000m),
            //    new Employee(3, "Youssef", 7000m),
            //    new Employee(4, "Amin", 8000m),
            //    new Employee(5, "Shokry", 9000m),
            //    new Employee(6, "jo", 5400m),
            //    new Employee(7, "do", 6600m),

            //};
            //Employee employee = new(4, "Amin", 8000m);
            ////Search<Employee>.SearchValue(new Employee[] { emp2, emp3 }, emp2);
            //int i = Search<Employee>.SearchValue(arrOfEmp, employee);
            //Console.WriteLine(i);
            #endregion



            #region V3 Equality And hash Code GetHashCode()

            //---  code for V3 Equality And hash Code GetHashCode() goes here ---//
            Employee emp1 = new Employee(10, "george", 5000m);   
            Employee emp2 = new Employee(10, "george", 5000m);
            Console.WriteLine(emp1.GetHashCode());
            Console.WriteLine(emp2.GetHashCode());


            string Message = emp1.Equals(emp2) ? "Equal" : "Not Equal";// Using Equals method to compare the content of the two objects
           // 
            Console.WriteLine(Message); // Output: not Equal
            #endregion


        }
    }
}
