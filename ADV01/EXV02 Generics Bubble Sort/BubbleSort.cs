using ADV01.EX01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ADV01.EXV02_Generics_Bubble_Sort
{
    internal class BubbleSort<T> where T : IComparable<T>
    {
        public static void Bubble(T[] arr)
        {
            if (arr is null) return;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    // if (arr[j] > arr[j+1]) // can not use operator > or < with Operator '>' cannot be applied to operands of type 'T' and 'T'
                    if (arr[j].CompareTo(arr[j + 1]) > 0) // do not have CompareTo() Method . => should Imblement InterFcae IComparable<>
                    {
                        Helper<T>.Swip(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        public static void Bubble(T[] arr , IComparer<T> comparer)
        {
            if (arr is null) return;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    // if (arr[j] > arr[j+1]) // can not use operator > or < with Operator '>' cannot be applied to operands of type 'T' and 'T'
                    if (comparer.Compare(arr[j] , arr[j+1]) > 0)
                    {
                        Helper<T>.Swip(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }
}
