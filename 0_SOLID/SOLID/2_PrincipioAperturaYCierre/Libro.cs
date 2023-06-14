using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
El PRINCIPIO DE RESPONSABILIDAD UNICA dice que una clase debe hacer una cosa y, 
por lo tanto, debe tener una sola razón para cambiar.
Para enunciar este principio más técnicamente: Solo un cambio potencial
(lógica de base de datos, lógica de registro, etc.) en la especificación del software,
debería poder afectar la especificación de la clase.

Esto significa que si una clase es un contenedor de datos, como una clase Libro o una clase Estudiante,
y tiene algunos campos relacionados con esa entidad, debería cambiar solo cuando cambiamos 
el modelo de datos.
*/

/* EJEMPLO
 Veremos el código de un programa simple de facturación de librería como ejemplo. 
 Definimos una clase de libro para usar en nuestra factura. 
 */

namespace SOLID._2_PrincipioAperturaYCierre
{
    public class Libro
    {
        string _nombre;
        string _nombreAutor;
        int _anyo;
        int _precio;
        string _isbn;

        public Libro(string nombre, string nombreAutor, int anyo, int precio, string isbn)
        {
            _nombre = nombre;
            _nombreAutor = nombreAutor;
            _anyo = anyo;
            _precio = precio;
            _isbn = isbn;
        }

        public int Precio
        {   // Lectura del precio
            get => _precio;
        }

        public string Nombre
        {   // Lectura del nombre
            get => _nombre;
        }
    }
}
