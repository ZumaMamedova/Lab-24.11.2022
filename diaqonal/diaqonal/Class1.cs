using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diaqonal
{
    internal class Class1
    {
        public void Asdf(int[,] a)
        {
            int sum1 = 0;
            int sum2 = 0;
            int j = a.GetLength(1) - 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum1 = sum1 + a[i, i];
            }
            for (int i = 0; i < a.GetLength(1)-1; i++)
            {
                sum2 = sum2 + a[j, j];
                j--;
            }
            Console.WriteLine(sum1 - sum2);
        }

    }
}
