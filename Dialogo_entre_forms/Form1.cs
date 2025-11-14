namespace Dialogo_entre_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("Hola desde Form1");

            f2.MensajeEnviado += F2_MensajeEnviado;

            f2.Show();
        }

        private void F2_MensajeEnviado(string mensaje)
        {
            labelInfo.Text = "Form2 dice: " + mensaje;
        }
    }
}
