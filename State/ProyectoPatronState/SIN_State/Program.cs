using System;

namespace SIN_State
{
    class Program
    {
        static void Main(string[] args)
        {
            VehiculoBasico vb = new VehiculoBasico();

            vb.Acelerar();
            vb.Contacto();
            vb.Acelerar();
            vb.Acelerar();
            vb.Acelerar();
            vb.Frenar();
            vb.Frenar();
            vb.Frenar();
            vb.Frenar();

        }
    }
}
