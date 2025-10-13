using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NotasAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string file = "notas.txt";
            string[] partes;
            string nombre;
            string notas;
            listcheck.ClearSelected();
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() != -1)
                    {
                        string line = sr.ReadLine();
                        listcheck.Items.Add(line);
                    }
                }
            }
        }

        private void AñadirBtn_Click(object sender, EventArgs e)
        {
            string fileOut = "notas.txt";
            if (File.Exists(fileOut))
            {
                List<string> list = new List<string>();

                if (!string.IsNullOrEmpty(NombreTxt.Text) && int.TryParse(NotaTxt.Text, out int number) && number <= 10)
                {
                    list.Add($"{NombreTxt.Text}#{number}");
                    string ultimo = list.Last();
                    using (StreamWriter sw = File.AppendText("notas.txt"))
                    {
                        sw.WriteLine(ultimo);
                    }
                    MessageBox.Show("Añadido correctamente");
                }
                else
                {
                    MessageBox.Show("Nombre u Nota incorrectos", "Aviso");
                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VerBtn_Click(object sender, EventArgs e)
        {
            string file = "notas.txt";
            string[] partes;
            string nombre;
            string notas;
            listcheck.Items.Clear();
            NotasGrid.Rows.Clear();
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() != -1)
                    {
                        string line = sr.ReadLine();
                        listcheck.Items.Add(line);
                    }
                }
            }
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() != -1)
                    {
                        string line = sr.ReadLine();
                        partes = line.Split("#");
                        nombre = partes[0];
                        notas = partes[1];
                        if (partes.Length == 2)
                        {
                            NotasGrid.Rows.Add(nombre, notas);
                        }
                    }
                }
            }
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            string file = "notas.txt";
            string[] partes;
            string nombre;
            string notas;
            string nombreMax = "";
            int max = 0;

            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() != -1)
                    {
                        string line = sr.ReadLine();
                        partes = line.Split("#");
                        nombre = partes[0];
                        notas = partes[1];
                        if (int.TryParse(notas, out int num) && num > max)
                        {
                            nombreMax = nombre;
                            max = num;
                        }
                    }
                }
            }

            NotMaxLbl.Text = $"Nota mas alta {nombreMax.ToString()} {max.ToString()}";

        }

        private void ModiBtn_Click(object sender, EventArgs e)
        {
            string fileOut = "notas.txt";
            if (File.Exists(fileOut))
            {
                if (!string.IsNullOrEmpty(NombreTxt.Text) && int.TryParse(NotaTxt.Text, out int number) && number <= 10)
                {
                    var lineas = File.ReadAllLines(fileOut).ToList();
                    bool encontrado = false;

                    for (int i = 0; i < lineas.Count; i++)
                    {
                        var partes = lineas[i].Split("#");
                        if (partes.Length == 2 && partes[0] == NombreTxt.Text)
                        {
                            if (MessageBox.Show("¿Estás seguro que deseas sobreescribir la nota?",
                                "Aviso",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                lineas[i] = $"{NombreTxt.Text}#{number}";
                                encontrado = true;
                            }
                            break;
                        }
                    }

                    if (encontrado)
                    {
                        File.WriteAllLines(fileOut, lineas);
                        MessageBox.Show("Nota modificada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Alumno no encontrado", "Aviso");
                    }
                }
                else
                {
                    MessageBox.Show("Nombre u Nota incorrectos", "Aviso");
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void borrarbtn_Click(object sender, EventArgs e)
        {
            if(listcheck.CheckedItems.Count > 0)
            {
                string file = "notas.txt";
                var lineas = File.ReadAllLines(file).ToList();
                if (File.Exists(file))
                {
                    foreach (var item in listcheck.CheckedItems)
                    {
                        lineas.Remove(item.ToString());
                    }

                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        foreach (var linea in lineas)
                        {
                            sw.WriteLine(linea);
                        }
                    }

                    MessageBox.Show("Alumno eliminado", "Aviso");
                }

            }
            else
            {
                MessageBox.Show("No seleccionaste ningún alumno", "Aviso");
            }
        }
    }
}

