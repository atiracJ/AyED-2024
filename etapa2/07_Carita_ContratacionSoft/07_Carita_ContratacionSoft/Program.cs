using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Carita_ContratacionSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("ingrese la cantidad de candidatos: ");
                int cantidadCandidatos = int.Parse(Console.ReadLine());

                List<int> puntajes = new List<int>();

                for (int i = 1; i <= cantidadCandidatos; i++)
                {
                    Console.Write("Ingrese el puntaje del candidato {i}: ");
                    int puntaje = int.Parse(Console.ReadLine());
                    puntajes.Add(puntaje);
                }

                puntajes.Sort();
                Console.WriteLine("Puntitos ordenados de menor a mayor:");
                foreach (int puntaje in puntajes)
                {
                    Console.WriteLine(puntaje);
                }
                Console.Write("Ingrese un numero entero para filtrar los multiplos: ");
                int numeroFiltro = int.Parse(Console.ReadLine());
                List<int> multiplos = puntajes.Where(p => p % numeroFiltro == 0).ToList();

                Console.WriteLine("Puntos que son multiplos de {numeroFiltro}:");
                if (multiplos.Count > 0)
                {
                    foreach (int multiplo in multiplos)
                    {
                        Console.WriteLine(multiplo);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron puntajes que sean múltiplos de {numeroFiltro}.");
                }
                Console.WriteLine("Presione cualquier tecla para salir...");
                Console.ReadKey();
            }
        }
    }


}
