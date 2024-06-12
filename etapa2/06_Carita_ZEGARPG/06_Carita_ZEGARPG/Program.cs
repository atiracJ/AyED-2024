using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Carita_ZEGARPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de elementos a analizar: ");
            int cantidadElementos = int.Parse(Console.ReadLine());

            int[] valoresObjetos = new int[cantidadElementos];

            Console.WriteLine("Ingrese los valores de los objetos:");
            for (int i = 0; i < cantidadElementos; i++)
            {
                Console.Write($"Objeto " + (i + 1) + " : ");
                valoresObjetos[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese el valor mínimo para el filtro: ");
            int valorMinimo = int.Parse(Console.ReadLine());

            Console.WriteLine("\nObjetos que cumplen con el filtro:");
            for (int i = 0; i < cantidadElementos; i++)
            {
                if (valoresObjetos[i] > valorMinimo)
                {
                    Console.WriteLine($"Posición " + (i + 1) + " : Valor {valoresObjetos[i]}");
                }
            }

            Console.WriteLine("\nPresiona Enter para salir...");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
