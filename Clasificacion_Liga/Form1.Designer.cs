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
            panel2 = new Panel();
            VerTodoPartBtn = new Button();
            JornadaData = new DataGridView();
            panel3 = new Panel();
            label2 = new Label();
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
            LigaData = new DataGridView();
            VerTodoLigaBtn = new Button();
            panel1 = new Panel();
            DataBuscar = new DataGridView();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JornadaData).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LigaData).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataBuscar).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(VerTodoPartBtn);
            panel2.Controls.Add(JornadaData);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1204, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 694);
            panel2.TabIndex = 2;
            // 
            // VerTodoPartBtn
            // 
            VerTodoPartBtn.Dock = DockStyle.Bottom;
            VerTodoPartBtn.Location = new Point(0, 635);
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
            JornadaData.Size = new Size(1038, 694);
            JornadaData.TabIndex = 0;
            JornadaData.CellContentClick += dataGridView2_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
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
            panel3.Size = new Size(1204, 694);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(1042, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 50);
            label2.TabIndex = 11;
            label2.Text = "Jornada";
            // 
            // GuardarBtn
            // 
            GuardarBtn.Location = new Point(1096, 256);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(108, 182);
            GuardarBtn.TabIndex = 9;
            GuardarBtn.Text = "Guardar en Csv";
            GuardarBtn.UseVisualStyleBackColor = true;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(35, 482);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(493, 58);
            BuscarBtn.TabIndex = 8;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click_1;
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
            // LigaData
            // 
            LigaData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LigaData.Dock = DockStyle.Right;
            LigaData.Location = new Point(1204, 0);
            LigaData.Name = "LigaData";
            LigaData.Size = new Size(1038, 441);
            LigaData.TabIndex = 0;
            // 
            // VerTodoLigaBtn
            // 
            VerTodoLigaBtn.Location = new Point(1096, 50);
            VerTodoLigaBtn.Name = "VerTodoLigaBtn";
            VerTodoLigaBtn.Size = new Size(108, 200);
            VerTodoLigaBtn.TabIndex = 10;
            VerTodoLigaBtn.Text = "Ver Todo";
            VerTodoLigaBtn.UseVisualStyleBackColor = true;
            VerTodoLigaBtn.Click += VerTodoLigaBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(DataBuscar);
            panel1.Controls.Add(GuardarBtn);
            panel1.Controls.Add(VerTodoLigaBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LigaData);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 694);
            panel1.Name = "panel1";
            panel1.Size = new Size(2242, 441);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // DataBuscar
            // 
            DataBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataBuscar.Dock = DockStyle.Left;
            DataBuscar.Location = new Point(0, 0);
            DataBuscar.Name = "DataBuscar";
            DataBuscar.Size = new Size(701, 441);
            DataBuscar.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(888, -3);
            label1.Name = "label1";
            label1.Size = new Size(316, 50);
            label1.TabIndex = 10;
            label1.Text = "Liga Clasificacion";
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
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)JornadaData).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LigaData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataBuscar).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private Button GuardarBtn;
        private Button BuscarBtn;
        private DataGridView LigaData;
        private Button VerTodoLigaBtn;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private DataGridView DataBuscar;
    }
}
