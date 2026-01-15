using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Libros
{
    public partial class Form1 : Form
    {
        ListaLibros listaLibros = new ListaLibros();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.Nombre = textBox2.Text;
            libro.Autor = textBox1.Text;
            libro.Tipo = textBox3.Text;
            listaLibros.Agregar(libro);
            MessageBox.Show("Libro guardado correctamente!!!");
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2= new Form2();
            form2.Show();

        }
    }
}
