using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Programm
    {
        public static void Main(string[] args)
        {
            A aObject = new A(15, 4);
            B bObject = new B(1, 8, 64);

            Console.WriteLine($"Result: {aObject.c}");
            Console.WriteLine($"Result: {bObject.c2}");
            Console.Read();
        }
    }
}