using System.Text.Json;

namespace _06_Json
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string profesion { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerJsonLocal_Click(object sender, EventArgs e)
        {
            string? ficheroJson = "persona.json";

            if (File.Exists(ficheroJson))
            {
                string jsonText = File.ReadAllText(ficheroJson);
                Persona? p = JsonSerializer.Deserialize<Persona>(jsonText);

                this.JsonLbl.Text += "Nombre: " + p.nombre + "\n" + "Edad: " + p.edad
                    + "\n" + "Profesion: " + p.profesion;
            }
            else
            {
                this.JsonLbl.Text = "No existe el fichero pillin";
            }
        }
    }
}
