using System;

namespace PatronObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            // PRIMERA PARTE //////////////////////////////////////////

            // Creamos un medidor de sensores 
            // con valores iniciales del nivel de aceite, agua y presión de neumáticos
            ISubject sensores = new MedidorSensores(20, 380, 200);

            // Creamos dos observers: un display y un emisor de alertas.
            // Se realiza la suscripcion a traves del constructor
            IObserver display = new ObserverDisplay(sensores);
            IObserver alerta = new ObserverAlerta(sensores);

            // Modificamos valores del subject. Los observers son automáticamente informados
            // y actuarán automaticamente
            ((MedidorSensores)sensores).NivelAceite += 10;
            ((MedidorSensores)sensores).NivelAceite += 10;
            ((MedidorSensores)sensores).NivelAgua += 100;
            ((MedidorSensores)sensores).NivelPresionNeumaticos -= 50;
            ((MedidorSensores)sensores).NivelAceite += 10;
            ((MedidorSensores)sensores).NivelAgua += 100;
            ((MedidorSensores)sensores).NivelAgua += 100;


            // SEGUNDA PARTE //////////////////////////////////////////

            // Eliminamos el registro de las alertas y aumentamos los niveles para comprobar que no
            // son informados
            Console.WriteLine("\nSe elimina la suscripción del OBSERVER ALERTA quedando sólo el OBSERVER DISPLAY\n");
            sensores.EliminarObserver(alerta);
            ((MedidorSensores)sensores).NivelAceite += 10;
            ((MedidorSensores)sensores).NivelAgua += 100;
            ((MedidorSensores)sensores).NivelAgua += 100;






            Console.ReadLine();



        }
    }
}
