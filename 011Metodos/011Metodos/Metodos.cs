using System;

namespace _011Metodos
{
    class Metodos
    {
        public int buscarMayor(int num1, int num2)
        {
            int res;

            if (num1 > num2)
            {
                res = num1;
            }
            else
            {
                res = num2;
            }

            return res;
        }

        public int buscarMenor(int num1, int num2)
        {
            return num1 < num2 ? num1 : num2;
        }
    }

    class Prueba
    {
        static void Main(string[] args)
        {
            int a = 100, b = 200, res;
            Metodos buscar = new Metodos();

            res = buscar.buscarMayor(a, b);
            Console.WriteLine("El mayor es: {0}", res);
            Console.WriteLine("El menor es: {0}", buscar.buscarMenor(a, b));
            Console.ReadLine();
        }
    }
}