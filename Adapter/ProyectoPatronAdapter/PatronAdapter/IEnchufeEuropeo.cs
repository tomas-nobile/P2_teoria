using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    public interface IEnchufeEuropeo
    {
        // Devuelve un array de enteros con un voltaje de unos 220V
        int[] Voltaje220V();

        // Devuelve el numero de bornes del enchufe
        int getNumeroBornes();
    }
}
