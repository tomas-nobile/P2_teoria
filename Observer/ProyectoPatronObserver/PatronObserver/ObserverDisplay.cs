﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public class ObserverDisplay : IObserver
    {
        #region Atributos

        // Atributos que modelan el estado
        private int nivelAceite;
        private int nivelAgua;
        private int nivelPresionNeumaticos;

        // Subject al que se encuentra suscrito el observer
        private ISubject subject;

        #endregion

        #region Constructores

        // El constructor suscribira el observer al subject
        public ObserverDisplay(ISubject subject)
        {
            this.subject = subject;
            subject.RegistrarObserver(this);
        }

        #endregion

        #region Metodos de IObserver

        public void update(object o)
        {
            // Comprobamos el tipo del objeto recibido como parametro
            int[] arrayInt = null;
            if (o.GetType().Equals(typeof(int[])))
                arrayInt = (int[])o;

            // Si es del tipo esperado (int[]) y del tamaño esperado (3), actualizamos los
            // atributos, pues tenemos 3 estados: nivelAceite, nivelAgua y nivelPresionNeumaticos
            if ((arrayInt != null) && (arrayInt.Length == 3))
            {
                nivelAceite = arrayInt[0];
                nivelAgua = arrayInt[1];
                nivelPresionNeumaticos = arrayInt[2];

                // Mostramos por pantalla los valores actuales
                MostrarValores();
            }
        }

        #endregion

        // Metodo que muestra los valores en el display
        private void MostrarValores()
        {
            Console.WriteLine($"Nivel de Aceite: {nivelAceite}");
            Console.WriteLine($"Nivel de Agua: {nivelAgua}");
            Console.WriteLine($"Presion de Neumaticos: {nivelPresionNeumaticos}\n");
        }
    }
}