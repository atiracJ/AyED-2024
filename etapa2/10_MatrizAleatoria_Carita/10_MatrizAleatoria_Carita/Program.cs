using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_MatrizAleatoria_Carita
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solicitar el número de filas (n)
            Console.Write("Ingrese el número de filas (n): ");
            int n = int.Parse(Console.ReadLine());

            // Solicitar el número de columnas (m)
            Console.Write("Ingrese el número de columnas (m): ");
            int m = int.Parse(Console.ReadLine());

            // Crear la matriz de nxm
            int[,] matriz = new int[n, m];

            // Inicializar el generador de números aleatorios
            Random random = new Random();

            // Llenar la matriz con valores aleatorios entre 1 y 100
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = random.Next(1, 101); // El valor máximo es exclusivo, por eso se usa 101
                }
            }

            // Imprimir la matriz
            Console.WriteLine("\nLa matriz de " + n + "x" + m + " con valores aleatorios entre 1 y 100 es:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Esperar a que el usuario presione una tecla antes de cerrar
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
