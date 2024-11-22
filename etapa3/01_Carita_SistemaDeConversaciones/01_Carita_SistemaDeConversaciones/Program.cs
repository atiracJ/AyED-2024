using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Carita_SistemaDeConversaciones
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Convertir un número decimal a binario.");
                Console.WriteLine("2. Convertir un número binario a decimal.");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Ingresa un número decimal: ");
                    int numeroDecimal = int.Parse(Console.ReadLine());
                    string binario = DecimalABinario(numeroDecimal);
                    Console.WriteLine($"El número decimal {numeroDecimal} en binario es: {binario}");
                }
                else if (opcion == 2)
                {
                    Console.Write("Ingresa un número binario: ");
                    string numeroBinario = Console.ReadLine();
                    int decimalResultante = BinarioADecimal(numeroBinario);
                    Console.WriteLine($"El número binario {numeroBinario} en decimal es: {decimalResultante}");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

                Console.WriteLine("Presione cualquier tecla para salir");
                Console.ReadKey();
            }

            static string DecimalABinario(int numeroDecimal)
            {
                string binario = "";
                while (numeroDecimal > 0)
                {
                    int residuo = numeroDecimal % 2;
                    binario = residuo + binario; 
                    numeroDecimal /= 2;
                }
                return binario == "" ? "0" : binario; 
            }

            static int BinarioADecimal(string numeroBinario)
            {
                int numeroDecimal = 0;
                int exponente = 0;

                for (int i = numeroBinario.Length - 1; i >= 0; i--)
                {
                    if (numeroBinario[i] == '1')
                    {
                        numeroDecimal += (int)Math.Pow(2, exponente);
                    }
                    exponente++;
                }

                return numeroDecimal;
            }
        }
    }


