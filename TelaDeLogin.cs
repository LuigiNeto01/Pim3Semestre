using System;
using System.Windows.Forms;
using Npgsql;
using System.Security.Cryptography;
using System.Text;

namespace Pim3Semestre
{
    public partial class TelaDeLogin : Form
    {
        private bool modoRegistro = false;

        // String de conexão
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=Pim;";

        public TelaDeLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PassWordTxBx.PasswordChar = '*'; // Senha oculta
            CPFTxBx.Mask = "000.000.000-00"; // Máscara CPF
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            modoRegistro = !modoRegistro;

            TextoLogin.Text = modoRegistro ? "Registro" : "Login";
            BtnLogin.Text = modoRegistro ? "Criar conta" : "Entrar";
            BtnRegistro.Text = modoRegistro ? "Logar" : "Registrar-se";

            EmailTxBx.Visible = modoRegistro;
            CPFTxBx.Visible = modoRegistro;
            lblEmail.Visible = modoRegistro;
            lblCPF.Visible = modoRegistro;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (modoRegistro)
            {
                RegistrarUsuario();
            }
            else
            {
                FazerLogin();
            }
        }

        private void RegistrarUsuario()
        {
            if (!ValidarEmail(EmailTxBx.Text))
            {
                MessageBox.Show("Email inválido!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCPF(CPFTxBx.Text))
            {
                MessageBox.Show("CPF inválido! Deve ter 11 dígitos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conexao = new NpgsqlConnection(connString))
            {
                try
                {
                    conexao.Open();

                    string queryCheck = @"
                        SELECT 1
                        FROM ""user""
                        WHERE cpf = @cpf
                           OR email = @email
                           OR nome = @nome
                        LIMIT 1;
                    ";

                    using (var cmdCheck = new NpgsqlCommand(queryCheck, conexao))
                    {
                        cmdCheck.Parameters.AddWithValue("cpf", CPFTxBx.Text.Replace(".", "").Replace("-", ""));
                        cmdCheck.Parameters.AddWithValue("email", EmailTxBx.Text);
                        cmdCheck.Parameters.AddWithValue("nome", UserTxBx.Text);

                        var existe = cmdCheck.ExecuteScalar();

                        if (existe != null)
                        {
                            MessageBox.Show("CPF, email ou nome já cadastrado!", "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conexao.Close();
                            return;
                        }
                    }

                    string queryInsert = @"
                        INSERT INTO ""user"" (cpf, nome, email, senha)
                        VALUES (@cpf, @nome, @email, @senha);
                    ";

                    using (var cmdInsert = new NpgsqlCommand(queryInsert, conexao))
                    {
                        cmdInsert.Parameters.AddWithValue("cpf", CPFTxBx.Text.Replace(".", "").Replace("-", ""));
                        cmdInsert.Parameters.AddWithValue("nome", UserTxBx.Text);
                        cmdInsert.Parameters.AddWithValue("email", EmailTxBx.Text);
                        cmdInsert.Parameters.AddWithValue("senha", GerarHash(PassWordTxBx.Text)); // Agora senha salva com hash!

                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Conta criada com sucesso!", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa campos
                        CPFTxBx.Text = "";
                        UserTxBx.Text = "";
                        EmailTxBx.Text = "";
                        PassWordTxBx.Text = "";

                        // Volta pro modo login
                        BtnRegistro_Click(null, null);
                    }

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FazerLogin()
        {
            using (var conexao = new NpgsqlConnection(connString))
            {
                try
                {
                    conexao.Open();

                    string query = @"
                        SELECT 1
                        FROM ""user""
                        WHERE nome = @nome
                          AND senha = @Senha
                        LIMIT 1;
                    ";

                    using (var cmd = new NpgsqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("nome", UserTxBx.Text);
                        cmd.Parameters.AddWithValue("Senha", GerarHash(PassWordTxBx.Text)); // Senha comparada com hash!

                        var resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            MessageBox.Show("Login realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide(); // Esconde a TelaDeLogin
                            HomePage home = new HomePage();
                            home.ShowDialog(); // Espera a HomePage fechar
                            this.Close(); // Fecha a TelaDeLogin depois
                        }
                        else
                        {
                            MessageBox.Show("Nome de usuário ou senha incorretos!", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao fazer login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        private bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();
            return cpf.Length == 11;
        }

        private string GerarHash(string texto)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void CPFTxBx_TextChanged(object sender, EventArgs e)
        {
            // Não precisa fazer nada aqui no momento.
        }
    }
}
