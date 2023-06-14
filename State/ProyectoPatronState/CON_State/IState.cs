using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CON_State
{
    //Esta interfaz expone los métodos Acelerar, Frenar y Contacto.
    public interface IState
    {
        void Acelerar();
        void Frenar();
        void Contacto();
    }
}
