using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_RotarMatriz90_Carita
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el tamaño de la matriz (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                }
            }

            Console.WriteLine("\nMatriz original:");
            ImprimirMatriz(matriz, n);

            int[,] matrizRotada = RotarMatriz90Grados(matriz, n);

            Console.WriteLine("\nMatriz rotada 90 grados en sentido horario:");
            ImprimirMatriz(matrizRotada, n);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void ImprimirMatriz(int[,] matriz, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] RotarMatriz90Grados(int[,] matriz, int n)
        {
            int[,] matrizRotada = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizRotada[j, n - 1 - i] = matriz[i, j];
                }
            }

            return matrizRotada;
        }
    }
}
