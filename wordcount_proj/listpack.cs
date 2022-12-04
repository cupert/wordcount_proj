using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordcount_proj
{
    class listpack
    {
        public string data;
        public int count;
        public listpack(string data)
        {
            this.data = data;
            this.count = 1;
        }

        public void write()
        {
            Console.WriteLine($"counts: {count} word: {data}");
        }
    }
}
