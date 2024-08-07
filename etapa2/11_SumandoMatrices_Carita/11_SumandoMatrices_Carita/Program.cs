using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_SumandoMatrices_Carita
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el número de filas (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas (m): ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                }
            }

            Console.WriteLine("\nLa matriz de " + n + "x" + m + " con valores aleatorios entre 1 y 100 es:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
