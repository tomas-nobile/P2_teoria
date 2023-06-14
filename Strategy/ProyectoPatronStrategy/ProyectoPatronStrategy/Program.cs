using System;

namespace ProyectoPatronState
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v = new Vehiculo();

            v.ConduccionDeportiva();
            v.Acelerar(2.4f);

            Console.WriteLine("");

            v.ConduccionNormal();
            v.Acelerar(2.4f);

            Console.ReadLine();
        }
    }
}
