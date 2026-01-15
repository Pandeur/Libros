using System;
using System.Collections.Generic;
using System.Text;

namespace Libros
{
    public class Libro
    {
        public string Nombre {  get; set; }
        public string Autor {  get; set; }
        public string Tipo { get; set; }
        public Libro() { }
        public Libro(string nombre, string autor, string tipo)
        {
            Nombre = nombre;
            Autor = autor;
            Tipo = tipo;
        }
    }
}
