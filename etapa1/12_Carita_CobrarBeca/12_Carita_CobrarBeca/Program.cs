using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Carita_CobrarBeca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cual es tu edad ");
            int edad = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("ingresa tus activos");
            double ingresos = Convert.ToDouble(Console.ReadLine());

            if (edad > 19 && ingresos >= 100000)

            {
                Console.WriteLine("eres elegible para cobrar la beca");
            }
            else
            {
                Console.WriteLine("no eres elegible pára la beca ");
            }


            Console.ReadKey();
        }
    }
}
