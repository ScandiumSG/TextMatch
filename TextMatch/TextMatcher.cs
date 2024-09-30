using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMatch
{
    internal class TextMatcher
    {
        private string Text;

        public TextMatcher(string text) 
        {
            Text = text;
        }

        /// <summary>
        /// Check number and position of subtext occurances in the objects Text field.
        /// </summary>
        /// <param name="text">String to locate in the Text field</param>
        /// <returns>List of int of string position, empty list returned if none found.</returns>
        public List<int> Match(string subtext) 
        {
            List<int> foundIndexes = new List<int>();

            char[] textAsChars = Text.ToLower().ToCharArray();
            char[] subtextAsChars = subtext.ToLower().ToCharArray();

            for (int i = 0; i < textAsChars.Length; i++)
            {
                int j = 0;
                while (textAsChars[i + j] == subtextAsChars[j]) 
                {
                    // Out-of-bound for text
                    if (i + j >= textAsChars.Length) 
                    {
                        break;
                    }

                    if ((subtextAsChars.Length == j + 1) && (textAsChars[i + j] == subtextAsChars[j])) 
                    {
                        // Add to return list and convert from 0-indexed to 1-indexed for human-readable-format
                        foundIndexes.Add(i+1);
                        break;
                    }
                    j++;
                }
            }

            return foundIndexes;
        }
    }
}
