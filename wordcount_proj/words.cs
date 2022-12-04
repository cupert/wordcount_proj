using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace wordcount_proj
{
    public class words
    {


        public List<string> getallWords()
        {
            List<string> words = new List<string>();
            string extension = "txt";
            string path = "C:\\Users\\Cuper\\Desktop\\Cupi\\FH\\5.Sem\\fprog\\wordcount_proj\\Testfolder";
            var files = Directory.EnumerateFiles(path, "*." + extension, SearchOption.AllDirectories);


            //var counts = files.MapReduce();

            foreach (string file in Directory.EnumerateFiles(path, "*.txt", SearchOption.AllDirectories))
            {
                string[] splits = File.ReadAllText(file).Split(' ');
                foreach (string line in splits)
                {
                    words.Add(line.ToLower());
                }
            }
            return words;
        }



        public List<string> cleanupWords(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                words[i] = RemoveSpecialChar(words[i]);
                //überprüfe ob es leere einträge gibt und löschen

                words[i] = RemovenewLines(words[i]);
                if (words[i] == "")
                {
                    words.RemoveAt(i);
                }
            }
            return words;
        }



        public String RemoveSpecialChar(string value)
        {
            string[] chars = new string[] { ",", "[", "]", "?", ".", "-", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };
            //es fehlen noch /r und /n (new line & new doc)
            for (int i = 0; i < chars.Length; i++)
            {
                if (value.Contains(chars[i]))
                {
                    value = value.Replace(chars[i], "");
                }
            }
            return value;
        }

        public String RemovenewLines(string value)
        {
            //geht nicht
            string replacement = Regex.Replace(value, @"\t|\n|\r", "");
            return value;
        }
    }
}
