using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSimpleFactory
{
   
public class MotorFactory
    {
        public IMotor CreateInstance(string tipoMotor)
        {
            IMotor resultado;

            switch (tipoMotor)
            {
                case "MotorDiesel":
                    resultado = new MotorDiesel();
                    break;
                case "MotorGasolina":
                    resultado = new MotorGasolina();
                    break;
                default:
                    resultado = null;
                    break;
            }

            return resultado;
        }
    }
}
