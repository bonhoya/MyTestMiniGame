using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMiniGame
{
    public class Util
    {
        public void SolwTalk(string message, ConsoleColor color)
        {
            foreach(char c in message)
            {
                Console.ForegroundColor = color;
                Console.Write(c);
                Console.ResetColor();
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }
    }
}
