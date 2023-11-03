using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Ejercicio2_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.pantallaPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = Pantallas.pantallaPrincipal();
                        break;
                    case 1:
                        opcion = Pantallas.ingresarNota();
                        break;
                    case 2:
                        opcion = Pantallas.notaAlta();
                        break;
                    case 3:
                        opcion = Pantallas.notaBaja();
                        break;
                    case 4:
                        opcion = Pantallas.listaEstudiantes();
                        break;

                }
            } while (opcion != 5);
        }
    }
}
