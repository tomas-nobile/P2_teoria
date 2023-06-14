using System;

namespace PatronSimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorFactory factory = new MotorFactory();

            // Delega la creación de la instancia de un objeto del tipo MotorDiesel
            // en la clase MotorFactory
            IMotor motorDiesel = factory.CreateInstance("MotorDiesel");

            Console.WriteLine(motorDiesel.InyectarCombustible(20));
            Console.WriteLine(motorDiesel.ConsumirCombustible());
            Console.WriteLine(motorDiesel.RealizarExpansion());
            Console.WriteLine(motorDiesel.RealizarEscape());
            Console.ReadLine();
        }
    }
}
