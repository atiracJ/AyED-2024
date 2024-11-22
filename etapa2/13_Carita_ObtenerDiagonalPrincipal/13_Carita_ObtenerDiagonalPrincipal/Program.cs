using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Carita_ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("ingrese el tamaño de la matriz (n): ");
                int n = int.Parse(Console.ReadLine());

                int[,] matriz = new int[n, n];
                Random random = new Random();

                Console.WriteLine("\nMatriz generada con números aleatorios:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matriz[i, j] = random.Next(1, 101); 
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                int[] diagonal = new int[n];

                for (int i = 0; i < n; i++)
                {
                    diagonal[i] = matriz[i, i];
                }

                Console.WriteLine("Diagonal principal de la matriz:");
                for (int i = 0; i < diagonal.Length; i++)
                {
                    Console.Write(diagonal[i] + " ");
                }

                Console.WriteLine("Presione cualquier tecla para salir");
                Console.ReadKey();
            }
        }
    }


}
