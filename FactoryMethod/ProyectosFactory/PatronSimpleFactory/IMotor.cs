using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSimpleFactory
{
    public interface IMotor
    {
        //Atributos de un motor
        public int Estabilidad { get; set; }
        public decimal ParMotor { get; set; }
        public int Potencia { get; set; }
        public decimal Rendimiento { get; set; }
        public int VelocidadNominal { get; set; }

        // Métodos de un motor
        public string ConsumirCombustible();
        public string InyectarCombustible(int cantidad);
        public string RealizarEscape();
        public string RealizarExpansion();
    }
}
