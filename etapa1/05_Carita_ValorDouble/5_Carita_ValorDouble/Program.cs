using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Carita_ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el ancho del rectángulo:");
            double ancho;
            Console.ReadLine();

            Console.WriteLine("Ingrese la altura del rectángulo:");
            double altura;
            Console.ReadLine();

            double perimetro = 2 * (ancho + altura);

            double area = ancho * altura;

            double diagonal = Math.Sqrt(ancho * ancho + altura * altura);

            Console.WriteLine("El perímetro del rectángulo es: " + perimetro);
            Console.WriteLine("El área del rectángulo es: " + area);
            Console.WriteLine("La diagonal del rectángulo es: " + diagonal);


            Console.ReadKey();


        }
    }
}
