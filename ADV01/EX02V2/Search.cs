using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01.EX02V2
{
    internal static class Search<T> /* <T> where T : class */ // Generic Constraint to reference type only make sure T is a class
    {
        public static int SearchValue(T[]? _arr, T _ValueToSearch)
        {
            //if (_arr != null && _arr.Length > 0 && _ValueToSearch is not null)
            if(_arr?.Length > 0 && _ValueToSearch != null)

            {
                for (int i = 0; i < _arr.Length; i++)
                {
                    /* if (_arr[i] == _num) // this will work only if we overload the == operator in the class or use equals method
                    /{
                       return i;
                    }

                     // Either use Equals method
                    if (_arr[i]?.Equals(_ValueToSearch) ?? false)
                    {
                        Console.Write("found : ");
                        Console.WriteLine(_arr[i]);
                       return i;
                    }
                    else
                   {
                        Console.WriteLine("not found");
                        return -1;
                    }

                    // cheak for null _ValueToSearch becuse _arr[i]
                    // //can be null and we cant call equals on null
                    // /// // so cheak if _ValueToSearch is not null
                    */


                    if (_ValueToSearch.Equals(_arr[i]))
                    {
                        Console.Write("found : " + _arr[i] + "In Index :");
                        return i;
                    }
               

                }
            }

            return -1;
        }

    }
}
