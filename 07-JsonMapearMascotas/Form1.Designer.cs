namespace _07_JsonMapearMascotas
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
            dgvMascotas = new DataGridView();
            btnMapearMascotas = new Button();
            lblNombre = new Label();
            txtNombreMascota = new TextBox();
            label1 = new Label();
            txtEspecie = new TextBox();
            label2 = new Label();
            txtNacimiento = new TextBox();
            imgMascota = new PictureBox();
            label3 = new Label();
            btnAtras = new Button();
            btnAdelante = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMascota).BeginInit();
            SuspendLayout();
            // 
            // dgvMascotas
            // 
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Location = new Point(12, 75);
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.Size = new Size(556, 150);
            dgvMascotas.TabIndex = 0;
            // 
            // btnMapearMascotas
            // 
            btnMapearMascotas.Location = new Point(12, 12);
            btnMapearMascotas.Name = "btnMapearMascotas";
            btnMapearMascotas.Size = new Size(164, 57);
            btnMapearMascotas.TabIndex = 1;
            btnMapearMascotas.Text = "Cargar Mascotas";
            btnMapearMascotas.UseVisualStyleBackColor = true;
            btnMapearMascotas.Click += btnMapearMascotas_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 244);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // txtNombreMascota
            // 
            txtNombreMascota.Location = new Point(105, 241);
            txtNombreMascota.Name = "txtNombreMascota";
            txtNombreMascota.ReadOnly = true;
            txtNombreMascota.Size = new Size(100, 23);
            txtNombreMascota.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 284);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "Especie";
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(105, 281);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.ReadOnly = true;
            txtEspecie.Size = new Size(100, 23);
            txtEspecie.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 327);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Nacimiento";
            // 
            // txtNacimiento
            // 
            txtNacimiento.Location = new Point(105, 324);
            txtNacimiento.Name = "txtNacimiento";
            txtNacimiento.ReadOnly = true;
            txtNacimiento.Size = new Size(100, 23);
            txtNacimiento.TabIndex = 7;
            // 
            // imgMascota
            // 
            imgMascota.Location = new Point(416, 241);
            imgMascota.Name = "imgMascota";
            imgMascota.Size = new Size(217, 184);
            imgMascota.TabIndex = 8;
            imgMascota.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 284);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "Foto";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(210, 455);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(62, 61);
            btnAtras.TabIndex = 10;
            btnAtras.Text = "<";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnAdelante
            // 
            btnAdelante.Location = new Point(463, 455);
            btnAdelante.Name = "btnAdelante";
            btnAdelante.Size = new Size(62, 61);
            btnAdelante.TabIndex = 11;
            btnAdelante.Text = ">";
            btnAdelante.UseVisualStyleBackColor = true;
            btnAdelante.Click += btnAdelante_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 588);
            Controls.Add(btnAdelante);
            Controls.Add(btnAtras);
            Controls.Add(label3);
            Controls.Add(imgMascota);
            Controls.Add(txtNacimiento);
            Controls.Add(label2);
            Controls.Add(txtEspecie);
            Controls.Add(label1);
            Controls.Add(txtNombreMascota);
            Controls.Add(lblNombre);
            Controls.Add(btnMapearMascotas);
            Controls.Add(dgvMascotas);
            Name = "Form1";
            Text = "Mascotas";
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMascota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMascotas;
        private Button btnMapearMascotas;
        private Label lblNombre;
        private TextBox txtNombreMascota;
        private Label label1;
        private TextBox txtEspecie;
        private Label label2;
        private TextBox txtNacimiento;
        private PictureBox imgMascota;
        private Label label3;
        private Button btnAtras;
        private Button btnAdelante;
    }
}
