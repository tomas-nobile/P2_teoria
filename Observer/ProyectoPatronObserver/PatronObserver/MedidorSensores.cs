using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public class MedidorSensores : ISubject
    {
        #region Estado

        // Atributos que modelan el estado
        private int nivelAceite;
        private int nivelAgua;
        private int nivelPresionNeumaticos;

        #endregion

        // Listado de observers
        IList suscriptores;

        #region Properties

        public int NivelAceite
        {
            get { return this.nivelAceite; }

            // Cada vez que se modifique el estado, se invocara el metodo NotificarObservers()
            // Se controla si el nuevo estado del nivel de aceite es distinto del actual
            set
            {
                if (this.nivelAceite != value)
                {
                    this.nivelAceite = value;
                    NotificarObservers();
                }
            }
        }

        public int NivelAgua
        {
            get { return this.nivelAgua; }

            // Cada vez que se modifique el estado, se invocara el metodo NotificarObservers()
            // Se controla si el nuevo estado del nivel de agua es distinto del actual
            set
            {
                if (this.nivelAgua != value)
                {
                    this.nivelAgua = value;
                    NotificarObservers();
                }
            }
        }

        public int NivelPresionNeumaticos
        {
            get { return this.nivelPresionNeumaticos; }

            // Cada vez que se modifique el estado, se invocara el metodo NotificarObservers()
            // Se controla si el nuevo estado de la presión de los neumáticos es distinto del actual
            set
            {
                if (this.nivelPresionNeumaticos != value)
                {
                    this.nivelPresionNeumaticos = value;
                    NotificarObservers();
                }
            }
        }

        #endregion

        #region Metodos de la interfaz ISubject

        // Constructor que creara un medidor con los valores iniciales de las presiones
        public MedidorSensores(int nivelAceite, int nivelAgua, int nivelPresionNeumaticos)
        {
            this.suscriptores = new ArrayList();
            this.nivelAceite = nivelAceite;
            this.nivelAgua = nivelAgua;
            this.nivelPresionNeumaticos = nivelPresionNeumaticos;
        }

        // Comprobamos si el observer se encuentra en la lista. En caso contrario,
        // se lo agrega a la lista de suscriptores
        public void RegistrarObserver(IObserver o)
        {
            if (!suscriptores.Contains(o))
                suscriptores.Add(o);
        }

        // Comprobamos si el observer se encuentra en la lista. En caso afirmativo,
        // se lo elimina de la lista  de suscriptores
        public void EliminarObserver(IObserver o)
        {
            if (suscriptores.Contains(o))
                suscriptores.Remove(o);
        }

        // Recorre la lista de observers e invoca su metodo Update()
        public void NotificarObservers()
        {
            // Creamos un array con el estado del Subject
            int[] valores = { this.nivelAceite, this.nivelAgua, this.nivelPresionNeumaticos };

            // Recorremos todos los objetos suscritos (observers)
            IObserver observer;
            foreach (Object o in suscriptores)
            {
                // Invocamos el metodo Update de cada observer, pasandole el array con el estado
                // del subject como parametro.
                // Cada observer ya hara lo que estime necesario con esa informacion.
                observer = (IObserver)o;
                observer.update(valores);
            }
        }

        #endregion
    }
}