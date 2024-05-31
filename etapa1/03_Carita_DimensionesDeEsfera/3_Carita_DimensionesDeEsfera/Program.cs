using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Carita_DimensionesDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double superficie;
            double volumen;
            double pi = 3.14;
            Console.WriteLine("ingresa el radio de la esfera: ");
            radio = double.Parse(Console.ReadLine());


            double radioCuadrado = radio * radio;
            double radioCubo = radio * radio * radio;

            superficie = 4 * pi * radioCuadrado;
            volumen = (4.0 / 3.0) * pi * radioCubo;


            Console.WriteLine("La superficie de la esfera es: " + superficie);
            Console.WriteLine("El volumen de la esfera es: " + volumen));


            Console.ReadKey();
        }
    }
}
