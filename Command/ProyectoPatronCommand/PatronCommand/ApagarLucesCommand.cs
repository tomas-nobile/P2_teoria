using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCommand
{
    public class ApagarLucesCommand : ICommand
    {
        private LucesReceiver luces;

        public ApagarLucesCommand(LucesReceiver luces)
        {
            this.luces = luces;
        }

        public void Execute()
        {
            luces.Apagar();
            Console.WriteLine("Apagando las luces");
        }
    }
}
