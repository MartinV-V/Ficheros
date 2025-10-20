using _06_json;
using System.Text.Json;

namespace _06_Json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerJsonLocal_Click(object sender, EventArgs e)
        {
            string ficheroJSON = "persona.json";

            if (File.Exists(ficheroJSON))
            {
                string jsonText = File.ReadAllText(ficheroJSON);
                Persona p = JsonSerializer.Deserialize<Persona>(jsonText);

                this.lblResultadoFichero.Text += "Nombre: " + p.nombre + System.Environment.NewLine +
                "Edad: " + p.edad + System.Environment.NewLine +
                "Porfesion" + p.profesion + System.Environment.NewLine;


            }
            else
            {
                this.lblResultadoFichero.Text = "El fichero no existe";
            }

        }

        private void btnSerializarAFichero_Click(object sender, EventArgs e)
        {
            Persona p = new Persona
            {
                nombre = "Macarena",
                edad = 19,
                profesion = "Desarrolladora python"
            };

            string jsonText = JsonSerializer.Serialize(p, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("persona_guardada.json", jsonText);

            this.lblResultadoFichero.Text = "Archivo JSON guardado correctamente.";
        }

        private void btnSerializarFromForm_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.nombre = this.txtNombre.Text;
            p.edad = System.Convert.ToInt32(this.txtEdad.Text);
            p.profesion = this.txtProfesion.Text;

            string jsonText = JsonSerializer.Serialize(p, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("persona_guardada_form.json", jsonText);

            File.WriteAllText("persona_guardada_form.json", jsonText);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAppendPersona_Click(object sender, EventArgs e)
        {
            string? jsonFich = "persona.json";
            List<Persona> personas = new List<Persona>();

            // Verificar si el archivo JSON existe
            if (File.Exists(jsonFich))
            {
                // Leer el contenido del archivo JSON
                string jsonText = File.ReadAllText(jsonFich);

                // Deserializar el contenido como una lista de personas
                personas = JsonSerializer.Deserialize<List<Persona>>(jsonText) ?? new List<Persona>();
            }

            // Crear una nueva persona con los datos de los TextBox
            Persona nuevaPersona = new Persona
            {
                nombre = txtNombre.Text,
                edad = System.Convert.ToInt32(this.txtEdad.Text),
                profesion = this.txtProfesion.Text
            };

            // Agregar la nueva persona a la lista
            personas.Add(nuevaPersona);

            // Serializar la lista actualizada y guardar en el archivo JSON
            string jsonText2 = JsonSerializer.Serialize(personas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFich, jsonText2);

            // Actualizar el resultado en la interfaz
            this.lblResultadoFichero.Text = "Archivo JSON actualizado correctamente.";
        }
    }
}

