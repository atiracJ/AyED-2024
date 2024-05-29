using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Carita_ElRayoCarreraVeloz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de vueltas completadas:");
            int numVueltas = int.Parse(Console.ReadLine());

            double[] tiempos = new double[numVueltas];

            for (int i = 0; i < numVueltas; i++)
            {
                Console.WriteLine("Ingrese el tiempo de la vuelta " + (i + 1) + " en segundos:");
                tiempos[i] = double.Parse(Console.ReadLine());
            }

            double tiempoTotal = 0;
            double mejorTiempo = double.MaxValue;

            for (int i = 0; i < numVueltas; i++)
            {
                tiempoTotal += tiempos[i];
                if (tiempos[i] < mejorTiempo)
                {
                    mejorTiempo = tiempos[i];
                }
            }

            double promedioTiempo = tiempoTotal / numVueltas;

            Console.WriteLine("nTiempo total de la carrera: " +tiempoTotal+ " segundos");
            Console.WriteLine("Promedio de tiempo por vuelta: " + promedioTiempo + " segundos");
            Console.WriteLine("Mejor vuelta: " + mejorTiempo + " segundos");

            Console.ReadKey();
        }
    }
}
