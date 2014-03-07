using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarryToDecimal
{
    class Program
    {
        static ulong getDecimal(string bin)
        {
            ulong dec = 0;
            for(int i = bin.Length-1;i >= 0;i--)
            {
                dec += ulong.Parse(bin[i].ToString()) * getBase(bin.Length - 1 - i);
            }
            return dec;
        }

        static ulong getBase(int pos)
       {
            ulong b = 1;
            for(int i = 0;i < pos;i++)
            {
                b *= 2;
            }
            return b;
       }

        static void Main(string[] args)
        {
            Console.Write("enter binarry number:");
            String bin = Console.ReadLine();
            Console.WriteLine(getDecimal(bin));
        }
    }
}
