using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CON_State
{
    public class Vehiculo
    {
        #region Atributos

        private IState estado;                 // Estado actual del vehiculo (apagado, parado, en marcha, sin combustible)
        private int velocidadActual = 0;      // Velocidad actual del vehiculo
        private int combustibleActual = 0;    // Cantidad de combustible restante

        #endregion

        #region Properties

        // Asigna o recupera el estado del vehiculo
        public IState Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        // Asigna o recupera la velocidad actual del vehiculo
        public int VelocidadActual
        {
            get { return velocidadActual; }
            set { velocidadActual = value; }
        }

        // Obtiene la cantidad de combustible actual
        public int CombustibleActual
        {
            get { return combustibleActual; }
        }

        #endregion

        #region Constructores

        // El constructor inserta el combustible del que dispondra el vehiculo
        public Vehiculo(int combustible)
        {
            this.combustibleActual = combustible;
        
            //Indicar un estado inicial del vehículo (Apagado)
            estado = new ApagadoState(this);
            
        }

        #endregion

        #region Metodos relacionados con los estados

        // Los metodos del contexto invocaran el metodo de la interfaz State, delegando las operaciones
        // dependientes del estado en las clases que los implementen.
        public void Acelerar()
        {
            estado.Acelerar();
            Console.WriteLine("Velocidad actual: " + velocidadActual + ". Combustible restante: " + combustibleActual);
        }

        public void Frenar()
        {
            estado.Frenar();
        }

        public void Contacto()
        {
            estado.Contacto();
        }

        #endregion

        #region Otros metodos

        public void ModificarVelocidad(int kmh)
        {
            velocidadActual += kmh;
        }

        public void ModificarCombustible(int decilitros)
        {
            combustibleActual += decilitros;
        }

        #endregion
    }
}
