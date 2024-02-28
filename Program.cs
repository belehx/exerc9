using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("digite um número: ");
            a = int.Parse(Console.ReadLine());

            if (a%2 == 0)
            {
                Console.WriteLine("o número digitado é par!");
            }
            else
            {
                Console.WriteLine("o número digitado é ímpar!");
            }

            Console.ReadKey();
        }
    }
}
