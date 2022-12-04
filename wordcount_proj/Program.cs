namespace wordcount_proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            words word = new words();
            List<string> test = word.getallWords();
            List<listpack> listpacks = new List<listpack>();
            test = word.cleanupWords(test);

            foreach(string singleword in test)
            {
                listpacks.Add(new listpack(singleword));
            }

            //var query = from singlepack in listpacks
            //group singlepack by singlepack into e
            //select new(data = e.Key, count = e.Count());
            foreach (var g in test
                    .GroupBy(x => x, StringComparer.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("{0}: {1}", g.Key, g.Count());
            }

        }
    }
}  