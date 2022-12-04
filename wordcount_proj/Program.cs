namespace wordcount_proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            words word = new words();
            List<string> test = word.getallWords();

            test = word.cleanupWords(test);


            //check words:

            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine($"Count: {i} value: {test[i]}");
            }
        }
    }
}