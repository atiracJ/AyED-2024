using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Carita_AreaVolumen
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Calcular el área de un círculo.");
                Console.WriteLine("2. Calcular el volumen de un cilindro.");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Ingresa el radio del circulo: ");
                    double radio = double.Parse(Console.ReadLine());
                    double area = CalcularAreaCirculo(radio);
                    Console.WriteLine($"El area del circulo con radio {radio} es: {area}");
                }
                else if (opcion == 2)
                {
                    Console.Write("Ingresa el radio de la base del cilindro: ");
                    double radio = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura del cilindro: ");
                    double altura = double.Parse(Console.ReadLine());
                    double volumen = CalcularVolumenCilindro(radio, altura);
                    Console.WriteLine($"El volumen del cilindro con radio {radio} y altura {altura} es: {volumen}");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

                Console.WriteLine("\nPresione cualquier tecla para salir...");
                Console.ReadKey();
            }

            static double CalcularAreaCirculo(double radio)
            {
                return Math.PI * Math.Pow(radio, 2);
            }

            static double CalcularVolumenCilindro(double radio, double altura)
            {
                double areaBase = CalcularAreaCirculo(radio); 
                return areaBase * altura;
            }
        }
    }
