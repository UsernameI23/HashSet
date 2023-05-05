namespace HashSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> languages = new HashSet<string>();
            languages.Add("Japanese");
            languages.Add("Spanish");
            languages.Add("English");
            languages.Add("Italian");

            HashSet<string> otherLanguages = new HashSet<string>();
            otherLanguages.Add("Chinese");
            otherLanguages.Add("Arabic");
            otherLanguages.Add("Russain");
            otherLanguages.Add("French");

            HashSet<string> uncommonLanguages = new HashSet<string>();
            uncommonLanguages.Add("Tagalog");
            uncommonLanguages.Add("Egyptian");
            uncommonLanguages.Add("Latin");
            uncommonLanguages.Add("Japanese");
            uncommonLanguages.Add("Italian");

            Console.WriteLine("Combined list of older and newer languages");
            languages.UnionWith(otherLanguages);
            foreach (string language in languages)
            {
                Console.WriteLine(language);
            }
            Console.WriteLine();

            Console.WriteLine("Languages that are in both lists");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = languages;
            bothLists.IntersectWith(uncommonLanguages);
            foreach (string language in bothLists)
            {
                Console.WriteLine(language);
            }
        }
    }
}

