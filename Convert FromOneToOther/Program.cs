using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Write a program to convert from any numeral system of given base s to any other 
//  numeral system of base d (2 ≤ s, d ≤  16).

namespace Convert_FromOneToOther
{
    class Program
    {

        static int convertFromSBaseToDecimal(string num, int toBase)
        {
            int index = num.Length - 1;
            int dec = 0;
            int toAdd = 0;
            for(int i = index;i >= 0;i--)
            {
                toAdd = num[i] - 48;
                if(toAdd > 9)
                {
                    toAdd -= 7;
                }
                dec += toAdd * (int)Math.Pow(toBase,num.Length-1-i);
            }
            return dec;
        }

        static string convertFromDecToDBase(int fromDec,int toDBase)
        {
            StringBuilder result = new StringBuilder();
            while(fromDec > 0)
            {
                int remainder = fromDec % toDBase;
                if(remainder <= 9)
                {
                    result.Insert(0, remainder);
                }
                else
                {
                    result.Insert(0, (char)(remainder + 55));
                }
                fromDec /= toDBase;
            }
            return result.ToString();
        }

        static void Main(string[] args)
        {
            int fromSBase = int.Parse(Console.ReadLine());
            int toDBase = int.Parse(Console.ReadLine());
            string num = Console.ReadLine();
            int toDec = convertFromSBaseToDecimal(num,fromSBase);
            string result = convertFromDecToDBase(toDec, toDBase);
            Console.WriteLine(result);
        }
    }
}
