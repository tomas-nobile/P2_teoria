using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSimpleFactory
{
    public class MotorGasolina : IMotor
    {
        #region IMotor Members

        public int Estabilidad { get; set; }
        public decimal ParMotor { get; set; }
        public int Potencia { get; set; }
        public decimal Rendimiento { get; set; }
        public int VelocidadNominal { get; set; }

        public string ConsumirCombustible()
        {
            return RealizarExplosion();
        }

        public string InyectarCombustible(int cantidad)
        {
            return $"MotorGasolina: Inyectados {cantidad} ml. de Gasolina.";
        }

        public string RealizarEscape()
        {
            return "MotorGasolina: Realizado escape de gases";
        }

        public string RealizarExpansion()
        {
            return "MotorGasolina: Realizada expansion";

        }

        #endregion

        private string RealizarExplosion()
        {
            return "MotorGasolina: Realizada explosion de la Gasolina";
        }
    }
}
