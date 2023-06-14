using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_PrincipioSegregacionInterfaces
{
    public class EstacionamientoGratis : IEstacionamiento
    {

        // Lógica relacionada con los coches y el estacionamiento
        public void estacionarCoche()
        {

        }

        public void sacarCoche()
        {

        }

        public void capacidadEstacionamiento()
        {

        }

        // Lógica relacionada con el pago
        public double calcularTarifa(Coche coche)
        {
            return 0;
        }


        public void hacerPago(Coche coche)
        {
            throw new Exception("Estacionamiento es gratis");
        }
    }
}
