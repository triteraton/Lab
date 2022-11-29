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
        private float[,] nArr = { { 1, 2, 3 }, { 4, 5, 6 } };
        private int lenght = 0;

        public float this[int ind1, int ind2]
        {
            get { return nArr[ind1, ind2]; }
            set { nArr[ind1, ind2] = value; }
        }

        public decimal this[int ind1]
        {
            get { return arr[ind1]; }
            set { arr[ind1] = value; }
        }

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
            lenght = arr.Length;
        }

        public static bool operator & (B objA, B objB)
        {
            if (objA == objB)
                return true;
            return false;
        }
        public static bool operator false(B obj)
        {
            if (obj.d >= 0)
                return false;
            return true;
        }

        public static bool operator true(B obj)
        {
            if (obj.d <= 0)
                return true;
            return false;
        }

        public void printArr()
        {
            int k = 0;
            foreach (int i in arr)
            {
                Console.WriteLine($"arr [{k++}]: {i}");

            }

        }

        public int len
        {
            get
            {
                return lenght;
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