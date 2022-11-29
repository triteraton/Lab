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
            B bObject = new B(2, 3, 4, 1);

            Console.WriteLine($"Result c: {aObject.c}");
            Console.WriteLine($"Result c from B: {bObject.c}");
            Console.WriteLine($"Result c2 from B: {bObject.c2}");
            bObject.printArr();
            Console.Read();
        }
    }
}