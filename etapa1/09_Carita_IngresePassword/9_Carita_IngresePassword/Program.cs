using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Carita_IngresePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña = "papucho" ;

            Console.WriteLine("ingrese su contraseña");
            string ContraseñaDeUsuario = Console.ReadLine();

            if (ContraseñaDeUsuario == contraseña || ContraseñaDeUsuario == "papucho")
            {
                Console.WriteLine("La contra es correcta");
            }
             
            
            else
            {
                    Console.WriteLine("la contra es incorrecta");


            }
            Console.ReadKey();

        }
    }
}