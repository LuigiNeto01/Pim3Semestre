namespace Pim3Semestre
{
    public partial class TelaDeLogin : Form
    {
        private bool modoRegistro = false;

        public TelaDeLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            modoRegistro = !modoRegistro; // inverte o modo direto

            TextoLogin.Text = modoRegistro ? "Registro" : "Login";
            BtnLogin.Text = modoRegistro ? "Criar conta" : "Entrar";
            BtnRegistro.Text = modoRegistro ? "Logar" : "Registrar-se";

            // Visibilidade em lote
            EmailTxBx.Visible = modoRegistro;
            CPFTxBx.Visible = modoRegistro;
            lblEmail.Visible = modoRegistro;
            lblCPF.Visible = modoRegistro;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
