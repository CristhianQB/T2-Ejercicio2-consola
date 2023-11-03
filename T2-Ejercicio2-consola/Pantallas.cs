using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Ejercicio2_consola
{
    public class Pantallas
    {
        public static string []nombres = new string[20]; 
        public static int []notas = new int[20];

        public static int maximo = 0;
        
        public static int pantallaPrincipal()
        {
            Console.Clear();
            Console.Write("==========================\n" +
                "Notas de estudiantes\n" +
                "=========================\n" +
                "1: Ingresar nota\n" +
                "2: Nota más alta\n" +
                "3: Nota más baja\n" +
                "4: Ver lista de Estudiantes\n" +
                "==================================\n");
                return opcionPrincipal("Ingresa una opción: ");

        }

        public static int ingresarNota()
        {
            Console.Clear();
            Console.Write("=========================\n" +
                "Ingresar Nota\n" +
                "==========================\n");
                string texto1 = "Ingrese el nombre: ";
                Console.Write(texto1);
                nombres[maximo] = Console.ReadLine();
                

                string texto2 = "Ingrese la nota: ";
                Console.Write(texto2);
                notas[maximo] = int.Parse(Console.ReadLine());
                maximo++;

                string texto3 ="=========================\n" +
                "¡Guardado!\n" +
                "=========================\n" +
                "1: Agregar uno más | 2: Volver \n"+
                "=========================\n";
                Console.Write(texto3);
                int opcion = opcionPrincipal("> ");
                if (opcion == 2) return 0;
            return opcion;
        }

        public static int notaAlta()
        {
            int numeroMayor = notas[0];
            int orden = 0;
            for (int i = 1; i < maximo; i++)
            {
                if (notas[i] > numeroMayor)
                {
                    numeroMayor = notas[i];
                    orden = i;
                }
            }
           

            Console.Clear();
            Console.Write("==========================\n" +
                "Nota más alta \n" +
                "==========================\n" +
                "Estudiante: " + nombres[orden] +"\n" +
                "Nota: " + numeroMayor +" \n" +
                "==========================\n" +
                "Presione enter para volver\n"+
                "==========================\n" +
                ">");
            Console.ReadKey();
            return pantallaPrincipal();
        }


         public static int notaBaja()
        {
            int numeroMenor = notas[0];
            int orden = 0;
            for (int i = 1; i < maximo; i++)
            {
                if (notas[i] < numeroMenor)
                {
                    numeroMenor = notas[i];
                    orden = i;
                }
            }

            Console.Clear();
            Console.Write("==========================\n" +
                "Nota más baja \n" +
                "==========================\n" +
                "Estudiante: "+nombres[orden]+"\n" +
                "Nota: " + numeroMenor +"\n" +
                "==========================\n" +
                "Presione enter para volver\n" +
                "==========================\n"+
                ">");
            Console.ReadKey();
            return pantallaPrincipal();
        }

        public static int listaEstudiantes() 
        {
            Console.Clear();
            Console.Write("==========================\n" +
                "Lista de estudiantes\n" +
                "==========================\n");
            for (int i = 0; i < maximo; i++)
            {
                Console.WriteLine(nombres[i]+ "\t"+ notas[i]);
            }

            Console.Write("==========================\n"+
                "Presione enter para volver\n" +
                ">");
            Console.ReadKey();
            return pantallaPrincipal();
        }


        public static int opcionPrincipal(string Texto)
        {
            Console.Write(Texto);
            return int.Parse(Console.ReadLine());
        }
    }
}
