using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    public class EnchufeEuropeo : IEnchufeEuropeo
    {
        #region IEnchufeEuropeo Members

        // Devuelve un array con voltajes en distintos momentos
        public int[] Voltaje220V()
        {
            int[] arrayVoltaje = new int[100];
            Random r = new Random();
            for (int i = 0; i < arrayVoltaje.Length; i++)
            {
                // Calculamos la fluctuacion del voltaje
                int fluctuacion = r.Next(100) > 50 ? 1 : -1;    // Positiva o negativa
                fluctuacion = fluctuacion * (r.Next(10) + 1);    // El valor fluctuara entre -0 y +10

                // Valor total entre 210 y 230V
                arrayVoltaje[i] = fluctuacion + 220;
            }

            return arrayVoltaje;
        }

        // Devuelve el numero de bornes del enchufe
        public int getNumeroBornes()
        {
            return 2;
        }

        #endregion
    }
}
