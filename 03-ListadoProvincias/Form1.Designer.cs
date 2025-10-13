namespace _03_ListadoProvincias
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
            listBox = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ListBtn
            // 
            ListBtn.Location = new Point(103, 38);
            ListBtn.Name = "ListBtn";
            ListBtn.Size = new Size(144, 49);
            ListBtn.TabIndex = 1;
            ListBtn.Text = "Cargar archivo";
            ListBtn.UseVisualStyleBackColor = true;
            ListBtn.Click += ListBtn_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(34, 128);
            listBox.Name = "listBox";
            listBox.Size = new Size(270, 289);
            listBox.TabIndex = 2;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 110);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 3;
            label1.Text = "Lista del fichero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 450);
            Controls.Add(label1);
            Controls.Add(listBox);
            Controls.Add(ListBtn);
            Name = "Form1";
            Text = "Listas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ListBtn;
        private ListBox listBox;
        private Label label1;
    }
}
