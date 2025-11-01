using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
//importante instalar YamlDotNet via NuGet
using YamlDotNet.Serialization; // Necesario para serializar y deserializar YAML
using YamlDotNet.Serialization.NamingConventions; // Necesario para las convenciones de nombres 
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _08_LectorYaml
{
    public partial class Form1 : Form
    {
        private readonly string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "configuracion.yml");

        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Si existe configuracion.yml lo cargamos, si no existe, creamos uno nuevo
            try
            {
                if (File.Exists(configPath))
                {
                    LoadConfig(); //Si existe carga el archivo
                }
                else
                {
                    SaveConfig(); // crea archivo inicial
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar config: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Boton para cargar la configuracion desde el archivo YAML
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                LoadConfig();
                MessageBox.Show("Configuración cargada.", "Cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando configuracion.yml: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Boton para guardar la configuracion en el archivo YAML
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveConfig();
                MessageBox.Show("Configuración guardada.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error guardando configuracion.yml: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //El evento del boton para cambiar el color del boton de muestra
        //NOTA A CARNERO : El metodo ColorDialog es un cuadro de dialogo predefinido en Windows Forms que
        // copie de stackflow para seleccionar colores que me gusto 
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            using var dlg = new ColorDialog { Color = sampleButton.BackColor }; // Inicializa el cuadro de diálogo con el color actual del botón
            if (dlg.ShowDialog() == DialogResult.OK) // Muestra el cuadro de diálogo y verifica si el usuario hizo clic en "OK"
            {
                sampleButton.BackColor = dlg.Color; // Si se seleccionó un color, actualiza el color de fondo del botón
            }
        }

        //Metodo para cargar la configuracion desde el archivo YAML
        private void LoadConfig()
        {
            string yaml = File.ReadAllText(configPath); // Leer el contenido del archivo

            //IMPORTANTE
            //Como configurar un desiarilzador de YAML
            var deserializer = new DeserializerBuilder() // Crear el deserializador
                .WithNamingConvention(CamelCaseNamingConvention.Instance) // Usar convención camelCase
                .Build(); // Construir el deserializador

            var config = deserializer.Deserialize<UiConfig>(yaml); // Deserializar el YAML en un objeto UiConfig
            //IMPORTANTE

            if (config.Form != null && config.Form.Width > 0 && config.Form.Height > 0) //Comprueba si las dimensiones son validas
            {
                this.Size = new Size(config.Form.Width, config.Form.Height); // Establece el tamaño del formulario en base a lo que marques
            }

            if (config.Button != null) //Comprueba si la configuracion del boton no es nula
            {
                if (!string.IsNullOrWhiteSpace(config.Button.Color)) 
                {
                    try { sampleButton.BackColor = ColorTranslator.FromHtml(config.Button.Color); } // Convierte el color de HTML a Color
                    catch { /* ignorar, si el color es invalido*/ }
                }
                if (!string.IsNullOrEmpty(config.Button.Text))
                {
                    sampleButton.Text = config.Button.Text; // Establece el texto del boton
                }
            }

            if (config.Textboxes != null) //Comprueba si la configuracion de los textboxes no es nula
            {
                //Aqui se usa el ?? por si el valor es nulo para que no de error
                textBox1.Text = config.Textboxes.Textbox1 ?? string.Empty; // Establece el texto del textbox1
                textBox2.Text = config.Textboxes.Textbox2 ?? string.Empty; // Establece el texto del textbox2
            }
        }

        //Metodo para guardar la configuracion en el archivo YAML
        private void SaveConfig()
        {
            var config = new UiConfig // Crea un nuevo objeto UiConfig con la configuración actual
            {
                Form = new FormConfig // Guarda el tamaño del formulario
                {
                    Width = this.Size.Width, // Ancho
                    Height = this.Size.Height // Alto
                },
                Button = new ButtonConfig // Guarda la configuración del botón
                {
                    Color = ColorToHtml(sampleButton.BackColor), // Color en formato HTML
                    Text = sampleButton.Text // Texto del botón
                },
                Textboxes = new TextboxesConfig // Guarda la configuración de los textboxes
                {
                    Textbox1 = textBox1.Text, // Texto del textbox1
                    Textbox2 = textBox2.Text // Texto del textbox2
                }
            };

            //Aqui se hace lo mismo que en LoadConfig pero al reves
            var serializer = new SerializerBuilder() // Crear el serializador
                .WithNamingConvention(CamelCaseNamingConvention.Instance) // Usar convención camelCase
                .Build(); // Construir el serializador

            var yaml = serializer.Serialize(config); // Serializar el objeto UiConfig a YAML
            File.WriteAllText(configPath, yaml); // Escribir el YAML en el archivo
        }

        //Aqui cree in convertidor de Color a HTML apra poder guardarlo en YAML
        private static string ColorToHtml(Color c) => ColorTranslator.ToHtml(Color.FromArgb(c.R, c.G, c.B));
    }

    // Setter y getter de la configuración
    // Define las clases que representan la estructura del archivo YAML
    //IMPORTANTE: Los nombres de las propiedades deben coincidir con los del YAML
    // por eso usamos CamelCaseNamingConvention en el serializador y deserializador
    // Usamos el ? para que sean opcionales
    public class UiConfig
    {
        public FormConfig? Form { get; set; }
        public ButtonConfig? Button { get; set; }
        public TextboxesConfig? Textboxes { get; set; }
    }

    public class FormConfig
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class ButtonConfig
    {
        public string? Color { get; set; }
        public string? Text { get; set; }
    }

    public class TextboxesConfig
    {
        public string? Textbox1 { get; set; }
        public string? Textbox2 { get; set; }
    }
}
