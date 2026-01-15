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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
