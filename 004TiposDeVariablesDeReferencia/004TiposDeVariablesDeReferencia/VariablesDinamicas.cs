using System;

namespace _004TiposDeVariablesDeReferencia
{
    class VariablesDinamicas
    {
        static void Main(string[] args)
        {
            //Creacion de objeto
            object obj;
            obj = 100;

            //Creacion de tipo dinamico
            dynamic din = 20;

            //Cadenas de texto
            String str = "Hola Mundo";
            String str2 = @"Hola Mundo!!";

            Console.WriteLine("Objeto: {0}", obj);
            Console.WriteLine("Dinamico: {0}", din);
            Console.WriteLine("String: {0}", str);
            Console.WriteLine("String: {0}", str2);
            Console.WriteLine("String: {0}", @"HelloWorld!");
            Console.ReadLine();
        }
    }
}

//String [variable] = "Texto";
//String [variable] = @"Texto";