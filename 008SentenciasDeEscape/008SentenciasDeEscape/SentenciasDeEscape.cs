using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008SentenciasDeEscape
{
    class SentenciasDeEscape
    {
        static void Main(string[] args)
        {
            //Sentencias que requieren escape
            Console.WriteLine("Imprime \\ Prueba");
            Console.WriteLine("Imprime \' Prueba");
            Console.WriteLine("Imprime \" Prueba");
            Console.WriteLine("Imprime \a Prueba");
            Console.WriteLine("Imprime \b Prueba");
            Console.WriteLine("Imprime \f Prueba");
            Console.WriteLine("Imprime \n Prueba");
            Console.WriteLine("Imprime \r Prueba");
            Console.WriteLine("Imprime \t Prueba");
            Console.WriteLine("Imprime \v Prueba");
            Console.ReadLine();
        }
    }
}

//  \\ --> Imprime \
//  \' --> Imprime '
//  \" --> Imprime "
//  \a --> alerta
//  \b --> borra
//  \f --> formulario
//  \n --> nueva linea
//  \r --> retroceso de carro
//  \t --> tab horizontal
//  \v --> tab vertical