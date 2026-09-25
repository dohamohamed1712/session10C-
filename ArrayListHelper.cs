using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace session10C_
{
    internal static class ArrayListHelper
    {
        public static void ReverseInPlace(ArrayList list)
        {
            if (list is null)
                return;

            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
    }
}
