using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009VariablesConstantes
{
    class Constantes
    {
        static void Main(string[] args)
        {
            const double pi = 3.141592635;
            double r;

            Console.Write("Radio: ");
            r = Convert.ToDouble(Console.ReadLine());

            double area = pi * r * r;
            Console.WriteLine("Radio: {0}\tArea: {1}", r, area);
            Console.ReadLine();
        }
    }
}
