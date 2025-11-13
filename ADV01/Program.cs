using ADV01.EX01;
using ADV01.EX02V2;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Cryptography;

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

            // //---  code for V3 Equality And hash Code GetHashCode() goes here ---//
            // Employee emp1 = new Employee(10, "george", 5000m);   
            // Employee emp2 = new Employee(10, "george", 5000m);
            // Console.WriteLine(emp1.GetHashCode());
            // Console.WriteLine(emp2.GetHashCode());


            // string Message = emp1.Equals(emp2) ? "Equal" : "Not Equal";// Using Equals method to compare the content of the two objects
            //// 
            // Console.WriteLine(Message); // Output: not Equal
            #endregion



            #region Is - As - typeof()
            #region Is Operator
            // ---  code for Is Operator goes here ---//

            //Employee emp0 = new Employee(1, "George", 5000m);
            //Employee? emp01 = null;
            //Employee emp02 = new Employee(2, "Mina", 6000m);
            //Employee emp03 = new Employee(2, "Mina", 6000m);
            //// Console.WriteLine(emp01?.Equals(emp0)); // this will throw NullReferenceException because emp01 is null this is the caller can be null use null conditional operator [?.]
            //Console.WriteLine(emp02.Equals(emp03));
            #endregion

            #region As Operator Use To Safe Casting


            /* casting 
            //int x = 100;
            //string y = "123";
            // int z = (int)y; // invalid cast Exception
            //object obj1 = y; // boxing
            //x = int.Parse(y);
            //int? z = (int)obj1;

            //Console.WriteLine(x);
            //Console.WriteLine(x.GetType());
            //object obj2 = y; // boxing
            //int? z = obj2 as int?; // unboxing using as operator

            */

            #region As 
            // default value of reference type is null not thorw exceptions
            //object myObject = "Hello World"; // myObject holds a string
            //string myString = myObject as string; // Success: myString is "Hello World"
            //Console.WriteLine(myObject);
            //Console.WriteLine(myString);


            //object anotherObject = 123; // anotherObject holds an integer
            //string anotherString = anotherObject as string; // Failure: anotherString is null
            //Console.WriteLine("================");
            //Console.WriteLine(anotherObject);
            ////Console.WriteLine(anotherString.GetType()); // This line would throw a NullReferenceException

            #endregion


            /*//int.TryParse() is a method, not a cast, used specifically for converting a string to an int safely.

              int number;
              bool isPathed;
              do
              {
                  Console.Write("Enter Number : ");
                  string? input = Console.ReadLine();
                  isPathed = int.TryParse(input, out number);
                  if (!isPathed)
                  {
                      Console.WriteLine("Invalid input. Please enter a valid integer.");
                  }

              }
              while (!isPathed);
              Console.WriteLine(number);
              Console.WriteLine(number.GetType());
            */


            // Casting obj to Employee using as operator

            #region EX Search If Employee Input Is existing
            /*
                        Employee emp1 = new Employee(1, "a", 1m);
                        Employee emp2 = new Employee(2, "b", 2m);
                        Employee emp3 = new Employee(3, "c", 3m);
                        Employee emp4 = new Employee(4, "d", 4m);

                        Employee[] employees = new Employee[] { emp1, emp2, emp3, emp4 };


                        bool isExisting = true;

                        bool breakLoop = false;

                        Console.WriteLine("Enter Employee To Search : ");
                        Console.Write("Enter Id : ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name : ");
                        string? name = Console.ReadLine();
                        Console.Write("Enter Salary: ");
                        decimal salary = decimal.Parse(Console.ReadLine());
                        Employee InputEmp = new Employee
                        (
                             _id: id,
                            _name: name,
                             _salary: salary
                        );
                        do
                        {
                            for (int i = 0; i < employees.Length; i++)
                            {
                                bool x = InputEmp.Equals(employees[i]);

                                if (x)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Employee Is Existing in the database!");
                                    Console.ResetColor();

                                }

                                if (!x)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Employee Is not Existing in the database!");
                                    Console.ResetColor();
                                }
                                break;


                            }
                        } while (isExisting is false);


                        Console.WriteLine("done");
            */

            #endregion


            //Employee emp01 = new Employee(1, "George", 5000m);
            //Employee Test  = null;
            //Console.WriteLine(emp01.Equals(Test)); // no exception thrown just return false


            #endregion




            #endregion




            #region IEquatable<T>

            #endregion


        }
    }
}

