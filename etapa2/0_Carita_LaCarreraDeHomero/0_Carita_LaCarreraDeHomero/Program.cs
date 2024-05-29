using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Carita_LaCarreraDeHomero
{
    class Program
    {
        static void Main(string[] args)
        {


            
            Console.Write("Ingrese la cantidad de obstáculos: ");
            int cantidadObstaculos;

            while (!int.TryParse(Console.ReadLine(), out cantidadObstaculos))
            {
                Console.WriteLine("ingrese un número válido.");
                Console.Write("Ingrese la cantidad de obstáculos: ");
            }

            int puntajeTotal = 0;

            for (int i = 1; i <= cantidadObstaculos; i++)
            {
                Console.Write("¿Homero supera el obstáculo" + i + "si/no: ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta == "si ")
                {
                    puntajeTotal += 10;
                }
                else if (respuesta == "no ")
                {
                    puntajeTotal -= 5;
                }
                else
                {
                    Console.WriteLine("responda si o no ");
                    i--; // Para repetir la misma pregunta.
                }
            }

            Console.WriteLine("El puntaje total de Homero es: " + puntajeTotal);
            Console.WriteLine("Gracias por jugar, Hasta luego");
            Console.ReadKey();
        }

    }
            
}
   