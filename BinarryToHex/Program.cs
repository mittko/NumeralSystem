using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace BinarryToHex
{
    class Program
    {
        static void getHex(string bin)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder hex = new StringBuilder();
            int counter = 0;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                sb.Insert(0, bin[i]);
                counter++;
                if (counter % 4 == 0 || i == 0)
                {
                    while (sb.Length < 4)
                    {
                        sb.Insert(0, 0);
                    }
                    switch (sb.ToString())
                    {
                        case "0000": hex.Insert(0, "0"); break;
                        case "0001": hex.Insert(0, "1"); break;
                        case "0010": hex.Insert(0, "2"); break;
                        case "0011": hex.Insert(0, "3"); break;
                        case "0100": hex.Insert(0, "4"); break;
                        case "0101": hex.Insert(0, "5"); break;
                        case "0110": hex.Insert(0, "6"); break;
                        case "0111": hex.Insert(0, "7"); break;
                        case "1000": hex.Insert(0, "8"); break;
                        case "1001": hex.Insert(0, "9"); break;
                        case "1010": hex.Insert(0, "A"); break;
                        case "1011": hex.Insert(0, "B"); break;
                        case "1100": hex.Insert(0, "C"); break;
                        case "1101": hex.Insert(0, "D"); break;
                        case "1110": hex.Insert(0, "E"); break;
                        case "1111": hex.Insert(0, "F"); break;
                        default: break;
                    }
                    sb = new StringBuilder();
                }
            }
            Console.WriteLine(hex);
         
        }

        static void Main(string[] args)
        {
            String bin = Console.ReadLine();
            getHex(bin);
            
           
        }
    }
}
