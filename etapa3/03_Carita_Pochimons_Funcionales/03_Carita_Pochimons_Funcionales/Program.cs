using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Carita_Pochimons_Funcionales
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            int conteo = 0;
            int MaxP = 75;
            string[,] pochidex = new string[MaxP, 5];
            while (opcion != 9)
            {
                Console.Write("-----------------------------------------------------\nMenú Principal - Centro de Investigación de Pochimons\n-----------------------------------------------------\n");
                Console.WriteLine("Pochimones Encontrados: " + conteo + "/" + MaxP + "\n");
                Console.WriteLine("1- Registrar Pochimon ");
                Console.WriteLine("2- Asignar Investigador a Pochimon ");
                Console.WriteLine("3- Actualizar Nivel de Pochimon ");
                Console.WriteLine("4- Marcar Pochimon como Investigado ");
                Console.WriteLine("5- Mostrar Información de Pochimons ");
                Console.WriteLine("6- Buscar Pochimons por Tipo ");
                Console.WriteLine("7- Mostrar Pochimons por Investigador ");
                Console.WriteLine("8- Mostrar Pochimons Picados ");
                Console.WriteLine("9- Salir ");
                Console.Write("-----------------------------------------------------");
                Console.WriteLine();
                Console.Write("Ingrese la opción deseada:");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        if (conteo == MaxP)
                        {
                            Console.WriteLine("La Pochidex está llena.");
                            break;
                        }

                        Console.Write("Ingrese el nombre del Pochimon: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el tipo del Pochimon (Agua/Fuego/Planta): ");
                        string tipo = Console.ReadLine();
                        Console.Write("Ingrese el nivel del Pochimon: ");
                        string nivel = Console.ReadLine();


                        while (conteo < MaxP)
                        {


                            pochidex[conteo, 0] = nombre;
                            pochidex[conteo, 1] = tipo;
                            pochidex[conteo, 2] = nivel;
                            pochidex[conteo, 3] = "0"; //estado,,
                            pochidex[conteo, 4] = "0"; //investigador,,
                            conteo++;
                            Console.WriteLine("Pochimon registrado exitosamente.");
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        }
                        break;

                    case 2:
                        int conteo4 = 0;
                        Console.WriteLine("Pochimons no investigados:");
                        Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|");
                        while (conteo4 < conteo)
                        {
                            if (pochidex[conteo4, 3] != "1" && pochidex[conteo4, 3] != "2")
                            {
                                Console.WriteLine("|" + conteo4 + "| " + pochidex[conteo4, 0] + "\t|" + pochidex[conteo4, 1] + "\t|" + pochidex[conteo4, 2] + "\t|" + pochidex[conteo4, 3] + "\t|" + pochidex[conteo4, 4] + "\t" + "\t" + "\t|");
                            }
                            conteo4++;
                        }

                        Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
                        int fila2 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el código del Investigador: ");
                        string investigador = Console.ReadLine();

                        if (fila2 < MaxP)
                        {
                            pochidex[fila2, 4] = investigador;
                            pochidex[fila2, 3] = "1";
                            Console.WriteLine("Investigador asignado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("Fila no válida o Pochimon ya investigado.");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        int conteo3 = 0;
                        Console.WriteLine("Pochimons registrados:");
                        Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|");
                        while (conteo3 < conteo)
                        {
                            Console.WriteLine("|" + conteo3 + "| " + pochidex[conteo3, 0] + "\t|" + pochidex[conteo3, 1] + "\t|" + pochidex[conteo3, 2] + "\t|");
                            conteo3++;
                        }

                        Console.Write("Ingrese el número de fila del Pochimon a actualizar: ");
                        int fila = int.Parse(Console.ReadLine());

                        if (fila < MaxP)
                        {

                            Random level = new Random();
                            int incremento = level.Next(1, 3);

                            pochidex[fila, 2] = (int.Parse(pochidex[fila, 2]) + incremento).ToString();
                            Console.WriteLine("Nivel actualizado exitosamente. Ahora es nivel " + pochidex[fila, 2]);
                        }
                        else
                        {
                            Console.WriteLine("Fila no válida.");
                        }
                        Console.ReadLine();
                        Console.Clear();

                        break;

                    case 4:
                        int conteo5 = 0;
                        Console.WriteLine("Pochimons siendo investigados:");
                        Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|");
                        while (conteo5 < conteo)
                        {
                            if (pochidex[conteo5, 3] == "1")
                            {
                                Console.WriteLine("|" + conteo5 + "|" + pochidex[conteo5, 0] + "\t|" + pochidex[conteo5, 1] + "\t|" + pochidex[conteo5, 2] + "\t|" + pochidex[conteo5, 3] + "\t|" + pochidex[conteo5, 4] + "\t" + "\t" + "\t|");
                            }
                            conteo5++;
                        }

                        Console.Write("Ingrese el número de fila del Pochimon que ha sido Investigado: ");
                        int fila3 = int.Parse(Console.ReadLine());


                        if (fila3 < MaxP)
                        {

                            pochidex[fila3, 3] = "2";
                            Console.WriteLine("Quedo registrado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("Fila no válida.");
                        }
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case 5:
                        int conteo2 = 0;
                        Console.WriteLine("5- Mostrar Información de Pochimons \n");
                        Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|");
                        while (conteo2 < conteo)
                        {

                            Console.WriteLine("|" + conteo2 + "| " + pochidex[conteo2, 0] + "\t|" + pochidex[conteo2, 1] + "\t|" + pochidex[conteo2, 2] + "\t|" + pochidex[conteo2, 3] + "\t|" + pochidex[conteo2, 4] + "\t" + "\t" + "\t|");
                            conteo2++;
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        int conteo6 = 0;
                        Console.WriteLine("Ingrese el tipo de Pochimon a buscar (Agua/Fuego/Planta):");
                        string tipos = Console.ReadLine();
                        Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|");
                        while (conteo6 < conteo)
                        {
                            if (pochidex[conteo6, 1] == tipos)
                            {
                                Console.WriteLine("|" + conteo6 + "| " + pochidex[conteo6, 0] + "\t|" + pochidex[conteo6, 1] + "\t|" + pochidex[conteo6, 2] + "\t|" + pochidex[conteo6, 3] + "\t|" + pochidex[conteo6, 4] + "\t" + "\t" + "\t|");

                            }
                            conteo6++;
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        int conteo7 = 0;
                        Console.WriteLine("Ingrese el código del Investigador: ");
                        string inve = Console.ReadLine();
                        Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|");
                        while (conteo7 < conteo)
                        {
                            if (pochidex[conteo7, 4] == inve)
                            {
                                Console.WriteLine("|" + conteo7 + "|" + pochidex[conteo7, 0] + "\t|" + pochidex[conteo7, 1] + "\t|" + pochidex[conteo7, 2] + "\t|" + pochidex[conteo7, 3] + "\t|" + pochidex[conteo7, 4] + "\t" + "\t" + "\t|");

                            }
                            conteo7++;
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        int conteo8 = 0;
                        Console.WriteLine("Pochimons picados: ");
                        Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|");
                        while (conteo8 < conteo)
                        {
                            if (int.Parse(pochidex[conteo8, 2]) >= 30)
                            {
                                Console.WriteLine("|" + conteo8 + "| " + pochidex[conteo8, 0] + "\t|" + pochidex[conteo8, 1] + "\t|" + pochidex[conteo8, 2] + "\t|");

                            }
                            conteo8++;
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 9:
                        Console.WriteLine("9- Salir");

                        break;

                }
            }
            Console.WriteLine("Chauchis :D");
            Console.ReadKey();

        }
    }
}
