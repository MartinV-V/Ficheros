using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
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
            // Si existe config.yml LO cargamos, si no existe, creamos uno nuevo
            try
            {
                if (File.Exists(configPath))
                {
                    LoadConfig();
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

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            using var dlg = new ColorDialog { Color = sampleButton.BackColor };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sampleButton.BackColor = dlg.Color;
            }
        }

        private void LoadConfig()
        {
            string yaml = File.ReadAllText(configPath);
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var config = deserializer.Deserialize<UiConfig>(yaml);

            if (config.Form != null && config.Form.Width > 0 && config.Form.Height > 0)
            {
                this.Size = new Size(config.Form.Width, config.Form.Height);
            }

            if (config.Button != null)
            {
                if (!string.IsNullOrWhiteSpace(config.Button.Color))
                {
                    try { sampleButton.BackColor = ColorTranslator.FromHtml(config.Button.Color); }
                    catch { /* ignorar, si el color es invalido*/ }
                }
                if (!string.IsNullOrEmpty(config.Button.Text))
                {
                    sampleButton.Text = config.Button.Text;
                }
            }

            if (config.Textboxes != null)
            {
                textBox1.Text = config.Textboxes.Textbox1 ?? string.Empty;
                textBox2.Text = config.Textboxes.Textbox2 ?? string.Empty;
            }
        }

        private void SaveConfig()
        {
            var config = new UiConfig
            {
                Form = new FormConfig
                {
                    Width = this.Size.Width,
                    Height = this.Size.Height
                },
                Button = new ButtonConfig
                {
                    Color = ColorToHtml(sampleButton.BackColor),
                    Text = sampleButton.Text
                },
                Textboxes = new TextboxesConfig
                {
                    Textbox1 = textBox1.Text,
                    Textbox2 = textBox2.Text
                }
            };

            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var yaml = serializer.Serialize(config);
            File.WriteAllText(configPath, yaml);
        }

        private static string ColorToHtml(Color c) => ColorTranslator.ToHtml(Color.FromArgb(c.R, c.G, c.B));
    }

    // Setter y getter de la configuración
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
