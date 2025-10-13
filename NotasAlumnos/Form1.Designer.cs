namespace NotasAlumnos
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
            label1 = new Label();
            label2 = new Label();
            NombreTxt = new TextBox();
            NotaTxt = new TextBox();
            AñadirBtn = new Button();
            groupBox1 = new GroupBox();
            ModiBtn = new Button();
            MaxBtn = new Button();
            VerBtn = new Button();
            NotasGrid = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Notas = new DataGridViewTextBoxColumn();
            NotMaxLbl = new Label();
            listcheck = new CheckedListBox();
            borrarbtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotasGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Alumno";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Nota";
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(143, 23);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.PlaceholderText = "Nombre del alumno...";
            NombreTxt.Size = new Size(130, 23);
            NombreTxt.TabIndex = 2;
            // 
            // NotaTxt
            // 
            NotaTxt.Location = new Point(143, 69);
            NotaTxt.Name = "NotaTxt";
            NotaTxt.PlaceholderText = "Nota numerica...";
            NotaTxt.Size = new Size(130, 23);
            NotaTxt.TabIndex = 3;
            // 
            // AñadirBtn
            // 
            AñadirBtn.Location = new Point(161, 104);
            AñadirBtn.Name = "AñadirBtn";
            AñadirBtn.Size = new Size(100, 49);
            AñadirBtn.TabIndex = 4;
            AñadirBtn.Text = "Añadir";
            AñadirBtn.UseVisualStyleBackColor = true;
            AñadirBtn.Click += AñadirBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ModiBtn);
            groupBox1.Controls.Add(MaxBtn);
            groupBox1.Controls.Add(VerBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AñadirBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 303);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // ModiBtn
            // 
            ModiBtn.Location = new Point(20, 196);
            ModiBtn.Name = "ModiBtn";
            ModiBtn.Size = new Size(100, 49);
            ModiBtn.TabIndex = 6;
            ModiBtn.Text = "Modificar";
            ModiBtn.UseVisualStyleBackColor = true;
            ModiBtn.Click += ModiBtn_Click;
            // 
            // MaxBtn
            // 
            MaxBtn.Location = new Point(161, 196);
            MaxBtn.Name = "MaxBtn";
            MaxBtn.Size = new Size(100, 49);
            MaxBtn.TabIndex = 6;
            MaxBtn.Text = "Nota Max";
            MaxBtn.UseVisualStyleBackColor = true;
            MaxBtn.Click += MaxBtn_Click;
            // 
            // VerBtn
            // 
            VerBtn.Location = new Point(20, 104);
            VerBtn.Name = "VerBtn";
            VerBtn.Size = new Size(100, 49);
            VerBtn.TabIndex = 5;
            VerBtn.Text = "Cargar";
            VerBtn.UseVisualStyleBackColor = true;
            VerBtn.Click += VerBtn_Click;
            // 
            // NotasGrid
            // 
            NotasGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotasGrid.Columns.AddRange(new DataGridViewColumn[] { Nombre, Notas });
            NotasGrid.Location = new Point(306, 23);
            NotasGrid.Name = "NotasGrid";
            NotasGrid.Size = new Size(243, 170);
            NotasGrid.TabIndex = 7;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Notas
            // 
            Notas.HeaderText = "Notas";
            Notas.Name = "Notas";
            // 
            // NotMaxLbl
            // 
            NotMaxLbl.AutoSize = true;
            NotMaxLbl.Location = new Point(334, 208);
            NotMaxLbl.Name = "NotMaxLbl";
            NotMaxLbl.Size = new Size(0, 15);
            NotMaxLbl.TabIndex = 8;
            // 
            // listcheck
            // 
            listcheck.FormattingEnabled = true;
            listcheck.Location = new Point(555, 23);
            listcheck.Name = "listcheck";
            listcheck.Size = new Size(120, 94);
            listcheck.TabIndex = 9;
            listcheck.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // borrarbtn
            // 
            borrarbtn.Location = new Point(555, 123);
            borrarbtn.Name = "borrarbtn";
            borrarbtn.Size = new Size(100, 49);
            borrarbtn.TabIndex = 7;
            borrarbtn.Text = "Borrar";
            borrarbtn.UseVisualStyleBackColor = true;
            borrarbtn.Click += borrarbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 465);
            Controls.Add(borrarbtn);
            Controls.Add(listcheck);
            Controls.Add(NotMaxLbl);
            Controls.Add(NotasGrid);
            Controls.Add(NotaTxt);
            Controls.Add(NombreTxt);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Notas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotasGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NombreTxt;
        private TextBox NotaTxt;
        private Button AñadirBtn;
        private GroupBox groupBox1;
        private Button VerBtn;
        private DataGridView NotasGrid;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Notas;
        private Button MaxBtn;
        private Label NotMaxLbl;
        private Button ModiBtn;
        private CheckedListBox listcheck;
        private Button borrarbtn;
    }
}
