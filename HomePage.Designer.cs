namespace Pim3Semestre
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            lblBemVindo = new Label();
            btnLogoff = new Button();
            BtnCriarUsuario = new Button();
            button2 = new Button();
            btnEditarPerfil = new Button();
            tabControl1 = new TabControl();
            Inicio = new TabPage();
            tabNovoChamado = new TabPage();
            PnlHelp = new Panel();
            EnviarChamadoPadrao = new Button();
            txbxSugestao = new TextBox();
            lblsubTitulo = new Label();
            lblRespostaIA = new Label();
            panel3 = new Panel();
            btnEnviarChamado = new Button();
            lblPrioridade = new Label();
            cmbxPrioridade = new ComboBox();
            txbxDescr = new TextBox();
            lblDescr = new Label();
            txbxTitulo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            PaginaOcultaChamados = new TabPage();
            panelListaChamados = new Panel();
            cardTemplate = new Panel();
            lblChamadosCriticos = new Label();
            lblChamadosAbertos = new Label();
            lblChamadosFechados = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Titulo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabNovoChamado.SuspendLayout();
            PnlHelp.SuspendLayout();
            panel3.SuspendLayout();
            PaginaOcultaChamados.SuspendLayout();
            panelListaChamados.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrchid;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(lblBemVindo);
            panel1.Controls.Add(btnLogoff);
            panel1.Controls.Add(BtnCriarUsuario);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnEditarPerfil);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 634);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Frame_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 135);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(12, 397);
            button5.Name = "button5";
            button5.Size = new Size(260, 44);
            button5.TabIndex = 5;
            button5.Text = "Criar chamado";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // lblBemVindo
            // 
            lblBemVindo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBemVindo.ImageAlign = ContentAlignment.TopCenter;
            lblBemVindo.Location = new Point(12, 174);
            lblBemVindo.MaximumSize = new Size(260, 80);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(129, 32);
            lblBemVindo.TabIndex = 4;
            lblBemVindo.Text = "Bem vindo";
            lblBemVindo.TextAlign = ContentAlignment.TopCenter;
            lblBemVindo.Click += lblBemVindo_Click;
            // 
            // btnLogoff
            // 
            btnLogoff.BackColor = Color.Transparent;
            btnLogoff.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogoff.ImageAlign = ContentAlignment.BottomCenter;
            btnLogoff.Location = new Point(12, 561);
            btnLogoff.Name = "btnLogoff";
            btnLogoff.Size = new Size(260, 44);
            btnLogoff.TabIndex = 3;
            btnLogoff.Text = "Deslogar";
            btnLogoff.UseVisualStyleBackColor = false;
            btnLogoff.Click += button4_Click;
            // 
            // BtnCriarUsuario
            // 
            BtnCriarUsuario.BackColor = Color.Transparent;
            BtnCriarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnCriarUsuario.Location = new Point(12, 480);
            BtnCriarUsuario.Name = "BtnCriarUsuario";
            BtnCriarUsuario.Size = new Size(260, 44);
            BtnCriarUsuario.TabIndex = 2;
            BtnCriarUsuario.Text = "Gerir usuários";
            BtnCriarUsuario.UseVisualStyleBackColor = false;
            BtnCriarUsuario.Click += BtnCriarUsuario_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(12, 311);
            button2.Name = "button2";
            button2.Size = new Size(260, 44);
            button2.TabIndex = 1;
            button2.Text = "Chamados";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.BackColor = Color.Transparent;
            btnEditarPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditarPerfil.Location = new Point(12, 233);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.Size = new Size(260, 44);
            btnEditarPerfil.TabIndex = 0;
            btnEditarPerfil.Text = "Editar perfil";
            btnEditarPerfil.UseVisualStyleBackColor = false;
            btnEditarPerfil.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Inicio);
            tabControl1.Controls.Add(tabNovoChamado);
            tabControl1.Controls.Add(PaginaOcultaChamados);
            tabControl1.Dock = DockStyle.Left;
            tabControl1.Location = new Point(293, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(934, 634);
            tabControl1.TabIndex = 1;
            // 
            // Inicio
            // 
            Inicio.Location = new Point(4, 24);
            Inicio.Name = "Inicio";
            Inicio.Padding = new Padding(3);
            Inicio.Size = new Size(926, 606);
            Inicio.TabIndex = 0;
            Inicio.Text = "Página inicial";
            Inicio.UseVisualStyleBackColor = true;
            // 
            // tabNovoChamado
            // 
            tabNovoChamado.BackColor = Color.White;
            tabNovoChamado.Controls.Add(PnlHelp);
            tabNovoChamado.Controls.Add(panel3);
            tabNovoChamado.Location = new Point(4, 24);
            tabNovoChamado.Name = "tabNovoChamado";
            tabNovoChamado.Padding = new Padding(3);
            tabNovoChamado.Size = new Size(926, 606);
            tabNovoChamado.TabIndex = 2;
            tabNovoChamado.Text = "Novo chamado";
            // 
            // PnlHelp
            // 
            PnlHelp.BackColor = Color.DarkOrchid;
            PnlHelp.Controls.Add(EnviarChamadoPadrao);
            PnlHelp.Controls.Add(txbxSugestao);
            PnlHelp.Controls.Add(lblsubTitulo);
            PnlHelp.Controls.Add(lblRespostaIA);
            PnlHelp.Location = new Point(463, 11);
            PnlHelp.Name = "PnlHelp";
            PnlHelp.Size = new Size(427, 587);
            PnlHelp.TabIndex = 10;
            PnlHelp.Visible = false;
            // 
            // EnviarChamadoPadrao
            // 
            EnviarChamadoPadrao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnviarChamadoPadrao.Location = new Point(242, 515);
            EnviarChamadoPadrao.Name = "EnviarChamadoPadrao";
            EnviarChamadoPadrao.Size = new Size(139, 55);
            EnviarChamadoPadrao.TabIndex = 13;
            EnviarChamadoPadrao.Text = "Sim, enviar chamado";
            EnviarChamadoPadrao.UseVisualStyleBackColor = true;
            EnviarChamadoPadrao.Click += EnviarChamadoPadrao_Click;
            // 
            // txbxSugestao
            // 
            txbxSugestao.Enabled = false;
            txbxSugestao.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbxSugestao.Location = new Point(44, 135);
            txbxSugestao.Multiline = true;
            txbxSugestao.Name = "txbxSugestao";
            txbxSugestao.Size = new Size(337, 257);
            txbxSugestao.TabIndex = 12;
            txbxSugestao.Visible = false;
            // 
            // lblsubTitulo
            // 
            lblsubTitulo.AutoSize = true;
            lblsubTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsubTitulo.Location = new Point(44, 85);
            lblsubTitulo.Name = "lblsubTitulo";
            lblsubTitulo.Size = new Size(145, 25);
            lblsubTitulo.TabIndex = 11;
            lblsubTitulo.Text = "Você ja tentou...";
            lblsubTitulo.Visible = false;
            // 
            // lblRespostaIA
            // 
            lblRespostaIA.AutoSize = true;
            lblRespostaIA.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespostaIA.Location = new Point(44, 25);
            lblRespostaIA.Name = "lblRespostaIA";
            lblRespostaIA.Size = new Size(337, 40);
            lblRespostaIA.TabIndex = 10;
            lblRespostaIA.Text = "Resposta gerada por IA";
            lblRespostaIA.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrchid;
            panel3.Controls.Add(btnEnviarChamado);
            panel3.Controls.Add(lblPrioridade);
            panel3.Controls.Add(cmbxPrioridade);
            panel3.Controls.Add(txbxDescr);
            panel3.Controls.Add(lblDescr);
            panel3.Controls.Add(txbxTitulo);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(comboBox1);
            panel3.Location = new Point(8, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 587);
            panel3.TabIndex = 1;
            // 
            // btnEnviarChamado
            // 
            btnEnviarChamado.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviarChamado.Location = new Point(70, 501);
            btnEnviarChamado.Name = "btnEnviarChamado";
            btnEnviarChamado.Size = new Size(299, 58);
            btnEnviarChamado.TabIndex = 9;
            btnEnviarChamado.Text = "Abrir chamado";
            btnEnviarChamado.UseVisualStyleBackColor = true;
            btnEnviarChamado.Click += btnEnviarChamado_Click;
            // 
            // lblPrioridade
            // 
            lblPrioridade.AutoSize = true;
            lblPrioridade.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrioridade.Location = new Point(70, 431);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(221, 25);
            lblPrioridade.TabIndex = 8;
            lblPrioridade.Text = "Prioridade do chamado";
            lblPrioridade.Visible = false;
            // 
            // cmbxPrioridade
            // 
            cmbxPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxPrioridade.FormattingEnabled = true;
            cmbxPrioridade.Items.AddRange(new object[] { "Crítica", "Alta", "Média", "Baixa" });
            cmbxPrioridade.Location = new Point(70, 459);
            cmbxPrioridade.Name = "cmbxPrioridade";
            cmbxPrioridade.Size = new Size(299, 23);
            cmbxPrioridade.TabIndex = 7;
            cmbxPrioridade.Visible = false;
            // 
            // txbxDescr
            // 
            txbxDescr.Location = new Point(70, 291);
            txbxDescr.Multiline = true;
            txbxDescr.Name = "txbxDescr";
            txbxDescr.Size = new Size(299, 119);
            txbxDescr.TabIndex = 6;
            txbxDescr.Visible = false;
            // 
            // lblDescr
            // 
            lblDescr.AutoSize = true;
            lblDescr.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescr.Location = new Point(70, 263);
            lblDescr.Name = "lblDescr";
            lblDescr.Size = new Size(212, 25);
            lblDescr.TabIndex = 5;
            lblDescr.Text = "Descrição do chamado";
            lblDescr.Visible = false;
            // 
            // txbxTitulo
            // 
            txbxTitulo.Location = new Point(70, 126);
            txbxTitulo.Name = "txbxTitulo";
            txbxTitulo.Size = new Size(299, 23);
            txbxTitulo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 184);
            label3.Name = "label3";
            label3.Size = new Size(191, 25);
            label3.TabIndex = 2;
            label3.Text = "Motivo do chamado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 25);
            label2.Name = "label2";
            label2.Size = new Size(307, 40);
            label2.TabIndex = 1;
            label2.Text = "Abrir novo chamado ";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Problemas com o mouse", "Problemas com som", "Problema com vídeo", "Problemas com a internet", "Outros" });
            comboBox1.Location = new Point(70, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(299, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // PaginaOcultaChamados
            // 
            PaginaOcultaChamados.Controls.Add(panelListaChamados);
            PaginaOcultaChamados.Controls.Add(lblChamadosCriticos);
            PaginaOcultaChamados.Controls.Add(lblChamadosAbertos);
            PaginaOcultaChamados.Controls.Add(lblChamadosFechados);
            PaginaOcultaChamados.Controls.Add(label6);
            PaginaOcultaChamados.Controls.Add(label5);
            PaginaOcultaChamados.Controls.Add(label4);
            PaginaOcultaChamados.Location = new Point(4, 24);
            PaginaOcultaChamados.Name = "PaginaOcultaChamados";
            PaginaOcultaChamados.Padding = new Padding(3);
            PaginaOcultaChamados.Size = new Size(926, 606);
            PaginaOcultaChamados.TabIndex = 3;
            PaginaOcultaChamados.Text = "Chamados";
            PaginaOcultaChamados.UseVisualStyleBackColor = true;
            PaginaOcultaChamados.Click += PaginaOcultaChamados_Click;
            // 
            // panelListaChamados
            // 
            panelListaChamados.AutoScroll = true;
            panelListaChamados.BackColor = Color.Transparent;
            panelListaChamados.BackgroundImageLayout = ImageLayout.None;
            panelListaChamados.Controls.Add(cardTemplate);
            panelListaChamados.Location = new Point(8, 97);
            panelListaChamados.Name = "panelListaChamados";
            panelListaChamados.Size = new Size(908, 500);
            panelListaChamados.TabIndex = 7;
            // 
            // cardTemplate
            // 
            cardTemplate.BackColor = SystemColors.ScrollBar;
            cardTemplate.Location = new Point(3, 3);
            cardTemplate.Name = "cardTemplate";
            cardTemplate.Size = new Size(890, 119);
            cardTemplate.TabIndex = 6;
            cardTemplate.Visible = false;
            // 
            // lblChamadosCriticos
            // 
            lblChamadosCriticos.AutoSize = true;
            lblChamadosCriticos.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold);
            lblChamadosCriticos.Location = new Point(800, 44);
            lblChamadosCriticos.Name = "lblChamadosCriticos";
            lblChamadosCriticos.Size = new Size(58, 47);
            lblChamadosCriticos.TabIndex = 5;
            lblChamadosCriticos.Text = "12";
            // 
            // lblChamadosAbertos
            // 
            lblChamadosAbertos.AutoSize = true;
            lblChamadosAbertos.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold);
            lblChamadosAbertos.Location = new Point(442, 44);
            lblChamadosAbertos.Name = "lblChamadosAbertos";
            lblChamadosAbertos.Size = new Size(58, 47);
            lblChamadosAbertos.TabIndex = 4;
            lblChamadosAbertos.Text = "12";
            // 
            // lblChamadosFechados
            // 
            lblChamadosFechados.AutoSize = true;
            lblChamadosFechados.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold);
            lblChamadosFechados.Location = new Point(108, 44);
            lblChamadosFechados.Name = "lblChamadosFechados";
            lblChamadosFechados.Size = new Size(58, 47);
            lblChamadosFechados.TabIndex = 3;
            lblChamadosFechados.Text = "12";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(735, 19);
            label6.Name = "label6";
            label6.Size = new Size(175, 25);
            label6.TabIndex = 2;
            label6.Text = "Chamados Críticos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(378, 19);
            label5.Name = "label5";
            label5.Size = new Size(180, 25);
            label5.TabIndex = 1;
            label5.Text = "Chamados Abertos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(45, 19);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 0;
            label4.Text = "Chamados Fechados";
            // 
            // Titulo
            // 
            Titulo.Location = new Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(100, 23);
            Titulo.TabIndex = 0;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 634);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HomePage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página Inicial";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabNovoChamado.ResumeLayout(false);
            PnlHelp.ResumeLayout(false);
            PnlHelp.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            PaginaOcultaChamados.ResumeLayout(false);
            PaginaOcultaChamados.PerformLayout();
            panelListaChamados.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogoff;
        private Button BtnCriarUsuario;
        private Button button2;
        private Button btnEditarPerfil;
        private Label lblBemVindo;
        private TabControl tabControl1;
        private TabPage Inicio;
        private Button button5;
        private TabPage tabNovoChamado;
        private ComboBox comboBox1;
        private Panel panel3;
        private Label label2;
        private TextBox txbxDescr;
        private Label lblDescr;
        private TextBox txbxTitulo;
        private Label Titulo;
        private Label label3;
        private Button btnEnviarChamado;
        private Label lblPrioridade;
        private ComboBox cmbxPrioridade;
        private Panel PnlHelp;
        private Button EnviarChamadoPadrao;
        private TextBox txbxSugestao;
        private Label lblsubTitulo;
        private Label lblRespostaIA;
        private Label lblChamadosCriticos;
        private Label lblChamadosAbertos;
        private Label lblChamadosFechados;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel cardTemplate;
        private Panel panelListaChamados;
        private TabPage PaginaOcultaChamados;
        private PictureBox pictureBox1;
    }
}