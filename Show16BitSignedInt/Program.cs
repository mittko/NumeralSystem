using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show16BitSignedInt
{
    class Program
    {
        static string getBin(short sh)
        {
            StringBuilder bin = new StringBuilder();
            int mask = 0;
            int bit = 0;
            for(int i = 0;i < 16;i++)
            {
                mask = (1 << i);
                bit = (sh & mask) >> i;
                bin.Insert(0, bit);
            }
            return bin.ToString();
        }
        static void Main(string[] args)
        {
            short sh = short.Parse(Console.ReadLine());
            Console.WriteLine(getBin(sh));
        }
    }
}
