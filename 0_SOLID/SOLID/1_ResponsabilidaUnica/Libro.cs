using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_ResponsabilidaUnica
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
