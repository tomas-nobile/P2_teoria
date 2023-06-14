using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//suponga que nuestra librería solo vende libros y nada más.

namespace SOLID._1_ResponsabilidaUnica
{
    public class Factura
    {
        private Libro _libro;
        private int _cantidad;
        private double _tasaDescuento;
        private double _tasaImpuesto;
        private double _total;

        public Factura(Libro libro, int cantidad, double tasaDescuento, double tasaImpuesto)
        {
            _libro = libro;
            _cantidad = cantidad;
            _tasaDescuento = tasaDescuento;
            _tasaImpuesto = tasaImpuesto;
            _total = calcularTotal();
        }

        // Este método SI CUMPLE el Principio de Responsabilidad Unica
        // La única razón para cambiar, es un cambio en el cálculo de la factura para nuestra clase.
        public double calcularTotal()
        {   //método que calcula el precio total

            double precio = ((_libro.Precio - _libro.Precio * _tasaDescuento) * _cantidad);

            double precioConImpuestos = precio * (1 + _tasaImpuesto);

            return precioConImpuestos;
        }

        // Este método NO CUMPLE el Principio de Responsabilidad Unica
        // pues es lógica de impresión y se mezcla con lógica de negocio
        // SOLUCION: Clase FacturaImpresion
        public void imprimirFactura()   
        {   // método que debería imprimir la factura por consola
            Console.WriteLine(_cantidad + "x " + _libro.Nombre + " " + _libro.Precio + "$");
            Console.WriteLine("Tasa de Descuento: " + _tasaDescuento);
            Console.WriteLine("Tasa de Impuesto: " + _tasaImpuesto);
            Console.WriteLine("Total: " + _total);
        }

        // Este método NO CUMPLE el Principio de Responsabilidad Unica
        // pues el lógica de persistencia de datos y se mezcla con lógica de negocio
        public void guardarArchivo(String nombreArchivo)
        {
            // Graba la la factura en un archivo
        }

        //--------------------------------------------------------------------------------
     
        public double TasaDescuento
        {   // Lectura de la tasa de descuento
            get => _tasaDescuento;
        }
        public double TasaImpuesto
        {   // Lectura de la tasa de impuesto
            get => _tasaImpuesto;
        }

        public double Total
        {   // Lectura del total
            get => _total;
        }
        public int Cantidad
        {   // Lectura de la cantidad
            get => _cantidad;
        }

        public Libro Libro
        {   // Lectura del objeto Libro
            get => _libro;
        }
    }
}
