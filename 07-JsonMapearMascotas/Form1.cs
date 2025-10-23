using System.ComponentModel.Design.Serialization;
using System.Drawing.Drawing2D;
using System.Text.Json;

namespace _07_JsonMapearMascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int currentPetIndex = 0;

        private string GetJsonFromUrl(string url)
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

            if (!string.IsNullOrEmpty(jsonData))
            {
                try
                {
                    //Deserialización JSON en un objeto (lista de Pet)
                    PetList petsData = JsonSerializer.Deserialize<PetList>(jsonData);

                    //Si hay datos ==> Introducimos al gridView
                    if (petsData != null && petsData != null)
                    {
                        dgvMascotas.DataSource = petsData.pets;

                        if (petsData.pets.Count > 0)
                        {
                            currentPetIndex = 0; // Inicializa el índice
                            MostrarMascota(petsData, currentPetIndex);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erorr deserializando JSON: {ex.Message}");
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            string jsonData = GetJsonFromUrl("  https://raw.githubusercontent.com/LearnWebCode/json-example/master/pets-data.json");
            try
            {
                PetList petsData = JsonSerializer.Deserialize<PetList>(jsonData);

                if (petsData != null && petsData.pets != null && petsData.pets.Count > 0)
                {
                    if (currentPetIndex > 0)
                    {

                        currentPetIndex--;
                        MostrarMascota(petsData, currentPetIndex);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ya estas en la primera mascota: {ex.Message}");
            }
        }

        private void MostrarMascota(PetList petsData, int index)
        {
            var pet = petsData.pets[index];
            txtNombreMascota.Text = pet.name;
            txtNacimiento.Text = pet.birthYear.ToString();
            txtEspecie.Text = pet.species.ToString();
            imgMascota.Load(pet.photo);
            imgMascota.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            string jsonData = GetJsonFromUrl("  https://raw.githubusercontent.com/LearnWebCode/json-example/master/pets-data.json");
            try
            {
                PetList petsData = JsonSerializer.Deserialize<PetList>(jsonData);

                if (petsData != null && petsData.pets != null && petsData.pets.Count > 0)
                {
                    if (currentPetIndex < petsData.pets.Count)
                    {

                        currentPetIndex++;
                        MostrarMascota(petsData, currentPetIndex);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ya estas en la ultima mascota: {ex.Message}");
            }
        }
    }
}
