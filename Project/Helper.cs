using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Helper
    {
        public static void Print(string text, ConsoleColor color)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor = color;
                Console.Write(text[i]);
                Thread.Sleep(10);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
