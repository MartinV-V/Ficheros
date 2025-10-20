namespace Clasificacion_Liga
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
            Label TOTAL;
            Label label1;
            Label label2;
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            VerTodoLigaBtn = new Button();
            panel2 = new Panel();
            VerTodoPartBtn = new Button();
            JornadaData = new DataGridView();
            panel3 = new Panel();
            GuardarBtn = new Button();
            BuscarBtn = new Button();
            Equipo2Txt = new TextBox();
            label7 = new Label();
            Equipo1Txt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            JornadaTxt = new TextBox();
            TOTAL = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JornadaData).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // TOTAL
            // 
            TOTAL.AutoSize = true;
            TOTAL.Location = new Point(288, 29);
            TOTAL.Name = "TOTAL";
            TOTAL.Size = new Size(51, 15);
            TOTAL.TabIndex = 1;
            TOTAL.Text = "TOTALES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1222, 29);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "EN CASA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1863, 29);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "FUERA";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(2242, 388);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(VerTodoLigaBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TOTAL);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 688);
            panel1.Name = "panel1";
            panel1.Size = new Size(2242, 447);
            panel1.TabIndex = 1;
            // 
            // VerTodoLigaBtn
            // 
            VerTodoLigaBtn.Dock = DockStyle.Right;
            VerTodoLigaBtn.Location = new Point(1960, 0);
            VerTodoLigaBtn.Name = "VerTodoLigaBtn";
            VerTodoLigaBtn.Size = new Size(282, 59);
            VerTodoLigaBtn.TabIndex = 10;
            VerTodoLigaBtn.Text = "Ver Todo";
            VerTodoLigaBtn.UseVisualStyleBackColor = true;
            VerTodoLigaBtn.Click += VerTodoLigaBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(VerTodoPartBtn);
            panel2.Controls.Add(JornadaData);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1204, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 688);
            panel2.TabIndex = 2;
            // 
            // VerTodoPartBtn
            // 
            VerTodoPartBtn.Dock = DockStyle.Bottom;
            VerTodoPartBtn.Location = new Point(0, 629);
            VerTodoPartBtn.Name = "VerTodoPartBtn";
            VerTodoPartBtn.Size = new Size(1038, 59);
            VerTodoPartBtn.TabIndex = 1;
            VerTodoPartBtn.Text = "Ver Todo";
            VerTodoPartBtn.UseVisualStyleBackColor = true;
            VerTodoPartBtn.Click += VerTodoPartBtn_Click;
            // 
            // JornadaData
            // 
            JornadaData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JornadaData.Dock = DockStyle.Fill;
            JornadaData.Location = new Point(0, 0);
            JornadaData.Name = "JornadaData";
            JornadaData.Size = new Size(1038, 688);
            JornadaData.TabIndex = 0;
            JornadaData.CellContentClick += dataGridView2_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(GuardarBtn);
            panel3.Controls.Add(BuscarBtn);
            panel3.Controls.Add(Equipo2Txt);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(Equipo1Txt);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(JornadaTxt);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1204, 688);
            panel3.TabIndex = 3;
            // 
            // GuardarBtn
            // 
            GuardarBtn.Location = new Point(303, 482);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(151, 58);
            GuardarBtn.TabIndex = 9;
            GuardarBtn.Text = "Guardar en Csv";
            GuardarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(35, 482);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(151, 58);
            BuscarBtn.TabIndex = 8;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // Equipo2Txt
            // 
            Equipo2Txt.Location = new Point(365, 218);
            Equipo2Txt.Name = "Equipo2Txt";
            Equipo2Txt.PlaceholderText = "Barcelona...";
            Equipo2Txt.Size = new Size(163, 23);
            Equipo2Txt.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 221);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 6;
            label7.Text = "Equipo2";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Equipo1Txt
            // 
            Equipo1Txt.Location = new Point(97, 218);
            Equipo1Txt.Name = "Equipo1Txt";
            Equipo1Txt.PlaceholderText = "Real Madrid...";
            Equipo1Txt.Size = new Size(163, 23);
            Equipo1Txt.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 221);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 4;
            label6.Text = "Equipo1";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 153);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 3;
            label5.Text = "Jornada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 108);
            label4.Name = "label4";
            label4.Size = new Size(226, 15);
            label4.TabIndex = 2;
            label4.Text = "Introduce el partido o jornada que buscas";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 30F);
            label3.Location = new Point(35, 26);
            label3.Name = "label3";
            label3.Size = new Size(446, 54);
            label3.TabIndex = 1;
            label3.Text = "BUSCADOR DE LA LIGA";
            // 
            // JornadaTxt
            // 
            JornadaTxt.Location = new Point(97, 150);
            JornadaTxt.Name = "JornadaTxt";
            JornadaTxt.PlaceholderText = "Jornada1...";
            JornadaTxt.Size = new Size(163, 23);
            JornadaTxt.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2242, 1135);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Clasificacion Liga";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)JornadaData).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Button VerTodoPartBtn;
        private DataGridView JornadaData;
        private Panel panel3;
        private TextBox Equipo2Txt;
        private Label label7;
        private TextBox Equipo1Txt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox JornadaTxt;
        private Button VerTodoLigaBtn;
        private Button GuardarBtn;
        private Button BuscarBtn;
    }
}
