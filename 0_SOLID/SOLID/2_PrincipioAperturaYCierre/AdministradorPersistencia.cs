using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_PrincipioAperturaYCierre
{
    public class AdministradorPersistencia
    {
        IFacturaPersistencia facturaPersistencia;
        ILibroPersistencia libroPersistencia;

        public AdministradorPersistencia(IFacturaPersistencia facturaPersistencia, ILibroPersistencia libroPersistencia)
        {
            this.facturaPersistencia = facturaPersistencia;
            this.libroPersistencia = libroPersistencia;
        }
    }
}
