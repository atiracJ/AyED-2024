using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Carita_VectorRandomSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            {
         
                Console.Write("ingresa el tamaño del vector: ");
                int n = int.Parse(Console.ReadLine());

                int[] vector = new int[n];
                Random random = new Random();

                Console.Write("Ingresa el valor mínimo del rango de números aleatorios: ");
                int rangoMin = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el valor máximo del rango de números aleatorios: ");
                int rangoMax = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    vector[i] = random.Next(rangoMin, rangoMax + 1); 
                }

                int opcion;
                do
                {
                    Console.WriteLine("Menú de opciones:");
                    Console.WriteLine("1. Imprimir todos los elementos del vector");
                    Console.WriteLine("2. Buscar un número en el vector");
                    Console.WriteLine("3. Ordenar el vector (ascendente o descendente)");
                    Console.WriteLine("4. Terminar el programa");
                    Console.Write("Seleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Elementos del vector:");
                            for (int i = 0; i < vector.Length; i++)
                            {
                                Console.WriteLine($"Posición {i}: {vector[i]}");
                            }
                            break;

                        case 2:
                            Console.Write("Ingresa el número que desea buscar: ");
                            int numeroBuscado = int.Parse(Console.ReadLine());
                            bool encontrado = false;

                            for (int i = 0; i < vector.Length; i++)
                            {
                                if (vector[i] == numeroBuscado)
                                {
                                    Console.WriteLine("Numero encontrado en la posicion {i}.");
                                    encontrado = true;
                                    break;
                                }
                            }

                            if (!encontrado)
                            {
                                Console.WriteLine("El número no se encuentra en el vector.");
                            }
                            break;

                        case 3:
                            Console.Write("Selecciona el orden: 1 para ascendente, 2 para descendente: ");
                            int orden = int.Parse(Console.ReadLine());

                            if (orden == 1)
                            {
                                Array.Sort(vector); 
                                Console.WriteLine("Vector ordenado de forma ascendente.");
                            }
                            else if (orden == 2)
                            {
                                Array.Sort(vector);
                                Array.Reverse(vector); 
                                Console.WriteLine("Vector ordenado de forma descendente.");
                            }
                            else
                            {
                                Console.WriteLine("Opción inválida.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Programa finalizado.");
                            break;

                        default:
                            Console.WriteLine("Opción no válida, intente nuevamente.");
                            break;
                    }
                } while (opcion != 4);

                Console.WriteLine("Presiona cualquier tecla para salir");
                Console.ReadKey();
            }
        }
    }

}


