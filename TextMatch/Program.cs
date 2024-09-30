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
        }
    }
}
