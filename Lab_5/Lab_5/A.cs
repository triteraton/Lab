using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class A
    {
        private decimal a = 0m;
        private decimal b = 0m;

        public A(decimal A, decimal B)
        {
            this.a = A;
            this.b = B;
        }

        public decimal c
        {
            get
            {
                return a++ - b;
            }
        }
    }
}
