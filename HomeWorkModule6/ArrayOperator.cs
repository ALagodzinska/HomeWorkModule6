using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModule6
{
    class ArrayOperator
    {        
        private int[] Array1;
        private int[] Array2;
        
        public int[] array1 { get { return Array1; } }
        public int[] array2 { get { return Array2; } }

        public ArrayOperator(int[] array1, int[] array2)
        {
            Array1 = array1;
            Array2 = array2;            
        }

        public void fillArray()
        {
            for (int i = 0; i < Array1.Length; i++)
            {
                Array2[i] = Array1[i];
            }
        }
    }
}
