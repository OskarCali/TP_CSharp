using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015String
{
    class StringProg
    {
        static void Main(string[] args)
        {
            string nombre, apellido;
            nombre = "Oskar";
            apellido = " Lira";

            string nombreCompleto = nombre + apellido;
            Console.WriteLine("Nombre Completo: {0}", nombreCompleto);

            char[] letras = { 'H', 'o', 'l', 'a' };
            string saludo = new string(letras);
            Console.WriteLine("\nEl saludo es: {0}", saludo);

            string[] sArray = { "Hola", "mundo!!", "soy", "Oskar" };
            string mensaje = String.Join(" ", sArray);
            Console.WriteLine("\nEl mensaje es: {0}", mensaje);

            DateTime espera = new DateTime(2017, 11, 23, 23, 36, 34);
            string chat = String.Format("El mensaje fue enviado a las {0:t} el dia {0:D}", espera);
            Console.WriteLine("\nMensaje: {0}", chat);

            Console.ReadLine();
        }
    }
}
