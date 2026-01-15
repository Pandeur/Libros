using System;
using System.Collections.Generic;
using System.Text;

namespace Libros
{
    public class ListaLibros
    {
        public List<Libro> MisLibros { get; set; }
        public ListaLibros()
        {
            MisLibros = new List<Libro>();
        }
        public void Agregar(Libro libro)
        {
            MisLibros.Add(libro);
        }
        public List<Libro> Titulo(string cadena)
        {
            List<Libro> lista = new List<Libro>();
            foreach (Libro libro in MisLibros)
            {
                if (libro.Nombre.Contains(cadena))
                    lista.Add(libro);
            }
            return lista;
        }
        public Libro AutorFin(string cadena)
        {
            Libro aux = new Libro();
            foreach (Libro librito in MisLibros)
            {
                if (librito.Nombre.EndsWith(cadena))
                    aux = librito;
            }
            return aux;
        }
        public int ContarTipo(string cadena)
        {
            int aux = 0;
            foreach(Libro librito in MisLibros)
            {
                if((librito.Tipo)==cadena)
                {
                    aux++;
                }
            }
            return aux;
        }
    }
}
