using System;

namespace _005ConversionCast
{
    class ConversionCast
    {
        static void Main(string[] args)
        {
            double numD = 5476.2654;
            int numI;
            decimal numM;

            //Conversion Explicita
            //Cast Double to Int
            numI = (int)numD;
            Console.WriteLine("El numero double es: {0}", numD);
            Console.WriteLine("El numero entero es: {0}", numI);

            //Conversion Implicita
            //Convert Int to Decimal
            numM = numI;
            Console.WriteLine("El numero decimal es: {0}", numM);
            Console.ReadLine();
        }
    }
}

//Conversion Explicita
//[variable] = ([tipo_dato])[variable]

//Conversion Implicita
//[variable] = [variable]