using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Carita_MiPrimeraMatriz
{
    class Program
    {
        static void Main(string[] args)
        {

            using System;

namespace MatrizCeros
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("ingresa el número de filas (n): ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("ingresa el número de columnas (m): ");
                int m = int.Parse(Console.ReadLine());

                int[,] matriz = new int[n, m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matriz[i, j] = 0;
                    }
                }

                Console.WriteLine("Matriz de ceros:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                    Console.WriteLine();

                Console.WriteLine("Presione cualquier tecla para salir");
                Console.ReadKey();
            }
        }
    }


}
    }
}
