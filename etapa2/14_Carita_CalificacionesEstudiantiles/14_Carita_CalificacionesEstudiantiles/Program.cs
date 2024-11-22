using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Carita_CalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("ingresa la cantidad de estudiantes (N): ");
                int n = int.Parse(Console.ReadLine());

                string[,] estudiantes = new string[n, 3];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Ingrese los datos del estudiante {i + 1}:");

                    Console.Write("Nombre: ");
                    estudiantes[i, 0] = Console.ReadLine();

                    Console.Write("Edad: ");
                    estudiantes[i, 1] = Console.ReadLine();

                    Console.Write("Calificación: ");
                    estudiantes[i, 2] = Console.ReadLine();
                }

                Console.WriteLine("Información de los estudiantes:");
                Console.WriteLine("Nombre\t\tEdad\tCalificación");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"{estudiantes[i, 0]}{estudiantes[i, 1]}{estudiantes[i, 2]}");
                }

                Console.WriteLine("Presione cualquier tecla para salir");
                Console.ReadKey();
            }
        }
    }


}
