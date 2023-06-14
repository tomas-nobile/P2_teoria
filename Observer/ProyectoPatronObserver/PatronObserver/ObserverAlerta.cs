﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public class ObserverAlerta : IObserver
    {
        #region Constantes

        // Niveles minimos y maximos
        private static readonly int MIN_ACEITE = 12;
        private static readonly int MAX_ACEITE = 45;

        private static readonly int MIN_AGUA = 300;
        private static readonly int MAX_AGUA = 550;

        private static readonly int MIN_PRESION = 120;
        private static readonly int MAX_PRESION = 350;

        #endregion

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
        public ObserverAlerta(ISubject subject)
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

            // Si es del tipo esperado (int[]) y del tamano esperado (3), actualizamos los
            // atributos, pues tenemos 3 estados: nivelAceite, nivelAgua y nivelPresionNeumaticos
            if ((arrayInt != null) && (arrayInt.Length == 3))
            {
                nivelAceite = arrayInt[0];
                nivelAgua = arrayInt[1];
                nivelPresionNeumaticos = arrayInt[2];

                // Comprobamos que los valores no exceden los limites
                ComprobarAceite();
                ComprobarAgua();
                ComprobarNeumaticos();
            }

        }

        #endregion

        // Metodo que comprueba los niveles de aceite
        private void ComprobarAceite()
        {
            if (nivelAceite < MIN_ACEITE)
            {
                EnviarAlerta();
                Console.WriteLine($"NIVEL DE ACEITE DEMASIADO BAJO: {nivelAceite}/{MIN_ACEITE}");
            }
            if (nivelAceite > MAX_ACEITE)
            {
                EnviarAlerta();
                Console.WriteLine($"NIVEL DE ACEITE DEMASIADO ALTO: {nivelAceite}/{MAX_ACEITE}");
            }
        }

        // Metodo que comprueba los niveles de agua
        private void ComprobarAgua()
        {
            if (nivelAgua < MIN_AGUA)
            {
                EnviarAlerta();
                Console.WriteLine($"NIVEL DE AGUA DEMASIADO BAJO: {nivelAgua}/{MIN_AGUA}");
            }
            if (nivelAgua > MAX_AGUA)
            {
                EnviarAlerta();
                Console.WriteLine($"NIVEL DE AGUA DEMASIADO ALTO: {nivelAgua}/{MAX_AGUA}");
            }
        }

        // Metodo que comprueba la presion de los neumaticos
        private void ComprobarNeumaticos()
        {
            if (nivelPresionNeumaticos < MIN_PRESION)
            {
                EnviarAlerta();
                Console.WriteLine($"NIVEL DE PRESION DE NEUMATICOS DEMASIADO BAJO: {nivelPresionNeumaticos}/{MIN_PRESION}");
            }
            if (nivelPresionNeumaticos > MAX_PRESION)
            {
                EnviarAlerta();
                Console.WriteLine($"NIVEL DE PRESION DE NEUMATICOS DEMASIADO ALTO: {nivelPresionNeumaticos}/{MAX_PRESION}");
            }
        }

        // Metodo que envie la alerta
        private void EnviarAlerta()
        {
            // Este metodo podrÍa enviar una alerta a la centralita del vehÍculo que, por ejemplo,
            // forzaría su detencion
            Console.WriteLine("ALERTA!!");
        }
    }
}