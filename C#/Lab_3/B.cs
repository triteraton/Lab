using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class B : A
    {
        private decimal d = 0m;
        private decimal[] arr = Array.Empty<decimal>();
        public B(decimal D, decimal A, decimal B) : base(A, B)
        {
            this.d = D;
        }

        public B(decimal D, decimal A, decimal B, int coef) : this(D, A, B)
        {
            arr = new decimal[(int)A + coef];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = c2 * i;
            }
        }

        public void printArr()
        {
            int k = 0;
            foreach (int i in arr)
            {
                Console.WriteLine($"arr [{k++}]: {i}");

            }

        }
        public decimal c2
        {
            get
            {
                do
                {
                    d -= d - c;
                } while (d >= 5);
                return d;
            }
        }
    }
}