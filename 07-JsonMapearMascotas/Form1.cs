using System.ComponentModel.Design.Serialization;
using System.Text.Json;

namespace _07_JsonMapearMascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetJsonFromUrl (string url)
        {
            try
            {
                using (HttpClient cli = new HttpClient())
                {
                    HttpResponseMessage response = cli.GetAsync(url).Result;
                    response.EnsureSuccessStatusCode();
                    return response.Content.ReadAsStringAsync().Result; //async call
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el JSON{ex.Message}");
                return string.Empty;
            }
        }

        private void btnMapearMascotas_Click(object sender, EventArgs e)
        {
            string jsonData = GetJsonFromUrl("  https://raw.githubusercontent.com/LearnWebCode/json-example/master/pets-data.json");

            if(!string.IsNullOrEmpty(jsonData))
            {
                try
                {
                    //Deserialización JSON en un objeto (lista de Pet)
                    PetList petsData = JsonSerializer.Deserialize<PetList>(jsonData);

                    //Si hay datos ==> Introducimos al gridView
                    if(petsData != null && petsData != null)
                    {
                        dgvMascotas.DataSource = petsData.pets;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erorr deserializando JSON: {ex.Message}");
                }
            }
            
        }
    }
}
