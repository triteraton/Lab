using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class C<Param>
    {
        public static String value = "static";
        private Param val;

        public Param forParam
        {
            get { return val; }
            set { val = value; }
        }
    }
}
