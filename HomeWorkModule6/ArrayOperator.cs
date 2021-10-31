using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModule6
{
    class ArrayOperator
    {        
        private int[] array1;
        private int[] array2;
        
        public int[] Array1 { get { return array1; } }
        public int[] Array2 { get { return array2; } }

        public ArrayOperator(int[] array1, int[] array2)
        {
            this.array1 = array1;
            this.array2 = array2;            
        }

        public void fillArray()
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }
        }
    }
}
