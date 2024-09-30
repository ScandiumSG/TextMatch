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



            return foundIndexes;
        }
    }
}
