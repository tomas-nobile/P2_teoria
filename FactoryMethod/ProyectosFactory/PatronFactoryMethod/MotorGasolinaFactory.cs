using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactoryMethod
{
    public class MotorGasolinaFactory : IMotorFactory
    {
        #region IMotorFactory Members

        public IMotor CreateInstance()
        {
            IMotor motorGasolina = new MotorGasolina()
            {
                Estabilidad = 100,
                ParMotor = 40,
                Potencia = 1200,
                Rendimiento = 420,
                VelocidadNominal = 47
            };

            return motorGasolina;
        }

        #endregion
    }
}
