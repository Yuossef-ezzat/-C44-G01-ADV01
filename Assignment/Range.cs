using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range<T> where T : IComparable
    {
        public T maxValue { get; set; }
        public T minValue { get; set; }
        public  Range (T _minValue ,T _maxValue)
        {
            maxValue = _maxValue;
            minValue = _minValue;
        }
        public bool IsInRange (T value)
        {
            if(value.CompareTo(maxValue) < 1 )
                if(value.CompareTo(minValue) >-1)
                    return true;
                else
                    return false;
            else 
                return false;
        }
        public T Length()
        {
            dynamic max = maxValue;
            dynamic min = minValue;
            return max - min;
        }
    }
}
