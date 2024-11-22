using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Carita_RotarMatriz90
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("ingresa el tamaño de la matriz (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            Console.WriteLine("Ingresa los elementos de la matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz original:");
            ImprimirMatriz(matriz);

            int[,] matrizRotada = RotarMatriz90(matriz);

            Console.WriteLine("Matriz rotada 90 grados en sentido horario:");
            ImprimirMatriz(matrizRotada);

            Console.WriteLine("Presiona cualquier tecla para salir");
            Console.ReadKey();
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            int n = matriz.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] RotarMatriz90(int[,] matriz)
        {
            int n = matriz.GetLength(0);
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