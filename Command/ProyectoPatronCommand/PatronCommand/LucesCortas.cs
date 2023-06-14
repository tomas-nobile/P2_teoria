using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCommand
{
    public class LucesCortas : LucesReceiver
    {
        private const int DISTANCIA = 40;

        public override int Encender()
        {
            this.encendidas = true;
            return DISTANCIA;
        }
    }
}
