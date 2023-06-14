using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactoryMethod
{
    public class MotorDiesel : IMotor
    {
        #region IMotor Members

        public int Estabilidad { get; set; }
        public decimal ParMotor { get; set; }
        public int Potencia { get; set; }
        public decimal Rendimiento { get; set; }
        public int VelocidadNominal { get; set; }

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
