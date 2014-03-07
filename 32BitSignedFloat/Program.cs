using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _32BitSignedFloat
{
    class Program
    {
        static int getSign(float f)
        {
            int num = BitConverter.ToInt32(BitConverter.GetBytes(f), 0);
            int mask = (1 << 31);
            int sign = num & mask;
            if (sign == 0)
            {
                return 0;
            }
            
             return 1;
            
        }

        static string getExponent(float f)
        {
            StringBuilder floatExponent = new StringBuilder();
            int num = BitConverter.ToInt32(BitConverter.GetBytes(f), 0);
            int mask = 0;
            int innerMask = 0;
            for(int i = 23;i <= 30;i++)
            {
                innerMask = (1 << i);
                mask = mask | innerMask;
            }
            int exponent = num & mask;
            exponent >>= 23;
           
            int bit = 0;
            for (int j = 0; j < 8;j++ )
            {
                bit = (1 << j);
                floatExponent.Insert(0, (bit & exponent)>>j);
              
            }
            return floatExponent.ToString();
        }

        static string getMantice(float f)
        {
            StringBuilder floatmantice = new StringBuilder();
            int toInt = BitConverter.ToInt32(BitConverter.GetBytes(f), 0);
            int mask = 0;
            int innerMask = 0;
            for(int i = 0;i <= 22;i++)
            {
                innerMask = (1 << i);
                mask = mask | innerMask;
            }
            int mantice = toInt & mask;
            int bit = 0;
            for(int j = 0;j <= 22;j++)
            {
                bit = (1 << j);
                floatmantice.Insert(0, (mantice & bit) >> j);
            }
            return floatmantice.ToString();
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine(getSign(f));
            Console.WriteLine(getExponent(f));
            Console.WriteLine(getMantice(f));
        }
    }
}
