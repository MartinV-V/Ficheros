namespace _02_intro_ficheros
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
            btnCrearFichero = new Button();
            txtNombreFichero = new TextBox();
            btnBorrarFich = new Button();
            btnCrearCarpeta = new Button();
            mvBtn = new Button();
            mvTxt = new TextBox();
            leerBtn = new Button();
            LeerTxt = new TextBox();
            LineaFicheroTxt = new TextBox();
            SuspendLayout();
            // 
            // btnCrearFichero
            // 
            btnCrearFichero.Location = new Point(122, 106);
            btnCrearFichero.Name = "btnCrearFichero";
            btnCrearFichero.Size = new Size(102, 23);
            btnCrearFichero.TabIndex = 0;
            btnCrearFichero.Text = "Crear Fichero";
            btnCrearFichero.UseVisualStyleBackColor = true;
            btnCrearFichero.Click += btnCrearFichero_Click;
            // 
            // txtNombreFichero
            // 
            txtNombreFichero.Location = new Point(12, 12);
            txtNombreFichero.Name = "txtNombreFichero";
            txtNombreFichero.PlaceholderText = "Nombre del archivo...";
            txtNombreFichero.Size = new Size(332, 23);
            txtNombreFichero.TabIndex = 1;
            // 
            // btnBorrarFich
            // 
            btnBorrarFich.Location = new Point(26, 134);
            btnBorrarFich.Name = "btnBorrarFich";
            btnBorrarFich.Size = new Size(102, 23);
            btnBorrarFich.TabIndex = 2;
            btnBorrarFich.Text = "Borrar Fichero";
            btnBorrarFich.UseVisualStyleBackColor = true;
            btnBorrarFich.Click += btnBorrarFich_Click;
            // 
            // btnCrearCarpeta
            // 
            btnCrearCarpeta.Location = new Point(210, 134);
            btnCrearCarpeta.Name = "btnCrearCarpeta";
            btnCrearCarpeta.Size = new Size(102, 23);
            btnCrearCarpeta.TabIndex = 3;
            btnCrearCarpeta.Text = "Crear Carpeta";
            btnCrearCarpeta.UseVisualStyleBackColor = true;
            btnCrearCarpeta.Click += btnCrearCarpeta_Click;
            // 
            // mvBtn
            // 
            mvBtn.Location = new Point(122, 171);
            mvBtn.Name = "mvBtn";
            mvBtn.Size = new Size(102, 23);
            mvBtn.TabIndex = 4;
            mvBtn.Text = "Mover archivo";
            mvBtn.UseVisualStyleBackColor = true;
            mvBtn.Click += mvBtn_Click;
            // 
            // mvTxt
            // 
            mvTxt.Location = new Point(12, 66);
            mvTxt.Name = "mvTxt";
            mvTxt.PlaceholderText = "Mover archivo a...";
            mvTxt.Size = new Size(332, 23);
            mvTxt.TabIndex = 5;
            mvTxt.TextChanged += textBox1_TextChanged;
            // 
            // leerBtn
            // 
            leerBtn.Location = new Point(122, 303);
            leerBtn.Name = "leerBtn";
            leerBtn.Size = new Size(102, 23);
            leerBtn.TabIndex = 6;
            leerBtn.Text = "Leer Fichero";
            leerBtn.UseVisualStyleBackColor = true;
            leerBtn.Click += leerBtn_Click;
            // 
            // LeerTxt
            // 
            LeerTxt.Location = new Point(12, 248);
            LeerTxt.Name = "LeerTxt";
            LeerTxt.PlaceholderText = "Leer Fichero...";
            LeerTxt.Size = new Size(332, 23);
            LeerTxt.TabIndex = 7;
            // 
            // LineaFicheroTxt
            // 
            LineaFicheroTxt.Location = new Point(320, 303);
            LineaFicheroTxt.Multiline = true;
            LineaFicheroTxt.Name = "LineaFicheroTxt";
            LineaFicheroTxt.PlaceholderText = "Aqui aparecera tu fichero...";
            LineaFicheroTxt.Size = new Size(238, 182);
            LineaFicheroTxt.TabIndex = 8;
            // 
            // Form1
            // 
            AcceptButton = btnCrearFichero;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 510);
            Controls.Add(LineaFicheroTxt);
            Controls.Add(LeerTxt);
            Controls.Add(leerBtn);
            Controls.Add(mvTxt);
            Controls.Add(mvBtn);
            Controls.Add(btnCrearCarpeta);
            Controls.Add(btnBorrarFich);
            Controls.Add(txtNombreFichero);
            Controls.Add(btnCrearFichero);
            Name = "Form1";
            Text = "Crear Fichero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearFichero;
        private TextBox txtNombreFichero;
        private Button btnBorrarFich;
        private Button btnCrearCarpeta;
        private Button mvBtn;
        private TextBox mvTxt;
        private Button leerBtn;
        private TextBox LeerTxt;
        private TextBox LineaFicheroTxt;
    }
}
