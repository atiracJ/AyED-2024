using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Carita_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)
        {
            string ciudad;
            string nombre;
            Console.WriteLine("ingrese el nombre de una ciudad ciudad");
            ciudad = Console.ReadLine();
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " bienvenido a la ciudad de " + ciudad);
            Console.ReadKey();
        }
    }
}
