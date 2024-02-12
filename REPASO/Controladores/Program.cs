using REPASO.Dtos;
using REPASO.Servicios;

namespace REPASO.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            List<ClienteDto> listaActividad = new List<ClienteDto>();
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            int opcion;
            bool cerrarMenu = false;
            while(!cerrarMenu)
            {
                opcion = mi.mostrarMenuYSeleccion();
                switch (opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        oi.darAltaActividad(listaActividad);
                        break;
                    case 2:
                        oi.buscarActividad(listaActividad);
                        break;
                    case 3:
                        oi.borrarActividad(listaActividad);
                        break;

                    default:
                        Console.WriteLine("La opcion seleccionada no existe");
                        break;
                }
            }
        }
    }
}