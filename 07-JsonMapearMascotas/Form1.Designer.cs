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
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMapearMascotas);
            Controls.Add(dgvMascotas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMascotas;
        private Button btnMapearMascotas;
    }
}
