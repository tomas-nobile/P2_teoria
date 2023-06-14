using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_PrincipioSustitucionLiskov
{
    public class Rectangulo
    {
        protected int _ancho, _alto;

        public Rectangulo()
        {
        }

        public Rectangulo(int ancho, int alto)
        {
            _ancho = ancho;
            _alto = alto;
        }

        public virtual int Ancho
        {   
            // Lectura del ancho
            get => _ancho;
            
            // Asignación del ancho
            set => _ancho = value;
        }

        public virtual int Alto
        {
            // Lectura del alto
            get => _alto;

            // Asignación del alto
            set => _alto = value;
        }

        public int Area()
        {
            // Calcula el área
            return _ancho * _alto;
        }



    }
}
