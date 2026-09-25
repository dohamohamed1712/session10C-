using System;
using System.Collections.Generic;
using System.Text;

namespace session10C_
{
    internal class BubbleSortHelper
    {
        public static void OptimizedBubbleSort(int[] arr)
        {
            if (arr is null)
                return;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no elements were swapped in this pass, the array is already sorted
                if (!swapped)
                    break;
            }
        }
    }
}
