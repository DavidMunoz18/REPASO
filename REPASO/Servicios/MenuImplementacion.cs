using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1. Dar de alta una actividad");
            Console.WriteLine("2. Mostrar una actividad");
            Console.WriteLine("3. Eliminar una actividad");
            Console.WriteLine("-------------------------------------------");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
            
        }
    }
}
