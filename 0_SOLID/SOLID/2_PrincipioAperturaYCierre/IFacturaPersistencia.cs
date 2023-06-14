using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_PrincipioAperturaYCierre
{
    public interface IFacturaPersistencia
    {
        public void Guardar(Factura factura);
    }
}
