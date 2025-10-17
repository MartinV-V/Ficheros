using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace _05_csv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fichero = "personas_punto_coma.csv";
            if (File.Exists(fichero))
            {
                using (StreamReader sr = new StreamReader(fichero))
                {
                    string? linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        //dividir por punto y coma
                        var campos = linea.Split(";");

                        foreach (var campo in campos)
                        {
                            this.LeerCSVBtn.Text += campo + " ";
                        }
                        this.LeerCSVBtn.Text += System.Environment.NewLine;
                    }
                }
            }
            else
            {

            }
        }

        private void btnLeerCSVHelper_Click(object sender, EventArgs e)
        {
            string fichero = "personas.csv";
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {

            };

            StreamReader sr = new StreamReader(fichero);
            using (var csv = new CsvReader(sr, config))
            {
                var personas = csv.GetRecords<Persona>();

                foreach (var persona in personas)
                {
                    this.LeerCSVBtn.Text += persona.nombre + " "
                                            + persona.edad
                                            + " " + persona.altura + System.Environment.NewLine;
                }
            }
        }

        //Mismo lector pero lee punto y coma
        private void BtnLeerCsvPuntoComa_Click(object sender, EventArgs e)
        {
            string fichero = "personas_punto_coma.csv";
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";" //Establece el limitador en punto y coma
            };

            StreamReader sr = new StreamReader(fichero);
            using (var csv = new CsvReader(sr, config))
            {
                var personas = csv.GetRecords<Persona>();

                foreach (var persona in personas)
                {
                    this.LeerCSVBtn.Text += persona.nombre + " "
                                            + persona.edad
                                            + " " + persona.altura + System.Environment.NewLine;
                }
            }
        }

        private void btnHelper_Click(object sender, EventArgs e)
        {
            string fichero = "personas_punto_coma.csv";
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",", //Establece el limitador en punto y coma
            };

            StreamReader sr = new StreamReader(fichero);
            using (var csv = new CsvReader(sr, config))
            {
                var personas = csv.GetRecords<Persona>();

                foreach (var persona in personas)
                {
                    this.LeerCSVBtn.Text += persona.nombre + " "
                                            + persona.edad
                                            + " " + persona.altura + System.Environment.NewLine;
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string fichero = "personas_gaurdadas.csv";
            var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ","
            };

            // Supón que tienes una lista de personas en tu formulario
            List<Persona> personas = new List<Persona>
            {
                new Persona { nombre = "Juan", edad = 30, altura = 175 },
                new Persona { nombre = "Ana", edad = 25, altura = 165 }
                // Añade más personas según tu lógica
            };

            using (var writer = new StreamWriter(fichero,true,new System.Text.UTF8Encoding(true)))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(personas);
            }

            MessageBox.Show("Personas guardadas correctamente en el CSV.");
        }
    }
}
