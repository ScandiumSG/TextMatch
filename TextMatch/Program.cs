namespace TextMatch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length > 2 || args.Length < 2)
            {
                Console.WriteLine("Invalid number of input parameters");
                return;
            }

            string text = args[0];
            string subtext = args[1];

            TextMatcher match = new TextMatcher(text);

            List<int> matchedResults = match.Match(subtext);
            if (matchedResults.Count > 0)
            {
                Console.WriteLine(PrintIndexes(matchedResults).ToString());
            }
        }

        /// <summary>
        /// Print the list of ints to a single string.
        /// </summary>
        /// <param name="indexes">List of ints</param>
        /// <returns>Comma separated string of the int values in the input list</returns>
        private static string PrintIndexes(List<int> indexes) 
        {
            string ReturnString = "";

            for (int i = 0; i < indexes.Count - 1; i++)
            {
                ReturnString += indexes[i].ToString() + ", ";
            }

            // Access based on index from the end (^)
            ReturnString += indexes[^1];

            return ReturnString;
        }
    }
}
