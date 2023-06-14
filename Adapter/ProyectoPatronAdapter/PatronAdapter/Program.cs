using System;

namespace PatronAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1era parte, el taladro funciona a 110v entonces instanciamos el enchufe inglés.

            //// Instanciamos enchufe y taladro
            //IEnchufeIngles enchufe = new EnchufeBritanico();
            //Taladro taladro = new Taladro(enchufe);

            //// Encendemos el taladro
            //taladro.Encender();

//---------------------------------------------------------------------------------

            //// 2da parte, intentamos usar el taladro de 110v con 220v

            //// Instanciamos enchufe y taladro
            //IEnchufeEuropeo enchufe = new EnchufeEuropeo();
            //Taladro taladro = new Taladro(enchufe);

            //// Encendemos el taladro
            //taladro.Encender();

//-------------------------------------------------------------------------------------------
            // 3era parte, usamos el adaptador para que convierta la corriente de 220v para el taladro de 110v
            
            // Instanciamos el enchufe español, que es el que existe en nuestro país
            IEnchufeEuropeo enchufeEuropeo = new EnchufeEuropeo();

            // Instanciamos el adaptador pasándole el enchufe español como parámetro
            IEnchufeIngles adaptador = new AdapterInglesEuropeo(enchufeEuropeo);

            // Creamos el taladro pasándole nuestro adaptador
            Taladro taladro = new Taladro(adaptador);

            // Encendemos el taladro
            taladro.Encender();




            Console.ReadLine();



        }
    }
}
