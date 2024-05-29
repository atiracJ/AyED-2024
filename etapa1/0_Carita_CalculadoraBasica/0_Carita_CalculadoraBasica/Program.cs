using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Carita_CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduce el primer número:");
            string num1I = Console.ReadLine();
            Console.WriteLine("Introduce el segundo número:");
            string num2I = Console.ReadLine();


            int num1 = int.Parse(num1I);
            int num2 = int.Parse(num2I);


            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            int division = num1 / num2;
            int resto = num1 % num2; 

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Multiplicación: " + multiplicacion);
            Console.WriteLine("División: " + division);
            Console.WriteLine("Resto de la división: " + resto);

            Console.ReadKey();
        }
    }


}
