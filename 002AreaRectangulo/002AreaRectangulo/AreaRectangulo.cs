using System;

namespace _002AreaRectangulo
{
    class AreaRectangulo
    {
        //Class "Rectangulo"
        class Rectangulo
        {
            //Variables rectangulo
            double ancho, largo;

            //Metodo datos por default
            public void datosDefault()
            {
                largo = 4.5;
                ancho = 3.5;
            }

            //Metodo datos
            public void datos()
            {
                Console.Write("\nIngrese largo: ");
                largo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese ancho: ");
                ancho = double.Parse(Console.ReadLine());
            }

            //Metodo calcular area
            public double area()
            {
                return (largo * ancho);
            }

            //Metodo imprimir
            public void imprimir()
            {
                Console.WriteLine("Largo: {0}", largo);
                Console.WriteLine("Ancho: {0}", ancho);
                Console.WriteLine("Area: {0}", area());
            }
        }

        //Main code
        static void Main(string[] args)
        {
            Rectangulo rect = new Rectangulo();

            rect.datosDefault();
            rect.imprimir();
            rect.datos();
            rect.imprimir();
            Console.ReadLine();
        }
    }
}

//[variable] = double.Parse(String);
//[variable] = Convert.ToDouble(String);