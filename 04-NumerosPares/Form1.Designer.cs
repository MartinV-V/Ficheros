namespace _04_NumerosPares
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
            ListBtn = new Button();
            sumBtn = new Button();
            btnBorrar = new Button();
            Unirbtn = new Button();
            ordenBtn = new Button();
            SuspendLayout();
            // 
            // ListBtn
            // 
            ListBtn.Location = new Point(96, 24);
            ListBtn.Name = "ListBtn";
            ListBtn.Size = new Size(144, 49);
            ListBtn.TabIndex = 4;
            ListBtn.Text = "Cargar archivo";
            ListBtn.UseVisualStyleBackColor = true;
            ListBtn.Click += ListBtn_Click;
            // 
            // sumBtn
            // 
            sumBtn.Location = new Point(96, 99);
            sumBtn.Name = "sumBtn";
            sumBtn.Size = new Size(144, 49);
            sumBtn.TabIndex = 5;
            sumBtn.Text = "Sumar todo";
            sumBtn.UseVisualStyleBackColor = true;
            sumBtn.Click += sumBtn_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(96, 174);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(144, 49);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar/Num";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Unirbtn
            // 
            Unirbtn.Location = new Point(362, 24);
            Unirbtn.Name = "Unirbtn";
            Unirbtn.Size = new Size(144, 49);
            Unirbtn.TabIndex = 7;
            Unirbtn.Text = "Unir";
            Unirbtn.UseVisualStyleBackColor = true;
            Unirbtn.Click += Unirbtn_Click;
            // 
            // ordenBtn
            // 
            ordenBtn.Location = new Point(362, 99);
            ordenBtn.Name = "ordenBtn";
            ordenBtn.Size = new Size(144, 49);
            ordenBtn.TabIndex = 8;
            ordenBtn.Text = "Ordenar";
            ordenBtn.UseVisualStyleBackColor = true;
            ordenBtn.Click += OrdenBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 249);
            Controls.Add(ordenBtn);
            Controls.Add(Unirbtn);
            Controls.Add(btnBorrar);
            Controls.Add(sumBtn);
            Controls.Add(ListBtn);
            Name = "Form1";
            Text = "Numeros";
            ResumeLayout(false);
        }

        #endregion
        private Button ListBtn;
        private Button sumBtn;
        private Button btnBorrar;
        private Button Unirbtn;
        private Button ordenBtn;
    }
}
