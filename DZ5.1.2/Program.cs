using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VVod");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] table = new int[n, n];
            for (int t = 0; t < n; t++)
            {
                int k = 1;
                for (int i = 0; i < n; i++)
                {

                    table[i, t] = k;
                    if (k == 1) k = 0;
                    else k = 1;
                    Console.Write(k+"\t");



                }
                Console.WriteLine();


            }
            Console.ReadKey();
        }
    }
}
