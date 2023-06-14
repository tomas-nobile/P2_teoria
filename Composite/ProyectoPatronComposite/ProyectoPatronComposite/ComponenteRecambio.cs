using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPatronComposite
{
    public abstract class ComponenteRecambio
    {
        #region Métodos comunes a objetos compuestos y hojas

        //Atributo Nombre
        public virtual string getNombre()
        {
            throw new NotSupportedException(this.GetType().Name + "getNombre()");
        }

        public virtual void setNombre(string nombre)
        {
            throw new NotSupportedException(this.GetType().Name + "setNombre()");
        }

        //Atributo Descripcion
        public virtual string getDescripcion()
        {
            throw new NotSupportedException(this.GetType().Name + "getDescripcion()");
        }

        public virtual void setDescripcion(string descripcion)
        {
            throw new NotSupportedException(this.GetType().Name + "setDescripcion()");
        }

        //Atributo Precio
        public virtual double getPrecio()
        {
            throw new NotSupportedException(this.GetType().Name + "getPrecio()");
        }

        public virtual void setPrecio(double precio)
        {
            throw new NotSupportedException(this.GetType().Name + "setPrecio()");
        }

        #endregion

        #region Métodos exclusivos de los objetos compuestos

        // Equivale a agregar un componente para el objeto compuesto
        public virtual void add(ComponenteRecambio componente)
        {
            throw new NotSupportedException(this.GetType().Name + "add()");
        }

        // Equivale a eliminar un componente del objeto compuesto
        public virtual void remove(ComponenteRecambio componente)
        {
            throw new NotSupportedException(this.GetType().Name + "remove()");
        }

        // Equivale a obtener un componente
        public virtual ComponenteRecambio getElemento(int indice)
        {
            throw new NotSupportedException(this.GetType().Name + "getElemento()");
        }

        #endregion
    }
}
