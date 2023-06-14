using System;
using System.Threading;

namespace PatronSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //VERIFICACION QUE AMBAS REFERENCIAS SON DE LA MISMA INSTANCIA

            // Instanciamos el Singleton
            Singleton s = Singleton.Instance;

            // Hacemos una pausa de tres segundos
            Thread.Sleep(3000);

            // Intentamos instanciar un segundo Singleton
            Singleton s2 = Singleton.Instance;

            // Comprobamos que ambos objetos son referencias a la misma
            // instancia, que es única
            Console.WriteLine(string.Format($"Instancia desde variable s {s.Nombre} " +
                                            $"creada a las {s.HoraDeInicio.ToLongTimeString()}"));
            
            Console.WriteLine(string.Format($"Instancia desde variable s2 {s2.Nombre} " +
                                            $"creada a las {s2.HoraDeInicio.ToLongTimeString()}"));

            Console.WriteLine("\nEl singleton se creó a las " + Singleton.Instance.HoraDeInicio.ToLongTimeString());
            
            Console.ReadLine();
        }
    }
}
