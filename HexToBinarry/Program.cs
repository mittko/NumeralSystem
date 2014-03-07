using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToBinarry
{
    class Program
    {
        static string getBin(string hex)
        {
            if(hex == "0")
            {
                return "0";
            }
            int num = 0;
            int[] bits = new int[4];
            StringBuilder sb = new StringBuilder();
            for(int i = hex.Length-1;i >= 0;i--)
            {
                bits = new int[4];
                if (hex[i] >= 'A' && hex[i] <= 'F')
                {
                    switch (hex[i])
                    {
                        case 'A': num = 10; break;
                        case 'B': num = 11; break;
                        case 'C': num = 12; break;
                        case 'D': num = 13; break;
                        case 'E': num = 14; break;
                        case 'F': num = 15; break;
                        default: break;
                    }
                }

                else
                {
                    num = int.Parse(hex[i].ToString());
                }
                if (i > 0)
                {
                    for (int index = 3; index >= 0; index--)
                    {
                        int mask = (1 << (3 - index));
                        bits[index] = (num & mask) >> (3 - index);
                        sb.Insert(0, bits[index]);
                    }
                }
                else
                {
                    while(num > 0)
                    {
                        sb.Insert(0,num & 1);
                        num >>= 1;
                    }
                }
               
            }
            return sb.ToString();
        }


        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            for (int i = 0; i < hex.Length;i++ )
            {
                if(Char.IsLower(hex[i]))
                {
                    Console.WriteLine("incorrect value!");
                    return;
                }
            }
                Console.WriteLine(getBin(hex));  
        }
    }
}
