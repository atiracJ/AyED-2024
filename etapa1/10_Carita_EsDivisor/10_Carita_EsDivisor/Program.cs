using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Carita_EsDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("ingrese un segundo numero");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            if (numero2 == 0)
            {
                Console.WriteLine("error no se puede dividir por 0");
            }

            else

            {
                double division = numero1 / numero2;
                Console.WriteLine("resultado de la division es" + division);
            }

            Console.ReadKey();
        }
    }
}
