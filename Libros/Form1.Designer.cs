namespace Libros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            LibroName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            this.AutorCuadro = new TextBox();
            label3 = new Label();
            TipoCuadro = new TextBox();
            linkLabel1 = new LinkLabel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(175, 237);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(136, 50);
            button1.TabIndex = 0;
            button1.Text = "GUARDAR P";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LibroName
            // 
            LibroName.Location = new Point(175, 94);
            LibroName.Name = "LibroName";
            LibroName.Size = new Size(136, 23);
            LibroName.TabIndex = 0;
            LibroName.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 94);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 1;
            label1.Text = "Nombre del libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F);
            label2.Location = new Point(107, 150);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 2;
            label2.Text = "Autor";
            // 
            // AutorCuadro
            // 
            this.AutorCuadro.Location = new Point(175, 150);
            this.AutorCuadro.Name = "AutorCuadro";
            this.AutorCuadro.Size = new Size(136, 23);
            this.AutorCuadro.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F);
            label3.Location = new Point(115, 197);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 4;
            label3.Text = "Tipo";
            // 
            // TipoCuadro
            // 
            TipoCuadro.Location = new Point(175, 197);
            TipoCuadro.Name = "TipoCuadro";
            TipoCuadro.Size = new Size(136, 23);
            TipoCuadro.TabIndex = 5;
            TipoCuadro.TextChanged += TipoCuadro_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(255, 128, 128);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(592, 85);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Siguiente";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(441, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabel1);
            Controls.Add(TipoCuadro);
            Controls.Add(label3);
            Controls.Add(this.AutorCuadro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LibroName);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox LibroName;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox TipoCuadro;
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
    }
}
