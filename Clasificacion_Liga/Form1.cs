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

        public class Puntos
        {
            public int Posicion { get; set; }
            public string Equipo { get; set; }
            public int Pts { get; set; }
            public int Pj { get; set; }
            public int Pg { get; set; }
            public int Pe { get; set; }
            public int Pp { get; set; }
            public int Gf { get; set; }
            public int Gc { get; set; }
            public int Dg { get; set; }
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

        private void VerTodoLigaBtn_Click(object sender, EventArgs e)
        {
            string fichero = "La_Liga_Clasificación.csv";
            if (File.Exists(fichero))
            {
                List<Puntos> listaPartidos = new List<Puntos>();

                foreach (var linea in File.ReadAllLines(fichero))
                {
                    if (linea.StartsWith("POS")) continue; // saltar cabecera

                    var datos = linea.Split(',');

                    Puntos p = new Puntos
                    {
                        Posicion = int.Parse(datos[0]),
                        Equipo = datos[1],
                        Pts = int.Parse(datos[2]),
                        Pj = int.Parse(datos[3]),
                        Pg = int.Parse(datos[4]),
                        Pe = int.Parse(datos[5]),
                        Pp = int.Parse(datos[6]),
                        Gf = int.Parse(datos[7]),
                        Gc = int.Parse(datos[8]),
                        Dg = int.Parse(datos[9])
                    };

                    listaPartidos.Add(p);
                }
                LigaData.DataSource = listaPartidos;
            }
            else
            {
                MessageBox.Show("Error no archivo no detectado");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BuscarBtn_Click_1(object sender, EventArgs e)
        {
            bool flag = false;
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
                    if (datos[0] == JornadaTxt.Text &&
                         (string.IsNullOrEmpty(Equipo1Txt.Text) || datos[1] == Equipo1Txt.Text) &&
                         (string.IsNullOrEmpty(Equipo2Txt.Text) || datos[4] == Equipo2Txt.Text))
                    {
                        listaPartidos.Add(p);
                    }
                }

                DataBuscar.DataSource = listaPartidos;

                if (listaPartidos.Count == 0)
                {
                    MessageBox.Show("No se encontraron coincidencias para los criterios especificados.");
                }
            }
            else
            {
                MessageBox.Show("Error no archivo no detectado");
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            string fichero = "ClasificacionGuardada.csv";

            try
            {
                // Usar StreamWriter para escribir en el archivo
                using (StreamWriter writer = new StreamWriter(fichero))
                {
                    // Escribir la cabecera del archivo CSV
                    writer.WriteLine("Jornada;Equipo1;Result1;Result2;Equipo2");

                    writer.WriteLine("Posicion;Equipo;Pts;Pj;Pg;Pe;Pp;Gf;Gc;Dg");

                    // Escribir cada registro en el archivo
                    foreach (DataGridViewRow row in LigaData.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            int posicion = Convert.ToInt32(row.Cells["Posicion"].Value);
                            string equipo = row.Cells["Equipo"].Value.ToString();
                            int pts = Convert.ToInt32(row.Cells["Pts"].Value);
                            int pj = Convert.ToInt32(row.Cells["Pj"].Value);
                            int pg = Convert.ToInt32(row.Cells["Pg"].Value);
                            int pe = Convert.ToInt32(row.Cells["Pe"].Value);
                            int pp = Convert.ToInt32(row.Cells["Pp"].Value);
                            int gf = Convert.ToInt32(row.Cells["Gf"].Value);
                            int gc = Convert.ToInt32(row.Cells["Gc"].Value);
                            int dg = Convert.ToInt32(row.Cells["Dg"].Value);

                            writer.WriteLine($"{posicion};{equipo};{pts};{pj};{pg};{pe};{pp};{gf};{gc};{dg}");
                        }
                    }
                }

                MessageBox.Show($"Archivo CSV guardado correctamente en: {fichero}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo CSV: {ex.Message}");
            }
        }
    }
}
