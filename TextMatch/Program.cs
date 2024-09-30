namespace TextMatch
{
    internal class Program
    {
        public static void main(string[] args)
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

        private static string PrintIndexes(List<int> indexes) 
        {
            string ReturnString = "";

            return ReturnString;
        }
    }
}
