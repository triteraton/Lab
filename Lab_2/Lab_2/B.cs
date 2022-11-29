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
        public B(decimal D, decimal A, decimal B) : base(A, B)
        {
            this.d = D;
        }
        public decimal c2
        {
            get
            {
                do
                {
                    d-= d - c;
                } while (d >= 5);
                return d;
            }
        }
    }
}