using Microsoft.VisualBasic;
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
            C<int> intC = new C<int>();
            C<String> stringC = new C<String>();

            for (int i = 0; i < bObject.len; i++)
            {
                Console.WriteLine($"b[{i}]: {bObject[i]}");
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"b[{i},{j}]: {bObject[i, j]}");
                }
            }

            Console.WriteLine($"Result c: {aObject.c}");
            Console.WriteLine($"Result c from B: {bObject.c}");
            Console.WriteLine($"Result c2 from B: {bObject.c2}");
            bObject.printArr();

            intC.forParam = 5;
            stringC.forParam = "hi!";

            Console.WriteLine();
            Console.WriteLine($"Result param int: {intC.forParam}");
            Console.WriteLine($"Result param string: {stringC.forParam}");
            Console.WriteLine($"Result static field: {C<int>.value}");


            Console.Read();
        }
    }
}