using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012Recursividad
{
    class Recursividad
    {
        public int factorial(int num)
        {
            int res;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                res = factorial(num - 1) * num;
                return res;
            }
        }

        public int fact(int num)
        {
            return num == 1 ? 1 : fact(num - 1) * num;
        }

        static void Main(string[] args)
        {
            Recursividad operacion = new Recursividad();

            Console.WriteLine(" 6! = {0}", operacion.fact(6));
            Console.WriteLine(" 5! = {0}", operacion.factorial(5));
            Console.WriteLine(" 4! = {0}", operacion.fact(4));
            Console.WriteLine(" 3! = {0}", operacion.factorial(3));
            Console.WriteLine(" 2! = {0}", operacion.fact(2));
            Console.ReadLine();
        }
    }
}
