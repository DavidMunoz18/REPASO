using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO.Dtos
{
    internal class ClienteDto
    {
        long idActividad;
        string nombreActividad = "aaaaa";
        DateTime fechaInicio = Convert.ToDateTime("31/12/9999");
        DateTime fechaFin;
        DateTime hora;
        TimeSpan duracion;

        public long IdActividad { get => idActividad; set => idActividad = value; }
        public string NombreActividad { get => nombreActividad; set => nombreActividad = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public TimeSpan Duracion { get => duracion; set => duracion = value; }

        public ClienteDto()
        {
        }

        public ClienteDto(long idActividad, string nombreActividad, DateTime fechaInicio, DateTime fechaFin, TimeSpan duracion)
        {
            this.idActividad = idActividad;
            this.nombreActividad = nombreActividad;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            
            this.duracion = duracion;
        }
    }
}
