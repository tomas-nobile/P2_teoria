using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_ResponsabilidaUnica
{
    public class FacturaImpresion
    {
        private Factura _factura;

        public FacturaImpresion(Factura factura)
        {
            _factura = factura;
        }

        public void Imprimir()
        {
            // En nuestro ejemplo, imprime la factura.
            Console.WriteLine(_factura.Cantidad + "x " + _factura.Libro.Nombre + " " + _factura.Libro.Precio + " $");
            Console.WriteLine("Tasa de Descuento: " + _factura.TasaDescuento);
            Console.WriteLine("Tasa de Impuesto: " + _factura.TasaImpuesto);
            Console.WriteLine("Total: " + _factura.Total + " $");
        }
    }
}
