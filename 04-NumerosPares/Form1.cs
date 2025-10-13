using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _04_NumerosPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {

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

                                int num = int.Parse(line);
                                if (num % 2 == 0)
                                {
                                    string outputPath = "pares.txt";
                                    using (StreamWriter sw = new StreamWriter(outputPath, true)) { sw.WriteLine(line); }

                                }
                            }
                        }
                    }
                    MessageBox.Show("Archivo creado con existo");
                }
                else
                {
                    MessageBox.Show("Error seleccionando el archivo", "Aviso");
                }

            }
        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            int sum = 0;
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
                            string input = sr.ReadLine();
                            if (!string.IsNullOrEmpty(input))
                            {
                                if (int.TryParse(input, out int number))
                                {
                                    sum += number;
                                }
                            }
                        }
                    }
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(sum);
                    }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
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
                            string input = sr.ReadLine();
                            if (!string.IsNullOrEmpty(input))
                            {
                                if (int.TryParse(input, out int number))
                                {
                                    if (number < 10)
                                    {
                                        string outputPath = "Menores_de_10.txt";
                                        using StreamWriter sw = new StreamWriter(outputPath, true);
                                        sw.WriteLine(number.ToString());
                                    }
                                }
                            }
                        }
                    }
                    MessageBox.Show("Archivo creado con existo");
                }
                else
                {
                    MessageBox.Show("Error seleccionando el archivo", "Aviso");
                }
            }
        }

        private void Unirbtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("union.txt"))
            {

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos|*.*";
                    openFileDialog.Multiselect = false;
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
                                    sw.WriteLine(line);
                                }
                            }
                        }



                    }
                    else
                    {
                        MessageBox.Show("Error seleccionando el archivo", "Aviso");
                    }

                }
                using (OpenFileDialog openFileDialog2 = new OpenFileDialog())
                {
                    openFileDialog2.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos|*.*";
                    openFileDialog2.Multiselect = false;
                    if (openFileDialog2.ShowDialog() == DialogResult.OK)
                    {
                        string filePath2 = openFileDialog2.FileName;
                        using (StreamReader sr = new StreamReader(filePath2))

                        {
                            while (sr.Peek() != -1)
                            {
                                string line = sr.ReadLine();
                                if (!string.IsNullOrEmpty(line))
                                {
                                    sw.WriteLine(line);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void OrdenBtn_Click(object sender, EventArgs e)
        {
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK) { 

                    string fileIn = openFileDialog.FileName;
                    string fileOut = "numbersOrdered.txt";

                        if (File.Exists(fileIn))
                        {

                            List<string> lines = new List<string>();
                            StreamReader sr = new StreamReader(fileIn);
                            string line;

                            while ((line = sr.ReadLine()) != null)
                            {
                                lines.Add(line);
                            }
                            sr.Close();

                            lines.Sort();

                            StreamWriter sw = new StreamWriter(fileOut);
                            foreach (string i in lines)
                            {
                                sw.WriteLine(i);
                            }

                            sw.Close();
                        }
                    }
                }
                MessageBox.Show("The file created !!");
            }
        }
    }
}
