using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Carita_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                Console.Write("Ingrese la cantidad de productos vendidos: ");
                int[] productos = new int[int.Parse(Console.ReadLine())];

                int precio = 0, precio1;

                for (int i = 0; i < productos.Count(); i++)
                {
                    Console.Write("Ingrese el precio del producto " + i + ": ");
                    precio = int.Parse(Console.ReadLine());
                    productos[i] = precio;
                }
                precio = productos[0];
                precio1 = productos[0];
                for (int j = 1; j < productos.Count(); j++)
                {
                    if (precio < productos[j])
                    {
                        precio = productos[j];
                    }
                    if (precio1 > productos[j])
                    {
                        precio1 = productos[j];
                    }
                }
                Console.WriteLine("El precio más alto de los productos fue: " + precio);
                Console.WriteLine("El precio más bajo de los productos fue: " + precio1);

                Console.ReadKey();
            }
        }
    }


}