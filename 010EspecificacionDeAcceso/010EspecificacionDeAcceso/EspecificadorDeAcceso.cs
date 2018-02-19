using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010EspecificacionDeAcceso
{
    class EspecificadorDeAcceso
    {
        class RectanguloPublico
        {
            public double ancho, largo;

            public double calcularArea()
            {
                return ancho * largo;
            }

            public void imprimir()
            {
                Console.WriteLine("\nAncho: {0}", ancho);
                Console.WriteLine("Largo: {0}", largo);
                Console.WriteLine("Area: {0}", calcularArea());
            }

        }

        class RectanguloPrivado
        {
            private double ancho, largo;

            public void datos()
            {
                Console.Write("\nIngrese ancho: ");
                ancho = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese largo: ");
                largo = Convert.ToDouble(Console.ReadLine());
            }

            public double calcularArea()
            {
                return ancho * largo;
            }

            public void imprimir()
            {
                Console.WriteLine("\nAncho: {0}", ancho);
                Console.WriteLine("Largo: {0}", largo);
                Console.WriteLine("Area: {0}", calcularArea());
            }

        }

        class RectanguloProtegido
        {
            protected double ancho, largo;

            public void datos()
            {
                Console.Write("\nIngrese ancho: ");
                ancho = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese largo: ");
                largo = Convert.ToDouble(Console.ReadLine());
            }

            public double calcularArea()
            {
                return ancho * largo;
            }

            public void imprimir()
            {
                Console.WriteLine("\nAncho: {0}", ancho);
                Console.WriteLine("Largo: {0}", largo);
                Console.WriteLine("Area: {0}", calcularArea());
            }

        }

        class RectanguloInterno
        {
            internal double ancho, largo;

            double calcularArea()
            {
                return ancho * largo;
            }

            public void imprimir()
            {
                Console.WriteLine("\nAncho: {0}", ancho);
                Console.WriteLine("Largo: {0}", largo);
                Console.WriteLine("Area: {0}", calcularArea());
            }

        }

        class RectanguloInternoProtegido
        {
            internal protected double ancho, largo;

            double calcularArea()
            {
                return ancho * largo;
            }

            public void imprimir()
            {
                Console.WriteLine("\nAncho: {0}", ancho);
                Console.WriteLine("Largo: {0}", largo);
                Console.WriteLine("Area: {0}", calcularArea());
            }

        }

        static void Main(string[] args)
        {
            RectanguloPublico rectPub = new RectanguloPublico();
            Console.WriteLine("***Public***");
            rectPub.largo = 4.5;
            rectPub.ancho = 3.5;
            rectPub.imprimir();

            RectanguloPrivado rectPriv = new RectanguloPrivado();
            Console.WriteLine("\n\n***Private***");
            rectPriv.datos();
            rectPriv.imprimir();

            RectanguloProtegido rectProc = new RectanguloProtegido();
            Console.WriteLine("\n\n***Protected***");
            rectProc.datos();
            rectProc.imprimir();

            RectanguloInterno rectInt = new RectanguloInterno();
            Console.WriteLine("\n\n***Internal***");
            rectInt.largo = 4.5;
            rectInt.ancho = 3.5;
            rectInt.imprimir();

            RectanguloInternoProtegido rectIntProc = new RectanguloInternoProtegido();
            Console.WriteLine("\n\n***Internal Protected***");
            rectIntProc.largo = 4.5;
            rectIntProc.ancho = 3.5;
            rectIntProc.imprimir();

            Console.ReadLine();
        }
    }
}

//Public
//Los metodos y atributos estan pueden ser accedidos por cualquier otra clase

//Private
//Solo se pueden acceder los que esten dentro de la misma clase

//Protected
//Las clases hijos tienen acceso a estos elementos

//Internal
//Accesibles dentro del mismo documento

//Internal Protected
//Accesibles dentro del mismo documento y para las clases hijas

//NOTA: El identificador por defecto es Private