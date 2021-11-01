using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5._1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            int number4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            int number5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            int number6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            int number7 = Convert.ToInt32(Console.ReadLine());
            int[] n = new int[7];
            int a = 0;
            n[0] = number1;
            n[1] = number2;
            n[2] = number3;
            n[3] = number4;
            n[4] = number5;
            n[5] = number6;
            n[6] = number7;
            for (int i = 0; i < 7; i++) a = a + n[i];
            a = a / 7;
            Console.WriteLine(" Среднее арифметическое " + a);
            Console.ReadKey();
        }
    }
}
