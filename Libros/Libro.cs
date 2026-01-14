using System;
using System.Collections.Generic;
using System.Text;

namespace Libros
{
    internal class Libro
    {
        public string Nombre {  get; set; }
        public string Autor {  get; set; }
        public Libro() { }
        public Libro(string nombre, string autor)
        {
            Nombre = nombre;
            Autor = autor;
        }
    }
}
