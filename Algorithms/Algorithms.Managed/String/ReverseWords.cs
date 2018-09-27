using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.String
{
    public class ReverseWords
    {
        /// <summary>
        /// Reverse each individual word inside a string.
        /// </summary>
        public void ReverseWordsInString(char[] buffer)
        {
            int start = -1;

            for (int i = 0; i < buffer.Length; i++)
            {
                if (Char.IsLetterOrDigit(buffer[i]))
                {
                    if (start < 0)
                    {
                        start = i;
                    }
                }
                else
                {
                    if (start >= 0)
                    {
                        ReverseSubstrInBuffer(buffer, start, i - 1);
                        start = -1;
                    }
                }
            }

            if (start > 0)
            {
                // Need to reverse the last word in the string.
                ReverseSubstrInBuffer(buffer, start, buffer.Length - 1);
            }
        }

        private void ReverseSubstrInBuffer(char[] buffer, int start, int end)
        {
            while (start < end)
            {
                // We can just swap chars in place.
                char temp = buffer[start];
                buffer[start++] = buffer[end];
                buffer[end--] = temp;
            }
        }
    }
}
