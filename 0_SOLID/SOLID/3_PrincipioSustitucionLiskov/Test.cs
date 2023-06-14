using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_PrincipioSustitucionLiskov
{
    public class Test
    {

        public void getAreaTest(string titulo, Rectangulo r)
        {
            //int ancho = r.Ancho;
            //r.Alto=10;
            //Console.WriteLine($"Area esperada de ancho  {(ancho * 10)} tiene {r.Area()}");
            
            Console.WriteLine($"{titulo}, área esperada de ancho  {r.Ancho} y alto {r.Alto} es {r.Area()}");
        }

    
    }
}
