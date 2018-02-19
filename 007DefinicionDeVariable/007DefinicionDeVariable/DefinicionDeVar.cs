using System;

namespace _007DefinicionDeVariable
{
    class DefinicionDeVar
    {
        static void Main(string[] args)
        {
            short a;
            int b, num;
            double c;

            a = 10;
            b = 20;
            c = a + b;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.WriteLine("{0} + {1} = {2}", a, b, c);
            Console.ReadLine();

            Console.Write("Ingrese numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero es: {0}", num);
            Console.ReadLine();
        }
    }
}
