using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Carita_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la cantidad de trabajos prácticos (TPs):");
            int cantidadTPs = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de exámenes:");
            int cantidadExamenes = int.Parse(Console.ReadLine());

            int[] notasTPs = new int[cantidadTPs];
            int[] notasExamenes = new int[cantidadExamenes];


            Console.WriteLine("Ingrese las notas de los TPs:");
            for (int i = 0; i < cantidadTPs; i++)
            {
                Console.Write("Nota TP " + (i + 1) + ": ");
                notasTPs[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese las notas de los exámenes:");
            for (int i = 0; i < cantidadExamenes; i++)
            {
                Console.Write("Nota Examen " + (i + 1) + ": ");
                notasExamenes[i] = int.Parse(Console.ReadLine());
            }

            double sumaExamenes = 0;
            for (int i = 0; i < cantidadExamenes; i++)
            {
                sumaExamenes += notasExamenes[i];
            }
            double promedioExamenes = sumaExamenes / cantidadExamenes;

            int tpsAprobados = 0;
            for (int i = 0; i < cantidadTPs; i++)
            {
                if (notasTPs[i] >= 6)
                {
                    tpsAprobados++;
                }
            }
            double porcentajeTPsAprobados = (double)tpsAprobados / cantidadTPs * 100;

            bool apruebaMateria = promedioExamenes >= 6 && porcentajeTPsAprobados >= 75;

            if (apruebaMateria)
            {
                Console.WriteLine("Phineas y Ferb pueden aprobar la materia");
            }
            else
            {
                Console.WriteLine("Phineas y Ferb NO pueden aprobar la materia");
            }
            Console.ReadKey();
        }
    }
}
