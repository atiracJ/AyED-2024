using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Carita_ABM_DibuAventuras
{
    using System;
        class Program
        {
            struct Personaje
            {
                public string Nombre;
                public string Serie;
                public int Fuerza;
                public int Defensa;
                public bool EsHeroe;
            }

            static Personaje[] personajes = new Personaje[20];
            static int cantidadPersonajes = 0;

            static void Main(string[] args)
            {
                bool continuar = true;
                Console.WriteLine("¡vamos a crear un personaje!");

                while (continuar)
                {
                    Console.WriteLine("Menú de opciones:");
                    Console.WriteLine("1. Agregar un nuevo personaje.");
                    Console.WriteLine("2. Consultar personaje por nombre.");
                    Console.WriteLine("3. Modificar atributos de un personaje.");
                    Console.WriteLine("4. Eliminar un personaje.");
                    Console.WriteLine("5. Mostrar todos los personajes ordenados.");
                    Console.WriteLine("6. Salir.");
                    Console.Write("Seleccione una opción: ");
                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            AgregarPersonaje();
                            break;
                        case 2:
                            ConsultarPersonaje();
                            break;
                        case 3:
                            ModificarPersonaje();
                            break;
                        case 4:
                            EliminarPersonaje();
                            break;
                        case 5:
                            MostrarPersonajes();
                            break;
                        case 6:
                            Console.WriteLine("¡Gracias por usar el programa! Hasta luego.");
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                }
            }

            static void AgregarPersonaje()
            {
                if (cantidadPersonajes >= 20)
                {
                    Console.WriteLine("No se pueden agregar más personajes. La lista está llena.");
                    return;
                }

                Console.Write("Ingrese el nombre del personaje: ");
                string nombre = Console.ReadLine();

                foreach (var p in personajes)
                {
                    if (p.Nombre == nombre)
                    {
                        Console.WriteLine("El personaje ya existe. Intente con otro nombre.");
                        return;
                    }
                }

                Console.Write("Ingresa la serie del personaje: ");
                string serie = Console.ReadLine();
                Console.Write("Ingresa la fuerza del personaje: ");
                int fuerza = int.Parse(Console.ReadLine());
                Console.Write("Ingresa la defensa del personaje: ");
                int defensa = int.Parse(Console.ReadLine());
                Console.Write("¿Es héroe? (true/false): ");
                bool esHeroe = bool.Parse(Console.ReadLine());

                personajes[cantidadPersonajes] = new Personaje
                {
                    Nombre = nombre,
                    Serie = serie,
                    Fuerza = fuerza,
                    Defensa = defensa,
                    EsHeroe = esHeroe
                };

                cantidadPersonajes++;
                Console.WriteLine("Personaje agregado correctamente.");
            }

            static void ConsultarPersonaje()
            {
                Console.Write("Ingresa el nombre del personaje que desea buscar: ");
                string nombre = Console.ReadLine();

                foreach (var p in personajes)
                {
                    if (p.Nombre == nombre)
                    {
                        Console.WriteLine($"Nombre: {p.Nombre}, Serie: {p.Serie}, Fuerza: {p.Fuerza}, Defensa: {p.Defensa}, Héroe: {p.EsHeroe}");
                        return;
                    }
                }

                Console.WriteLine("Personaje no encontrado.");
            }

            static void ModificarPersonaje()
            {
                Console.Write("Ingresa el nombre del personaje que desea modificar: ");
                string nombre = Console.ReadLine();

                for (int i = 0; i < cantidadPersonajes; i++)
                {
                    if (personajes[i].Nombre == nombre)
                    {
                        Console.Write("Ingresa la nueva fuerza: ");
                        personajes[i].Fuerza = int.Parse(Console.ReadLine());
                        Console.Write("Ingresa la nueva defensa: ");
                        personajes[i].Defensa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Atributos modificados correctamente.");
                        return;
                    }
                }

                Console.WriteLine("Personaje no encontrado.");
            }

            static void EliminarPersonaje()
            {
                Console.Write("Ingresa el nombre del personaje que desea eliminar: ");
                string nombre = Console.ReadLine();

                for (int i = 0; i < cantidadPersonajes; i++)
                {
                    if (personajes[i].Nombre == nombre)
                    {
                        for (int j = i; j < cantidadPersonajes - 1; j++)
                        {
                            personajes[j] = personajes[j + 1];
                        }

                        cantidadPersonajes--;
                        Console.WriteLine("Personaje eliminado correctamente.");
                        return;
                    }
                }

                Console.WriteLine("Personaje no encontrado.");
            }

            static void MostrarPersonajes()
            {
                if (cantidadPersonajes == 0)
                {
                    Console.WriteLine("No hay personajes registrados.");
                    return;
                }

                string[] nombres = new string[cantidadPersonajes];
                for (int i = 0; i < cantidadPersonajes; i++)
                {
                    nombres[i] = personajes[i].Nombre;
                }

                Array.Sort(nombres);

                Console.WriteLine("Lista de personajes ordenados:");
                foreach (var nombre in nombres)
                {
                    foreach (var p in personajes)
                    {
                        if (p.Nombre == nombre)
                        {
                            Console.WriteLine($"Nombre: {p.Nombre}, Serie: {p.Serie}, Fuerza: {p.Fuerza}, Defensa: {p.Defensa}, Héroe: {p.EsHeroe}");
                        }
                    }
                }
            }
        }
    }
