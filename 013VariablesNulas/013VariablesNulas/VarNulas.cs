using System;

namespace _013VariablesNulas
{
    class VarNulas
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? check1 = new bool?();
            bool? check2 = new bool();

            Console.WriteLine("Numeros {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("Valor bool: {0}, {1}", check1, check2);

            num3 = num1 ?? 5.34;
            Console.WriteLine("Numero: {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine("Numero: {0}", num3);

            Console.ReadLine();
        }
    }
}
