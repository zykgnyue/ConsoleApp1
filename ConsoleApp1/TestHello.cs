using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestHello
    {
        ///Hello
        ///
        public void Hello(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach(string xx in args)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(xx);
            }
            Console.ResetColor();
        }

        public static void HelloStatic(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach (string xx in args)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" "+xx);
            }
            Console.ResetColor();

        }
    }
}
