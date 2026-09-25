using System;
using System.Collections.Generic;
using System.Text;

namespace session10C_
{
    internal static class ListHelper
    {
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            if (numbers is null)
                return evenNumbers;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    evenNumbers.Add(num);
            }

            return evenNumbers;
        }
    }
}
