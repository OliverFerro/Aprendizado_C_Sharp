using PrimoQ.modelo;

namespace PrimoQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbNumero.Text);
            lblResposta.Text = controle.mensagem;


        }
    }
}