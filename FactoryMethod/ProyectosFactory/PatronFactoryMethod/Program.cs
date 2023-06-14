using System;

namespace PatronFactoryMethod
{
    class Program
    {
        private static IMotorFactory ObtenerFactoria()
        {
            // Suponemos con este método una valor por omisión sobre la factoria a utilizar
            // por ejemplo MotorGasolinaFactory

            // Esto se podría hacer con un archivo externo de CONFIGURACION (o similar)
            // usando una técnica de programación avanzada llamada Reflexion (reflexión de código)
            // En este ejemplo lo simplificamos con este método "ObtenerFactoria".

            IMotorFactory factoria = new MotorGasolinaFactory();


            // Devolvemos la instancia de la factoría
            return factoria;
        }
        static void Main(string[] args)
        {
            // La factoría estará definida en la configuración
            IMotorFactory factoria = ObtenerFactoria();


            // Instanciamos un motor a través de la factoría.
            // Fijémonos que únicamente tratamos con interfaces. En ningún momento
            // concretamos la clase con la que estamos trabajando
            IMotor motor = factoria.CreateInstance();

            // Finalmente, hacemos uso del motor a través de los métodos de la
            // interfaz IMotor.
            Console.WriteLine(motor.InyectarCombustible(20));
            Console.WriteLine(motor.ConsumirCombustible());
            Console.WriteLine(motor.RealizarExpansion());
            Console.WriteLine(motor.RealizarEscape());
            Console.ReadLine();
        }
    }
}
