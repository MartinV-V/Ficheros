namespace _02_intro_ficheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearFichero_Click(object sender, EventArgs e)
        {
            // Solo vamos crear el archivo sino existe
            if (!File.Exists(this.txtNombreFichero.Text))
            {

                // Crear archivo de forma simple
                // File.CreateText(this.txtNombreFichero.Text);

                //Obtener un Stream para escritura
                StreamWriter sr = File.CreateText(this.txtNombreFichero.Text);
                sr.WriteLine("Mi primera raya :)");
                //sr.Flush(); // Sincroniza RAM con el disco (dispositivo externo)
                sr.Close(); // Implica un flush() implicito
                MessageBox.Show("El fichero ha sido creado");
            }
            else
            {
                MessageBox.Show("El fichero ya existe");
            }
        }

        private void btnBorrarFich_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtNombreFichero.Text))
            {
                File.Delete(this.txtNombreFichero.Text);
                MessageBox.Show("El fichero ha sido borrado");
            }
            else
            {
                MessageBox.Show("El fichero no existe");
            }
        }

        private void btnCrearCarpeta_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.txtNombreFichero.Text))
            {

                Directory.CreateDirectory(this.txtNombreFichero.Text);
                MessageBox.Show("La Carpeta ha sido creada");
            }
            else
            {
                MessageBox.Show("La carpeta ya existe");
            }
        }

        private void mvBtn_Click(object sender, EventArgs e)
        {

            if (File.Exists(this.txtNombreFichero.Text) && Directory.Exists(this.mvTxt.Text))
            {

                File.Move(this.txtNombreFichero.Text, this.mvTxt.Text + "/" + this.txtNombreFichero.Text);
            }
            else
            {
                MessageBox.Show("No existe el fichero o carpeta", "Aviso");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void leerBtn_Click(object sender, EventArgs e)
        {
            if(File.Exists(this.LeerTxt.Text))
            {
                //using abre y cierra recursos en su ámbito
                using (StreamReader sr = File.OpenText(this.LeerTxt.Text))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        this.LineaFicheroTxt.Text += linea + Environment.NewLine;
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe puta", "No leas esto");
            }
        }
    }
}
