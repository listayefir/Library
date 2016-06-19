using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        public static void Main()
        {
            var a = new A();
            a.Number = 1;
            Console.ReadKey();
        }

  }

    class A
    {
        public int Number
        {
            set
            {
                Console.WriteLine("Hello, world");
            }
        }
    }
}
