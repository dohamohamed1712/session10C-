using System;
using System.Collections.Generic;
using System.Text;

namespace session10C_
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public double Length()
        {
            
            return Convert.ToDouble(Max) - Convert.ToDouble(Min);
        }
    }
}
