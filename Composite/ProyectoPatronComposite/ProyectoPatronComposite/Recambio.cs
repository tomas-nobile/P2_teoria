using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPatronComposite
{
    public class Recambio : ComponenteRecambio
    {

        // Arraylist que contendrá los elementos hijo
        private ArrayList listaRecambios;

        // Atributos
        private string nombre;
        private string descripcion;
        private double precio;

        // Constructor que recibirá el nombre, el precio y la descripción.
        public Recambio(string nombre, string descripcion, double precio)
        {
            // Instanciamos el ArrayList
            listaRecambios = new ArrayList();

            // Asignamos el nombre, la descripción y el precio
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;

        }

        ///////////////////////////////////////////////////////////////////
        //1era PARTE - Métodos relacionados con el árbol, va agregando/quitando los elementos de la lista

        #region Métodos relacionados con el árbol

        // Añade un nuevo elemento al ArrayList
        public override void add(ComponenteRecambio componente)
        {
            listaRecambios.Add(componente);
        }

        // Elimina un elemento del ArrayList
        public override void remove(ComponenteRecambio componente)
        {
            listaRecambios.Remove(componente);
        }

        // Recupera un elemento del ArrayList
        public override ComponenteRecambio getElemento(int indice)
        {
            return (ComponenteRecambio)listaRecambios[indice];
        }

        #endregion

        ///////////////////////////////////////////////////////////////////
        //2da PARTE - atributos (estilo Java) relacionados con el elemento

        #region Métodos relacionados con el elemento

        public override string getNombre()
        {
            string nombreCompleto = this.nombre + "\n";

            foreach (ComponenteRecambio c in listaRecambios)
            {
                nombreCompleto += c.getNombre() + "\n";
            }
            return nombreCompleto;
        }

        public override string getDescripcion()
        {
            string descripcionCompleta = this.descripcion + "\n";

            foreach (ComponenteRecambio c in listaRecambios)
            {
                descripcionCompleta += c.getDescripcion() + "\n";
            }
            return descripcionCompleta;
        }

        public override double getPrecio()
        {
            double precioTotal = this.precio;

            foreach (ComponenteRecambio c in listaRecambios)
            {
                precioTotal += c.getPrecio();
            }
            return precioTotal;
        }

        #endregion

        //También sobrecargaremos los métodos setNombre, setDescripcion y setPrecio.
        public override void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public override void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public override void setPrecio(double precio)
        {
            this.precio = precio;
        }


    }
}
