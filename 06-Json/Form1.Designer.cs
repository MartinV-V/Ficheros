namespace _06_Json
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
            btnLeerJsonLocal = new Button();
            lblResultadoFichero = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtProfesion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            btnAppendPersona = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnLeerJsonLocal
            // 
            btnLeerJsonLocal.Location = new Point(340, 235);
            btnLeerJsonLocal.Name = "btnLeerJsonLocal";
            btnLeerJsonLocal.Size = new Size(205, 23);
            btnLeerJsonLocal.TabIndex = 0;
            btnLeerJsonLocal.Text = "Guardar json";
            btnLeerJsonLocal.UseVisualStyleBackColor = true;
            btnLeerJsonLocal.Click += btnSerializarFromForm_Click;
            // 
            // lblResultadoFichero
            // 
            lblResultadoFichero.AutoSize = true;
            lblResultadoFichero.Location = new Point(297, 54);
            lblResultadoFichero.Name = "lblResultadoFichero";
            lblResultadoFichero.Size = new Size(13, 15);
            lblResultadoFichero.TabIndex = 1;
            lblResultadoFichero.Text = "::";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(170, 163);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(170, 202);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 3;
            // 
            // txtProfesion
            // 
            txtProfesion.Location = new Point(170, 240);
            txtProfesion.Name = "txtProfesion";
            txtProfesion.Size = new Size(100, 23);
            txtProfesion.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 166);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 202);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 243);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Profesión";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(56, 50);
            button1.Name = "button1";
            button1.Size = new Size(205, 23);
            button1.TabIndex = 8;
            button1.Text = "Guardar persona.json";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSerializarAFichero_Click;
            // 
            // btnAppendPersona
            // 
            btnAppendPersona.Location = new Point(340, 166);
            btnAppendPersona.Name = "btnAppendPersona";
            btnAppendPersona.Size = new Size(205, 23);
            btnAppendPersona.TabIndex = 9;
            btnAppendPersona.Text = "Append Persona";
            btnAppendPersona.UseVisualStyleBackColor = true;
            btnAppendPersona.Click += btnAppendPersona_Click;
            // 
            // button2
            // 
            button2.Location = new Point(56, 79);
            button2.Name = "button2";
            button2.Size = new Size(205, 23);
            button2.TabIndex = 10;
            button2.Text = "Leer json";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnLeerJsonLocal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 375);
            Controls.Add(button2);
            Controls.Add(btnAppendPersona);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProfesion);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblResultadoFichero);
            Controls.Add(btnLeerJsonLocal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerJsonLocal;
        private Label lblResultadoFichero;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtProfesion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btnAppendPersona;
        private Button button2;
    }
}
