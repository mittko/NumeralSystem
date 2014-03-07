using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Write a program to convert decimal numbers to their binary representation.

namespace ConvertDecimalToBinarry
{
    class Program
    {
        static string getBin(ulong num)
        {
            StringBuilder sb = new StringBuilder();
            while(num > 0)
            {
                sb.Append(num & 1);
                num >>= 1;
            }
            return reverse(sb.ToString());
        }

        static string getBinarry(ulong num)
        {

            StringBuilder sb = new StringBuilder();
            while(num > 0)
            {
                sb.Append(num % 2);
                num /= 2;
            }
            return reverse(sb.ToString());
        }

        static string reverse(string str)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = str.Length-1;i >= 0;i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            ulong num = ulong.Parse(Console.ReadLine());
            Console.WriteLine(getBinarry(num));
            Console.WriteLine(getBin(num));

        }
    }
}
