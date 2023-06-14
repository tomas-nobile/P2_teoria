using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_PrincipioSustitucionLiskov
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado() { }

        public Cuadrado(int tamanio)
        {
            // Un cuadrado tiene el ancho y alto del mismo tamaño
            _ancho = _alto = tamanio;

            /* Equivale a 
                _ancho = tamanio;
                _alto = tamanio;
            */
        }

        public override int Ancho
        {
   
           set
            {
                // Asignación del ancho y alto, pues son iguales
                _ancho = value;
                _alto = value;
            }
        }

        public override int Alto
        {
            set
            {
                // Asignación del ancho y alto, pues son iguales
                _ancho = value;
                _alto = value;
            }
        }

     
    }
}
