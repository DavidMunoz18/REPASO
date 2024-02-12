using REPASO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO.Servicios
{
    internal interface OperativaInterfaz
    {
        public void darAltaActividad(List<ClienteDto> listaActividad);

        public void buscarActividad(List<ClienteDto> listaActividad);

        public void borrarActividad(List<ClienteDto> listaActividad);
    }
}
