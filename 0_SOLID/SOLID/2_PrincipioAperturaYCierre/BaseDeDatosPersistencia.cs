using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_PrincipioAperturaYCierre
{
    public class BaseDeDatosPersistencia : IFacturaPersistencia
    {

       public void Guardar(Factura factura)
        {
            // Guardar en la base de datos
            throw new NotImplementedException();
        }
    }
}
