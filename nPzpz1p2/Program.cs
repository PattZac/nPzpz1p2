using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nPzpz1p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = { 77, 15, 6, 8, 909, 0, 3, 777, 555, 3 },
            n2 = { 77, 9, 9, 8, 101, 3, 3, 3, 3, 3 };
            int m, n = 0;
            if (n1.Length < n2.Length)
            {
                m = n1.Length;
            }
            else
            {
                m = n2.Length;
            }
            for (int i = 0; i < m; i++)
            {
                if (n1[i] == n2[i])
                {
                    n++;
                }
            }

            Console.WriteLine("Broj istih vrijednosti na istim indeksima je " + n);

            Console.ReadKey();
        }
    }
}
