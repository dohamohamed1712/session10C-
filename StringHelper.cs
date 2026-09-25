using System;
using System.Collections.Generic;
using System.Text;

namespace session10C_
{
    internal static class StringHelper
    {
        public static int FirstNonRepeatedCharIndex(string text)
        {
            if (string.IsNullOrEmpty(text))
                return -1;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            
            foreach (char c in text)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            
            for (int i = 0; i < text.Length; i++)
            {
                if (charCount[text[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}
