namespace Dialogo_entre_forms
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
            labelInfo = new Label();
            textBoxInfo = new TextBox();
            Abrir = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(50, 33);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(285, 30);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "Aqui ira el mensaje del form2";
            labelInfo.Click += labelInfo_Click;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(50, 92);
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.PlaceholderText = "Aqui la info que aparecera en el form2...";
            textBoxInfo.Size = new Size(285, 23);
            textBoxInfo.TabIndex = 1;
            textBoxInfo.TextChanged += textBoxInfo_TextChanged;
            // 
            // Abrir
            // 
            Abrir.Location = new Point(50, 186);
            Abrir.Name = "Abrir";
            Abrir.Size = new Size(285, 23);
            Abrir.TabIndex = 2;
            Abrir.Text = "Abrir Form2";
            Abrir.UseVisualStyleBackColor = true;
            Abrir.Click += Abrir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(50, 140);
            button2.Name = "button2";
            button2.Size = new Size(285, 23);
            button2.TabIndex = 3;
            button2.Text = "Enviar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(Abrir);
            Controls.Add(textBoxInfo);
            Controls.Add(labelInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
        private TextBox textBoxInfo;
        private Button Abrir;
        private Button button2;
    }
}
