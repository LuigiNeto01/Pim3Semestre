using System.Text;
using Npgsql;
using System.Security.Cryptography;
using Pim3Semestre.util;

namespace Pim3Semestre
{
    public partial class HomePage : Form
    {
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=Pim;";
        private Usuario usuario;
        private TabPage PaginaEditorOculta;
        private TabPage PaginaAbrirChamadoOculta;

        public HomePage(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            PaginaEditorOculta = tabEditarPerfil;
            PaginaAbrirChamadoOculta = tabNovoChamado;
            tabControl1.TabPages.Remove(PaginaEditorOculta);
            tabControl1.TabPages.Remove(PaginaAbrirChamadoOculta);
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBemVindo.Text = $"Bem-vindo, {usuario.Nome}!";
            txbxNomeUsuario.Text = usuario.Nome;
            txbxEmail.Text = usuario.Email;
            txbxSenha.Text = usuario.Senha;
            txbxCPF.Text = usuario.CPF;

            if (usuario.Cargo == "usuario")
            {
                BtnCriarUsuario.Visible = false;
            }
            else
            {
                BtnCriarUsuario.Visible = true;
            }
        }

        private void lblBemVindo_Click(object sender, EventArgs e)
        {

        }

        // AREA DO MENU LATERAL ----------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e) // mostrar a parte de editar perfil
        {
            if (!tabControl1.TabPages.Contains(PaginaEditorOculta))
            {
                tabControl1.TabPages.Add(PaginaEditorOculta);
                tabControl1.SelectedTab = PaginaEditorOculta;
            }
            else
            {
                tabControl1.TabPages.Remove(PaginaEditorOculta);
            }
        }


        private void button5_Click(object sender, EventArgs e) // mostrar a parte de criar chamado
        {
            if (!tabControl1.TabPages.Contains(PaginaAbrirChamadoOculta))
            {
                tabControl1.TabPages.Add(PaginaAbrirChamadoOculta);
                tabControl1.SelectedTab = PaginaAbrirChamadoOculta;
            }
            else
            {
                tabControl1.TabPages.Remove(PaginaAbrirChamadoOculta);
            }
        }

        // AREA DO MENU LATERAL ----------------------------------------------------------------




        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var conexao = new NpgsqlConnection(connString))
            {
                try
                {
                    conexao.Open();

                    string query = @"
                        UPDATE ""user""
                        SET nome = @nome,
                            email = @email,
                            senha = @senha
                        WHERE cpf = @cpf;
                    ";

                    using (var cmd = new NpgsqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("nome", txbxNomeUsuario.Text);
                        cmd.Parameters.AddWithValue("email", txbxEmail.Text);
                        cmd.Parameters.AddWithValue("senha", util.ValidarDados.GerarHash(txbxSenha.Text)); // Senha atualizada já com hash!

                        cmd.Parameters.AddWithValue("cpf", usuario.CPF); // Usa o CPF salvo no objeto Usuario!

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum dado foi atualizado. Verifique o CPF!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // deslogar
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                this.Hide();
                TelaDeLogin telaDeLogin = new TelaDeLogin();
                telaDeLogin.ShowDialog();
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string textoSelecionado = comboBox1.SelectedItem?.ToString() ?? "";


            if (textoSelecionado == "Outros")
            {
                cmbxPrioridade.Visible = true;
                lblPrioridade.Visible = true;
                txbxDescr.Visible = true;
                lblDescr.Visible = true;
                PnlHelp.Visible = false;
                lblRespostaIA.Visible = false;
                lblsubTitulo.Visible = false;
                txbxSugestao.Visible = false;
            }
            else
            {
                cmbxPrioridade.Visible = false;
                lblPrioridade.Visible = false;
                txbxDescr.Visible = false;
                lblDescr.Visible = false;
            }
        }

        private void btnEnviarChamado_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Preencha o Título, Motivo e Prioridade antes de enviar o chamado!", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string textoSelecionado = comboBox1.SelectedItem.ToString();

            if (textoSelecionado != "Outros")
            {
                PnlHelp.Visible = true;
                lblRespostaIA.Visible = true;
                lblsubTitulo.Visible = true;
                txbxSugestao.Visible = true;

                txbxSugestao.Text = util.RespostasChamado.ObterResposta(textoSelecionado);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txbxTitulo.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(cmbxPrioridade.Text))
                {
                    MessageBox.Show("Preencha o Título, Motivo e Prioridade antes de enviar o chamado!", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int prioridade = cmbxPrioridade.Text.ToLower() switch
                {
                    "crítica" => 1,
                    "critica" => 1,
                    "alta" => 2,
                    "média" => 3,
                    "media" => 3,
                    "baixa" => 4,
                    _ => 4
                };

                using (var conexao = util.Banco.AbrirConexao())
                {
                    try
                    {
                        string query = util.Banco.Queries.InserirTarefa;

                        using (var cmd = new NpgsqlCommand(query, conexao))
                        {
                            cmd.Parameters.AddWithValue("titulo", txbxTitulo.Text.Trim());
                            cmd.Parameters.AddWithValue("motivo", comboBox1.Text.Trim());

                            if (string.IsNullOrWhiteSpace(txbxDescr.Text))
                                cmd.Parameters.AddWithValue("descricao", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("descricao", txbxDescr.Text.Trim());

                            cmd.Parameters.AddWithValue("prioridade", prioridade);
                            cmd.Parameters.AddWithValue("data_criacao", DateTime.Now);
                            cmd.Parameters.AddWithValue("resolvido", false);
                            cmd.Parameters.AddWithValue("id_usuario_criador", usuario.id); 

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Chamado enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txbxTitulo.Text = "";
                            comboBox1.SelectedIndex = -1;
                            txbxDescr.Text = "";
                            cmbxPrioridade.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao enviar chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EnviarChamadoPadrao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbxTitulo.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Preencha o Título e o Motivo antes de enviar o chamado!", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Define prioridade de acordo com o motivo (comboBox1)
            int prioridade = comboBox1.Text.ToLower() switch
            {
                "problemas com o mouse" => 3,
                "problemas com som" => 4,
                "problema com vídeo" => 2,
                "problemas com a internet" => 1,
                _ => 4 // Se não reconhecer, deixa como prioridade 4 (mais baixa)
            };

            using (var conexao = util.Banco.AbrirConexao())
            {
                try
                {
                    string query = util.Banco.Queries.InserirTarefa;

                    using (var cmd = new NpgsqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("titulo", txbxTitulo.Text.Trim());
                        cmd.Parameters.AddWithValue("motivo", comboBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("descricao", DBNull.Value); // ou a descrição se tiver
                        cmd.Parameters.AddWithValue("prioridade", prioridade);
                        cmd.Parameters.AddWithValue("data_criacao", DateTime.Now);
                        cmd.Parameters.AddWithValue("resolvido", false);
                        cmd.Parameters.AddWithValue("id_usuario_criador", usuario.id); // 🔥 Aqui manda o id do usuário logado!


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Chamado enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa campos
                        txbxTitulo.Text = "";
                        comboBox1.SelectedIndex = -1;

                        PnlHelp.Visible = false;
                        lblRespostaIA.Visible = false;
                        lblsubTitulo.Visible = false;
                        txbxSugestao.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
