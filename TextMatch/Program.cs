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
    
            // Extract args
            string text = args[0];
            string subtext = args[1];

            // Perform matching
            TextMatcher textMatcher = new TextMatcher(text);
            List<int> matchedResults = textMatcher.Match(subtext);

            if (matchedResults.Count > 0)
            {
                Console.WriteLine(TextMatcher.PrintIndexes(matchedResults).ToString());
            }
        }
    }
}
