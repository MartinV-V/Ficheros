namespace _08_LectorYaml
{
    partial class Form1 : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button sampleButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            sampleButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnChangeColor = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // sampleButton
            // 
            sampleButton.Location = new Point(14, 11);
            sampleButton.Margin = new Padding(4, 3, 4, 3);
            sampleButton.Name = "sampleButton";
            sampleButton.Size = new Size(122, 30);
            sampleButton.TabIndex = 0;
            sampleButton.Text = "Botón";
            sampleButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 53);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 80);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 23);
            textBox2.TabIndex = 2;
            // 
            // btnChangeColor
            // 
            btnChangeColor.Location = new Point(154, 11);
            btnChangeColor.Margin = new Padding(4, 3, 4, 3);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new Size(122, 30);
            btnChangeColor.TabIndex = 3;
            btnChangeColor.Text = "Cambiar color";
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(14, 114);
            btnLoad.Margin = new Padding(4, 3, 4, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(122, 25);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Cargar (config.yml)";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(154, 114);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 25);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar (config.yml)";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(btnChangeColor);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(sampleButton);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "LECTOR YAML";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
