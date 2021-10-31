using System;

namespace HomeWorkModule6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1 };
            int[] Array2 = new int[10];

            ArrayOperator arrayOperator = new ArrayOperator(Array1, Array2);

            arrayOperator.fillArray();

            Console.WriteLine($"Array1: {string.Join(", ", arrayOperator.array1)}\n" +
                $"Populated Array2: {string.Join(", ", arrayOperator.array2)}");

            Console.ReadLine();            
        }
    }
}
