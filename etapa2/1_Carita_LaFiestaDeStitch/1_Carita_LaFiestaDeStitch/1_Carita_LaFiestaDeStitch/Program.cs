using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Carita_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Ingrese la cantidad de invitados a la fiesta:");
            int cantidadInvitados = ObtenerNumeroEntreRango(1, 100);

            int sumaComida = 0;

            for (int i = 1; i <= cantidadInvitados; i++)
            {
                Console.WriteLine("Ingrese la cantidad de comida que consume el invitado nro" + i + ":");
                int cantidadComida = ObtenerNumeroEntreRango(1, 100);
                sumaComida += cantidadComida;
            }

            double promedioComidaPorInvitado = (double)sumaComida / cantidadInvitados;
            Console.WriteLine("El promedio de comida por invitado es: " + promedioComidaPorInvitado.ToString("0.##"));
            Console.ReadKey();
        }

        static int ObtenerNumeroEntreRango(int minimo, int maximo)
        {
            int numero;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero >= minimo && numero <= maximo)
                    {
                        return numero;
                    }
                }

                Console.WriteLine("Error: Ingrese un número válido entre " + minimo + " y " + maximo + ":");
            }

        }
    }
}
