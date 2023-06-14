using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCommand
{
    public class EncenderLucesCommand : ICommand
    {
        // Referencia al objeto cuyo método se quiere encapsular
        private LucesReceiver luces;

        // El constructor inyectará el objeto cuyo método se quiere encapsular
        public EncenderLucesCommand(LucesReceiver luces)
        {
            this.luces = luces;
        }

        // El método Execute() ejecutará el método encapsulado
        public void Execute()
        {
            // El método GetType muestra el tipo de dato de la instancia del objeto que llega al Execute()

            int distancia = luces.Encender();
            Console.WriteLine($"Encendiendo luces ({luces.GetType()}). Alumbrando a una distancia de {distancia} metros.");
        }
    }
}
