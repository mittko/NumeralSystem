using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//   Write a program to convert decimal numbers to their hexadecimal representation.

namespace DecimalToHexadecimal
{
    class Program
    {
        static string getHex(ulong u)
        {
            StringBuilder hex = new StringBuilder();
            if(u == 0)
            {
                return (hex.Append("0x0")).ToString();
            }
            while(u > 0)
            {
                ulong rem = (u % 16);
                if (rem > 9)
                {
                    switch (rem)
                    {
                        case 10: hex.Insert(0, 'A'); break;
                        case 11: hex.Insert(0, 'B'); break;
                        case 12: hex.Insert(0, 'C'); break;
                        case 13: hex.Insert(0, 'D'); break;
                        case 14: hex.Insert(0, 'E'); break;
                        case 15: hex.Insert(0, 'F'); break;
                        default: break;
                    }
                }
                else
                {
                    hex.Insert(0, rem);
                }
                u /= 16;
            }
            hex.Insert(0,"0x");
            return hex.ToString();
        }

        static void Main(string[] args)
        {
            ulong h = ulong.Parse(Console.ReadLine());
            string hex = getHex(h);
            Console.WriteLine(hex);
        }
    }
}
