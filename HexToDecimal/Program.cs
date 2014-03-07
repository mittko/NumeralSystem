using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class Program
    {
        static ulong getDecimal(String hex)
        {
            ulong dec = 0;

            for (int i = hex.Length - 1; i >= 0;i-- )
            {
                switch(hex[i])
                {
                    case '0': dec += (0 * getBase(hex.Length - 1 - i)); break;
                    case '1': dec += (1 * getBase(hex.Length - 1 - i));break;
                    case '2': dec += (2 * getBase(hex.Length - 1 - i));break;
                    case '3': dec += (3 * getBase(hex.Length - 1 - i));break;
                    case '4': dec += (4 * getBase(hex.Length - 1 - i));break;
                    case '5': dec += (5 * getBase(hex.Length - 1 - i));break;
                    case '6': dec += (6 * getBase(hex.Length - 1 - i));break;
                    case '7': dec += (7 * getBase(hex.Length - 1 - i));break;
                    case '8': dec += (8 * getBase(hex.Length - 1 - i));break;
                    case '9': dec += (9 * getBase(hex.Length - 1 - i));break;
                    case 'A': dec += (10 * getBase(hex.Length - 1 - i));break;
                    case 'B': dec += (11 * getBase(hex.Length - 1 - i));break;
                    case 'C': dec += (12 * getBase(hex.Length - 1 - i));break;
                    case 'D': dec += (13 * getBase(hex.Length - 1 - i));break;
                    case 'E': dec += (14 * getBase(hex.Length - 1 - i));break;
                    case 'F': dec += (15 * getBase(hex.Length - 1 - i)); break;
                    default: break;
                }
            }
            return dec;
        }

        static ulong getBase(int j)
        {
            ulong b = 1;
            for(int i = 0;i < j;i++)
            {
                b *= 16;
            }
            return b;
        }

        static void Main(string[] args)
        {
            String hex = Console.ReadLine();
            Console.WriteLine(getDecimal(hex));
        }
    }
}
