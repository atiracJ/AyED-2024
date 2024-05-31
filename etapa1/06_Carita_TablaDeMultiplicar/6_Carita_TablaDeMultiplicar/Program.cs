using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Carita_TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ingresa cualquier numero ");
            string numero = Console.ReadLine();

            int num1 = int.Parse(numero);

            int res1 = num1 * 1;
            int res2 = num1 * 2;
            int res3 = num1 * 3;
            int res4 = num1 * 4;
            int res5 = num1 * 5;
            int res6 = num1 * 6;
            int res7 = num1 * 7;
            int res8 = num1 * 8;
            int res9 = num1 * 9;
            int res10 = num1 * 10;

            Console.WriteLine("multiplicado 1 es = " + res1);
            Console.WriteLine("multiplicado 2 es = " + res2);
            Console.WriteLine("multiplicado 3 es = " + res3);
            Console.WriteLine("multiplicado 4 es = " + res4);
            Console.WriteLine("multiplicado 5 es = " + res5);
            Console.WriteLine("multiplicado 6 es = " + res6);
            Console.WriteLine("multiplicado 7 es = " + res7);
            Console.WriteLine("multiplicado 8 es = " + res8);
            Console.WriteLine("multiplicado 9 es = " + res9);
            Console.WriteLine("multiplicado 10 es = " + res10);




            Console.ReadKey();
        }
    }
}
