using SOLID._1_ResponsabilidaUnica;
using SOLID._3_PrincipioSustitucionLiskov;
using System;


namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            // PRINCIPIO DE RESPONSABILIDAD UNICA
            Libro l = new Libro("El principito", "Antoine de Saint-Exupéry", 1943, 4000, "9783140464079");

            // y luego el uso de los demás objetos y métodos: Factura, FacturaImpresion y FacturaPersistencia


            // PRINCIPIO DE APERTURA Y CIERRE y PRINCIPIO DE INVERSION DE DEPENDENCIA

            // crear el libro desde otra variable, crear la factura y grabarla en alguna clase de persistencia


            // PRINCIPIO DE SUSTITUCION DE LISKOV
            Test t = new Test();
            
            // OK - RECTANGULO DESDE RECTANGULO: el área da 6
            Rectangulo UnRectangulo = new Rectangulo(2, 3);
            t.getAreaTest("RECTANGULO DESDE RECTANGULO ", UnRectangulo);

            // OK - CUADRADO DESDE CUADRADO: el área da 25
            Cuadrado UnCuadrado = new Cuadrado(5);
            t.getAreaTest("CUADRADO DESDE CUADRADO ", UnCuadrado);

            // NO OK - RECTANGULO DESDE CUADRADO: el área debería dar 6 y da 9
            Rectangulo OtroRectangulo = new Cuadrado();
            OtroRectangulo.Ancho = 2;
            OtroRectangulo.Alto = 3;
            t.getAreaTest("RECTANGULO DESDE CUADRADO ", OtroRectangulo);

            // PRINCIPIO DE SEGREGACION DE INTERFACES

            //.... y así llamadas a demás objetos según principios y modelado final 
            // ...COMPLETAR llamadas general


        }
    }
}
/*
5 principios, siguiendo el acrónimo inglés SOLID, son:

El Principio de responsabilidad única (Single Responsibility Principle)
El Principio Abierto-Cerrado (Open-Closed Principle)
El Principio de sustitución de Liskov (Liskov Substitution Principle)
El Principio de segregación de interfaz (Interface Segregation Principle)
El Principio de inversión de dependencia (Dependency Inversion Principle) 

https://www.freecodecamp.org/espanol/news/los-principios-solid-explicados-en-espanol/
 */
