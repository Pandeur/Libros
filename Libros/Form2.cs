using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Libros
{
    public partial class Form2 : Form
    {
        public ListaLibros Libros = new ListaLibros();
        public Form2()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvContiene.DataSource = Libros.Titulo(txtTitulo.Text);
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            Libro aux = new Libro();
            aux = Libros.AutorFin(txtAutor.Text);
            lvTerminaEn.Items.Add(aux.Autor);
        }

        private void lvTerminaEn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int aux = 0;
            string aux1;
            aux = Libros.ContarTipo(txtTipo.Text);
            aux1=Convert.ToString(aux);

            MessageBox.Show(aux1);
        }
    }
}
