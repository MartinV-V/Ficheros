namespace Clasificacion_Liga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Partido
        {
            public int Jornada { get; set; }
            public string Equipo1 { get; set; }
            public int Result1 { get; set; }
            public int Result2 { get; set; }
            public string Equipo2 { get; set; }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerTodoPartBtn_Click(object sender, EventArgs e)
        {
            string fichero = "Jornadas.csv";
            if (File.Exists(fichero))
            {
                List<Partido> listaPartidos = new List<Partido>();

                foreach (var linea in File.ReadAllLines("Jornadas.csv"))
                {
                    if (linea.StartsWith("Jornada")) continue; // saltar cabecera

                    var datos = linea.Replace("\"", "").Split(';');

                    Partido p = new Partido
                    {
                        Jornada = int.Parse(datos[0]),
                        Equipo1 = datos[1],
                        Result1 = int.Parse(datos[2]),
                        Result2 = int.Parse(datos[3]),
                        Equipo2 = datos[4]
                    };

                    listaPartidos.Add(p);
                }
                JornadaData.DataSource = listaPartidos;
            }
            else
            {
                MessageBox.Show("Error no archivo no detectado");
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
                
        }
    }
}
