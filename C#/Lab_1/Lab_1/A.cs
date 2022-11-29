using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class A
    {
        private decimal a = 15m;
        private decimal b = 4m;

        public float c
        {
            get { 
                return (float)(a++ - b); 
            }
        }
    }
}
