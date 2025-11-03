using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01.EX02V2
{
    internal static class Search <T> where T : class
    {
        public static int SearchValue(int[]? _arr, int _num)
        {
            if (_arr != null && _arr.Length > 0)
            {
                for (int i = 0; i < _arr.Length; i++)
                {
                    if (_arr[i] == _num)
                    {
                        return i;
                    }
                    
                }
            }

            return -1;
        }

    }
}
