using session10C_;
using System;
using System.Collections;
using System.Collections.Generic;

namespace session10C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Optimized Bubble Sort
            Console.WriteLine("===== Q1 - Optimized Bubble Sort =====");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 9, 8 };
            BubbleSortHelper.OptimizedBubbleSort(arr);

            foreach (int num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
            #endregion

            Console.WriteLine();

            #region Q2 - Range<T>
            Console.WriteLine("===== Q2 - Range<T> =====");
            Range<int> intRange = new Range<int>(1, 10);
            Console.WriteLine("Is 5 in range? " + intRange.IsInRange(5));
            Console.WriteLine("Is 15 in range? " + intRange.IsInRange(15));
            Console.WriteLine("Length = " + intRange.Length());

            Range<double> doubleRange = new Range<double>(2.5, 7.5);
            Console.WriteLine("Is 5.0 in range? " + doubleRange.IsInRange(5.0));
            Console.WriteLine("Length = " + doubleRange.Length());
            #endregion

            Console.WriteLine();

            #region Q3 - Reverse ArrayList In-Place
            Console.WriteLine("===== Q3 - Reverse ArrayList =====");
            ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5 };

            Console.WriteLine("Before:");
            foreach (var item in numbers)
                Console.Write(item + " ");

            ArrayListHelper.ReverseInPlace(numbers);

            Console.WriteLine("\nAfter:");
            foreach (var item in numbers)
                Console.Write(item + " ");
            Console.WriteLine();
            #endregion

            Console.WriteLine();

            #region Q4 - Get Even Numbers
            Console.WriteLine("===== Q4 - Get Even Numbers =====");
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evens = ListHelper.GetEvenNumbers(nums);

            Console.WriteLine("Even numbers:");
            foreach (int num in evens)
                Console.Write(num + " ");
            Console.WriteLine();
            #endregion

            Console.WriteLine();

            #region Q5 - FixedSizeList<T>
            Console.WriteLine("===== Q5 - FixedSizeList<T> =====");
            FixedSizeList<int> fixedList = new FixedSizeList<int>(3);

            fixedList.Add(10);
            fixedList.Add(20);
            fixedList.Add(30);

            Console.WriteLine("Element at index 1: " + fixedList.Get(1));

            try
            {
                fixedList.Add(40);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                Console.WriteLine(fixedList.Get(10));
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            #endregion

            Console.WriteLine();

            #region Q6 - First Non-Repeated Character
            Console.WriteLine("===== Q6 - First Non-Repeated Character =====");
            Console.WriteLine(StringHelper.FirstNonRepeatedCharIndex("swiss"));
            Console.WriteLine(StringHelper.FirstNonRepeatedCharIndex("aabbcc"));
            Console.WriteLine(StringHelper.FirstNonRepeatedCharIndex("programming"));
            #endregion
        }
    }
}