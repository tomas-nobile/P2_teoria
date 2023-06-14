using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_ResponsabilidaUnica
{
    public class FacturaPersistencia
    {
        Factura _factura;

        public FacturaPersistencia(Factura factura)
        {
            _factura = factura;
        }

        public void guardarArchivo(String nombreArchivo)
        {
            // Crea un archivo con el nombre dado y graba la factura.
        }
    }
}
