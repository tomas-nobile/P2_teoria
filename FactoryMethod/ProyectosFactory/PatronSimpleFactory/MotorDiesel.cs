using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSimpleFactory
{
    public class MotorDiesel : IMotor
    {
        #region IMotor Members

        int IMotor.Estabilidad { get; set; }
    
        decimal IMotor.ParMotor { get; set; }
     
        int IMotor.Potencia { get; set; }
        decimal IMotor.Rendimiento { get; set; }
        int IMotor.VelocidadNominal { get; set; }

        public string ConsumirCombustible()
        {
            return RealizarCombustion();
        }

        public string InyectarCombustible(int cantidad)
        {
            return $"MotorDiesel: Inyectados {cantidad} ml. de Gasoil.";
        }


        public string RealizarEscape()
        {
            return "MotorDiesel: Realizado escape de gases";
        }

        public string RealizarExpansion()
        {
            return "MotorDiesel: Realizada expansion";
        }


        #endregion

        private string RealizarCombustion()
        {
            return "MotorDiesel: Realizada combustion del Gasoil";
        }
    }
}
