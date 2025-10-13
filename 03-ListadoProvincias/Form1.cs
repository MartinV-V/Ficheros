namespace _03_ListadoProvincias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            
            this.listBox.Items.Clear();

            //using (StreamReader sr = new StreamReader(file))
            //{
            //    while (sr.Peek() != -1) {
            //        string line = sr.ReadLine();
            //        if (!string.IsNullOrEmpty(line))
            //        {
            //            this.listBox.Items.Add(line);
            //        }
            //    }
            //if (this.listBox.Items.Count > 0)
            //{
            //    this.listBox.SelectedIndex = 0;
            //}

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos|*.*";
                

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        while (sr.Peek() != -1)
                        {
                            string line = sr.ReadLine();
                            if (!string.IsNullOrEmpty(line))
                            {
                                this.listBox.Items.Add(line);
                            }
                        }
                        if (this.listBox.Items.Count > 0)
                        {
                            this.listBox.SelectedIndex = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error seleccionando el archivo", "Aviso");
                }

            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
