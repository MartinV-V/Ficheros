using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogo_entre_forms
{
    public partial class Form2 : Form
    {

        
        public event Action<string> MensajeEnviado;

        public Form2(string mensajeInicial)
        {
            InitializeComponent();
            label1.Text = mensajeInicial;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            MensajeEnviado?.Invoke(textBox1.Text);
        }
    }
}
