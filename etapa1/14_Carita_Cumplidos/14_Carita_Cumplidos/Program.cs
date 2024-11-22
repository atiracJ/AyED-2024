using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Carita_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su edad" );
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("has cumplido los siguientes años");
            int contador = 1;
            while (contador <= edad)
            { Console.WriteLine(contador);
                contador++;
            }


            Console.ReadKey();
        }
    }
}
