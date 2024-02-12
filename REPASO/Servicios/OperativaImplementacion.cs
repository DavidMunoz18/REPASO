using REPASO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void borrarActividad(List<ClienteDto> listaActividad)
        {
            if(listaActividad.Count > 0)
            {
                

                foreach(ClienteDto cliente2 in listaActividad)
                {
                    Console.WriteLine("Nombre actividad: "+ cliente2.NombreActividad);
                    Console.WriteLine("Duracion actividad: " + cliente2.Duracion.TotalMinutes);
                }

                Console.WriteLine("Introduzca la actividad a borrar");
                string clienteBorrar = Console.ReadLine();

                foreach(ClienteDto cliente in listaActividad)
                {

                    if(clienteBorrar.Equals(cliente.NombreActividad))
                    {
                        listaActividad.Remove(cliente);
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("No hay ninguna actividad creada");
            }
        }

        public void buscarActividad(List<ClienteDto> listaActividad)
        {
            if(listaActividad.Count > 0)
            {
                Console.WriteLine("Ingrese una actividad a buscar");
                string actividadBuscar = Console.ReadLine();
                foreach(ClienteDto cliente in listaActividad)
                {
                    if(actividadBuscar.Equals(cliente.NombreActividad))
                    {
                        Console.WriteLine("LA ACTIVIDAD EXISTE");
                        Console.WriteLine("Nombre: "+ cliente.NombreActividad);
                        Console.WriteLine("Fecha Inicio: "+ cliente.FechaInicio);
                        Console.WriteLine("Fecha Fin: "+ cliente.FechaFin);
                        Console.WriteLine("Duracion (minutos): "+ cliente.Duracion.TotalMinutes.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay ninguna actividad creada");
            }
        }

        public void darAltaActividad(List<ClienteDto> listaActividad)
        {
            ClienteDto cliente = crearNuevaActividad();

            listaActividad.Add(cliente);
        }
        private ClienteDto crearNuevaActividad()
        {
            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Ingresa el nombre de la actividad");
            cliente.NombreActividad = Console.ReadLine();

            Console.WriteLine("Ingresa la fecha de inicio y hora (dd/MM/yyyy:HHTmm) de la actividad");
            cliente.FechaInicio = Convert.ToDateTime(Console.ReadLine());
            

            DateTime fechafin = DateTime.Now;
            Console.WriteLine("Fecha de fin:" + fechafin);
            cliente.FechaFin = fechafin;

            TimeSpan duracion = cliente.FechaFin - cliente.FechaInicio;
            Console.WriteLine("Duracion actividad: " + duracion.TotalMinutes);
            cliente.Duracion = duracion;
            return cliente;
        }
    }
}
