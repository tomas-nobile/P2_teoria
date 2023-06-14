using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPatronComposite
{
    public class ElementoRecambio : ComponenteRecambio
    {
        // Atributos propios del nodo hoja.
        private string nombre;
        private string descripcion;
        private double precio;

        // Constructor
        public ElementoRecambio(string nombre, string descripcion, double precio)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        // Sobrecargamos únicamente los métodos propios de los nodos hoja, destinados
        // a devolver la información y a asignarla

        // NOMBRE
        public override string getNombre()
        {
            return nombre;
        }

        public override void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        // DESCRIPCION
        public override string getDescripcion()
        {
            return descripcion;
        }

        public override void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        // PRECIO
        public override double getPrecio()
        {
            return precio;
        }

        public override void setPrecio(double precio)
        {
            this.precio = precio;
        }

        // Los métodos add, remove y getElemento no se sobrecargarán, ya que
        // el nodo hoja no estará compuesto por más elementos que él mismo.
        // Por tanto, si se invocan estos métodos, se llamará el método padre
        // que lanzará una excepción de tipo NotSupportedException
    }
}
