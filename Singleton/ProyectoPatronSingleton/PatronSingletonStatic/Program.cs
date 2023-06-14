using System;
using System.Threading;

namespace PatronSingletonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            //VERIFICACION QUE AMBAS REFERENCIAS SON DE LA MISMA INSTANCIA

            // Instanciamos el Singleton
            SingletonEstatico s = SingletonEstatico.Instance;

            // Hacemos una pausa de tres segundos
            Thread.Sleep(3000);

            // Intentamos instanciar un segundo Singleton
            SingletonEstatico s2 = SingletonEstatico.Instance;

            // Comprobamos que ambos objetos son referencias a la misma
            // instancia, que es única
            Console.WriteLine(string.Format($"Instancia desde variable s {s.Nombre} " +
                                            $"creada a las {s.HoraDeInicio.ToLongTimeString()}"));

            Console.WriteLine(string.Format($"Instancia desde variable s2 {s2.Nombre} " +
                                            $"creada a las {s2.HoraDeInicio.ToLongTimeString()}"));

            Console.WriteLine("\nEl singleton se creó a las " + SingletonEstatico.Instance.HoraDeInicio.ToLongTimeString());

            Console.ReadLine();
        }
    }
}
