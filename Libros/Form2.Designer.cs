namespace Libros
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuscar = new Button();
            txtTitulo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAutor = new TextBox();
            txtTipo = new TextBox();
            btnBuscar2 = new Button();
            btnContar = new Button();
            dgvContiene = new DataGridView();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)dgvContiene).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(107, 107);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(91, 24);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(106, 52);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 58);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Contiene:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 58);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Termina en:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(500, 58);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo:";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(316, 52);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 5;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(540, 52);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 6;
            // 
            // btnBuscar2
            // 
            btnBuscar2.Location = new Point(325, 97);
            btnBuscar2.Name = "btnBuscar2";
            btnBuscar2.Size = new Size(91, 24);
            btnBuscar2.TabIndex = 7;
            btnBuscar2.Text = "Buscar";
            btnBuscar2.UseVisualStyleBackColor = true;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(549, 97);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(91, 24);
            btnContar.TabIndex = 8;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = true;
            // 
            // dgvContiene
            // 
            dgvContiene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContiene.Location = new Point(78, 148);
            dgvContiene.Name = "dgvContiene";
            dgvContiene.Size = new Size(146, 52);
            dgvContiene.TabIndex = 9;
            // 
            // listView1
            // 
            listView1.Location = new Point(290, 148);
            listView1.Name = "listView1";
            listView1.Size = new Size(137, 52);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(dgvContiene);
            Controls.Add(btnContar);
            Controls.Add(btnBuscar2);
            Controls.Add(txtTipo);
            Controls.Add(txtAutor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Controls.Add(btnBuscar);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvContiene).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAutor;
        private TextBox txtTipo;
        private Button btnBuscar2;
        private Button btnContar;
        private DataGridView dgvContiene;
        private ListView listView1;
    }
}