using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    static class Helper<T>   where T : IComparable
    {
        public static void bubbleSort(T[] array)
        {
            for(int i = 0 ; i < array.Length ; i++)
            {
                for(int j = 0; j < array.Length-i-1 ; j++)
                {
                    if (array[j].CompareTo(array[j+1]) == 1)
                    {
                        T temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

    }
}
