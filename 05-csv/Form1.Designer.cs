namespace _05_csv
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
            LeerCSVBtn = new Label();
            btnLeerCSVHelper = new Button();
            BtnLeerCsvPuntoComa = new Button();
            btnHelper = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(46, 24);
            button1.Name = "button1";
            button1.Size = new Size(148, 40);
            button1.TabIndex = 0;
            button1.Text = "Leer CSV";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LeerCSVBtn
            // 
            LeerCSVBtn.AutoSize = true;
            LeerCSVBtn.Location = new Point(240, 37);
            LeerCSVBtn.Name = "LeerCSVBtn";
            LeerCSVBtn.Size = new Size(0, 15);
            LeerCSVBtn.TabIndex = 1;
            // 
            // btnLeerCSVHelper
            // 
            btnLeerCSVHelper.Location = new Point(46, 70);
            btnLeerCSVHelper.Name = "btnLeerCSVHelper";
            btnLeerCSVHelper.Size = new Size(148, 40);
            btnLeerCSVHelper.TabIndex = 2;
            btnLeerCSVHelper.Text = "Leer CSV Helper";
            btnLeerCSVHelper.UseVisualStyleBackColor = true;
            btnLeerCSVHelper.Click += btnLeerCSVHelper_Click;
            // 
            // BtnLeerCsvPuntoComa
            // 
            BtnLeerCsvPuntoComa.Location = new Point(46, 116);
            BtnLeerCsvPuntoComa.Name = "BtnLeerCsvPuntoComa";
            BtnLeerCsvPuntoComa.Size = new Size(148, 40);
            BtnLeerCsvPuntoComa.TabIndex = 3;
            BtnLeerCsvPuntoComa.Text = "Leer CSV Helper ;";
            BtnLeerCsvPuntoComa.UseVisualStyleBackColor = true;
            BtnLeerCsvPuntoComa.Click += BtnLeerCsvPuntoComa_Click;
            // 
            // btnHelper
            // 
            btnHelper.Location = new Point(46, 162);
            btnHelper.Name = "btnHelper";
            btnHelper.Size = new Size(148, 40);
            btnHelper.TabIndex = 4;
            btnHelper.Text = "Leer CSV Helper 2";
            btnHelper.UseVisualStyleBackColor = true;
            btnHelper.Click += btnHelper_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 230);
            Controls.Add(btnHelper);
            Controls.Add(BtnLeerCsvPuntoComa);
            Controls.Add(btnLeerCSVHelper);
            Controls.Add(LeerCSVBtn);
            Controls.Add(button1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label LeerCSVBtn;
        private Button btnLeerCSVHelper;
        private Button BtnLeerCsvPuntoComa;
        private Button btnHelper;
    }
}
