using System;

namespace StringUtility
{
    public class StringUtility
    {
        public int CountOccurrences(string input, char character)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int count = 0;
            foreach (var ch in input)
            {
                if (ch == character)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
