using System;

namespace _006ConversionConMetodos
{
    class ConversionMetodo
    {
        static void Main(string[] args)
        {
            int i = 48;
            float f = 43215.1215f;
            double d = 1234.12589;
            bool b = true;

            //Convertir a String
            Console.WriteLine("Int ({0}) to String: {1}", i, i.ToString());
            Console.WriteLine("Float ({0}) to String: {1}", f, f.ToString());
            Console.WriteLine("Double ({0}) to String: {1}", d, d.ToString());
            Console.WriteLine("Bool ({0}) to String: {1}", b, b.ToString());
            Console.ReadLine();
        }
    }
}

//Convertir variables a String
//[variable].ToString()