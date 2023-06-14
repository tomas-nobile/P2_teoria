using System;

namespace PatronCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos los objetos cuyos métodos serán encapsulados dentro de
            // objetos que implementan ICommand
            LucesReceiver lucesPosicion = new LucesPosicion();
            LucesReceiver lucesCortas = new LucesCortas();
            LucesReceiver lucesLargas = new LucesLargas();


            // Creamos los objetos Command que encapsulan los métodos de las clases anteriores
            ICommand encenderLucesPosicion = new EncenderLucesCommand(lucesPosicion);
            ICommand apagarLucesPosicion = new ApagarLucesCommand(lucesPosicion);

            ICommand encenderLucesCortas = new EncenderLucesCommand(lucesCortas);
            ICommand apagarLucesCortas = new ApagarLucesCommand(lucesCortas);

            ICommand encenderLucesLargas = new EncenderLucesCommand(lucesLargas);
            ICommand apagarLucesLargas = new ApagarLucesCommand(lucesLargas);


            // Creamos un nuevo Invoker (el objeto que será desacoplado de las luces)
            IInvoker invoker = new ControladorLucesInvoker();

            // Le asociamos los objetos Command y los ejecutamos
            // El objeto invoker invoca el método 'Execute()' sin saber en ningún momento
            // qué es lo que se está ejecutando realmente.
            invoker.SetCommand(encenderLucesPosicion);      // Asociamos el ICommand
            invoker.Invoke();                          // Hacemos que se ejecute ICommand.Execute()

            // Realizamos lo mismo con el resto de instancias que implementan ICommand.
            // Como podemos ver, el ICommand puede asignarse en tiempo de ejecucion
            invoker.SetCommand(apagarLucesPosicion);
            invoker.Invoke();

            // Luces cortas
            invoker.SetCommand(encenderLucesCortas);
            invoker.Invoke();

            invoker.SetCommand(apagarLucesCortas);
            invoker.Invoke();

            // Luces largas
            invoker.SetCommand(encenderLucesLargas);
            invoker.Invoke();

            invoker.SetCommand(apagarLucesLargas);
            invoker.Invoke();


            Console.ReadLine();



        }
    }
}
