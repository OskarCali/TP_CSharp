using System;

namespace _003TamañoDeVariables
{
    class TamañoVar
    {
        static void Main(string[] args)
        {
            //Imprime tamaño en byte
            Console.WriteLine("Tamaño (int): {0}", sizeof(int));
            Console.WriteLine("Tamaño (double): {0}", sizeof(double));
            Console.WriteLine("Tamaño (float): {0}", sizeof(float));
            Console.WriteLine("Tamaño (char): {0}", sizeof(char));
            Console.WriteLine("Tamaño (bool): {0}", sizeof(bool));
            Console.WriteLine("Tamaño (decimal): {0}", sizeof(decimal));
            Console.ReadLine();
        }
    }
}

//sizeof([tipo_dato]);