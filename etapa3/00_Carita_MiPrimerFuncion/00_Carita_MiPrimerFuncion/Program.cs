using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Carita_MiPrimerFuncion
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.Write("ingresa tu nombre: ");
                string nombre = Console.ReadLine();

                Mostrarsaludo(nombre);

                Console.WriteLine("Presione cualquier tecla para salir");
                Console.ReadKey();
            }

            static void Mostrarsaludo(string nombre)
            {
                Console.WriteLine($"¡Hola {nombre}!");
            }
        }
    }


