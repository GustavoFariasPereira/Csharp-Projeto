namespace pjtBarbeariaClientes
{
    partial class frmCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtClientes = new TextBox();
            btBuscarLogin = new Button();
            txtLogin = new TextBox();
            lbLoginAgendamento = new Label();
            btExcluirLogin = new Button();
            mnIrPara = new MenuStrip();
            irParaToolStripMenuItem = new ToolStripMenuItem();
            miLogin = new ToolStripMenuItem();
            miCadastro = new ToolStripMenuItem();
            lbTitulo = new Label();
            lbClientes = new Label();
            txtAgendamentos = new TextBox();
            lbAgendamentos = new Label();
            txtBuscar = new TextBox();
            btAlterarLogin = new Button();
            txtProduto = new TextBox();
            lbCadastrarProduto = new Label();
            lbProduto = new Label();
            lbValor = new Label();
            txtValor = new TextBox();
            btCadastrar = new Button();
            lbProdutos = new Label();
            txtProdutos = new TextBox();
            lbProdutoCodigo = new Label();
            txtProdutoCodigo = new TextBox();
            btBuscarProduto = new Button();
            btAlterarProduto = new Button();
            btExcluirProduto = new Button();
            mnIrPara.SuspendLayout();
            SuspendLayout();
            // 
            // txtClientes
            // 
            txtClientes.BorderStyle = BorderStyle.FixedSingle;
            txtClientes.Location = new Point(507, 78);
            txtClientes.Multiline = true;
            txtClientes.Name = "txtClientes";
            txtClientes.ReadOnly = true;
            txtClientes.ScrollBars = ScrollBars.Vertical;
            txtClientes.Size = new Size(402, 185);
            txtClientes.TabIndex = 10;
            // 
            // btBuscarLogin
            // 
            btBuscarLogin.BackColor = SystemColors.ActiveCaption;
            btBuscarLogin.FlatStyle = FlatStyle.Flat;
            btBuscarLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBuscarLogin.ForeColor = SystemColors.ControlText;
            btBuscarLogin.Location = new Point(331, 179);
            btBuscarLogin.Name = "btBuscarLogin";
            btBuscarLogin.Size = new Size(116, 36);
            btBuscarLogin.TabIndex = 11;
            btBuscarLogin.Text = "Buscar";
            btBuscarLogin.UseVisualStyleBackColor = false;
            btBuscarLogin.Click += btConfirmar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(64, 185);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(251, 27);
            txtLogin.TabIndex = 1;
            // 
            // lbLoginAgendamento
            // 
            lbLoginAgendamento.AutoSize = true;
            lbLoginAgendamento.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLoginAgendamento.Location = new Point(64, 154);
            lbLoginAgendamento.Name = "lbLoginAgendamento";
            lbLoginAgendamento.Size = new Size(198, 25);
            lbLoginAgendamento.TabIndex = 12;
            lbLoginAgendamento.Text = "Login / Agendamento";
            // 
            // btExcluirLogin
            // 
            btExcluirLogin.BackColor = Color.Crimson;
            btExcluirLogin.FlatStyle = FlatStyle.Flat;
            btExcluirLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluirLogin.ForeColor = SystemColors.ControlText;
            btExcluirLogin.Location = new Point(199, 393);
            btExcluirLogin.Name = "btExcluirLogin";
            btExcluirLogin.Size = new Size(116, 36);
            btExcluirLogin.TabIndex = 16;
            btExcluirLogin.Text = "Excluir";
            btExcluirLogin.UseVisualStyleBackColor = false;
            btExcluirLogin.Click += btExcluir_Click;
            // 
            // mnIrPara
            // 
            mnIrPara.ImageScalingSize = new Size(20, 20);
            mnIrPara.Items.AddRange(new ToolStripItem[] { irParaToolStripMenuItem });
            mnIrPara.Location = new Point(0, 0);
            mnIrPara.Name = "mnIrPara";
            mnIrPara.Size = new Size(1333, 28);
            mnIrPara.TabIndex = 17;
            // 
            // irParaToolStripMenuItem
            // 
            irParaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miLogin, miCadastro });
            irParaToolStripMenuItem.Name = "irParaToolStripMenuItem";
            irParaToolStripMenuItem.Size = new Size(64, 24);
            irParaToolStripMenuItem.Text = "Ir Para";
            // 
            // miLogin
            // 
            miLogin.Name = "miLogin";
            miLogin.Size = new Size(151, 26);
            miLogin.Text = "Login";
            miLogin.Click += miLogin_Click;
            // 
            // miCadastro
            // 
            miCadastro.Name = "miCadastro";
            miCadastro.Size = new Size(151, 26);
            miCadastro.Text = "Cadastro";
            miCadastro.Click += miCadastro_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = SystemColors.Control;
            lbTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.DarkBlue;
            lbTitulo.Location = new Point(12, 40);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(165, 62);
            lbTitulo.TabIndex = 18;
            lbTitulo.Text = "Barbearia\r\nBarba de Gato\r\n";
            lbTitulo.TextAlign = ContentAlignment.TopCenter;
            lbTitulo.Click += label1_Click;
            // 
            // lbClientes
            // 
            lbClientes.AutoSize = true;
            lbClientes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClientes.Location = new Point(507, 39);
            lbClientes.Name = "lbClientes";
            lbClientes.Size = new Size(79, 25);
            lbClientes.TabIndex = 19;
            lbClientes.Text = "Clientes";
            // 
            // txtAgendamentos
            // 
            txtAgendamentos.BorderStyle = BorderStyle.FixedSingle;
            txtAgendamentos.Location = new Point(507, 341);
            txtAgendamentos.Multiline = true;
            txtAgendamentos.Name = "txtAgendamentos";
            txtAgendamentos.ReadOnly = true;
            txtAgendamentos.ScrollBars = ScrollBars.Vertical;
            txtAgendamentos.Size = new Size(402, 185);
            txtAgendamentos.TabIndex = 20;
            // 
            // lbAgendamentos
            // 
            lbAgendamentos.AutoSize = true;
            lbAgendamentos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAgendamentos.Location = new Point(507, 299);
            lbAgendamentos.Name = "lbAgendamentos";
            lbAgendamentos.Size = new Size(141, 25);
            lbAgendamentos.TabIndex = 21;
            lbAgendamentos.Text = "Agendamentos";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.Window;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.DarkBlue;
            txtBuscar.Location = new Point(64, 233);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.ReadOnly = true;
            txtBuscar.ScrollBars = ScrollBars.Vertical;
            txtBuscar.Size = new Size(275, 144);
            txtBuscar.TabIndex = 22;
            txtBuscar.Text = "Buscar cliente e agendamento.";
            // 
            // btAlterarLogin
            // 
            btAlterarLogin.BackColor = SystemColors.ActiveBorder;
            btAlterarLogin.FlatStyle = FlatStyle.Flat;
            btAlterarLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterarLogin.ForeColor = SystemColors.ControlText;
            btAlterarLogin.Location = new Point(64, 393);
            btAlterarLogin.Name = "btAlterarLogin";
            btAlterarLogin.Size = new Size(116, 36);
            btAlterarLogin.TabIndex = 23;
            btAlterarLogin.Text = "Alterar";
            btAlterarLogin.UseVisualStyleBackColor = false;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(64, 674);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(198, 27);
            txtProduto.TabIndex = 24;
            // 
            // lbCadastrarProduto
            // 
            lbCadastrarProduto.AutoSize = true;
            lbCadastrarProduto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastrarProduto.Location = new Point(64, 557);
            lbCadastrarProduto.Name = "lbCadastrarProduto";
            lbCadastrarProduto.Size = new Size(209, 31);
            lbCadastrarProduto.TabIndex = 25;
            lbCadastrarProduto.Text = "Cadastrar Produto";
            // 
            // lbProduto
            // 
            lbProduto.AutoSize = true;
            lbProduto.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProduto.Location = new Point(64, 646);
            lbProduto.Name = "lbProduto";
            lbProduto.Size = new Size(81, 25);
            lbProduto.TabIndex = 26;
            lbProduto.Text = "Produto";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbValor.Location = new Point(310, 646);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(56, 25);
            lbValor.TabIndex = 28;
            lbValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(310, 674);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(116, 27);
            txtValor.TabIndex = 27;
            // 
            // btCadastrar
            // 
            btCadastrar.BackColor = Color.MediumSeaGreen;
            btCadastrar.FlatStyle = FlatStyle.Flat;
            btCadastrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCadastrar.ForeColor = SystemColors.ControlText;
            btCadastrar.Location = new Point(64, 717);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(116, 36);
            btCadastrar.TabIndex = 29;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = false;
            // 
            // lbProdutos
            // 
            lbProdutos.AutoSize = true;
            lbProdutos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProdutos.Location = new Point(507, 557);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(89, 25);
            lbProdutos.TabIndex = 31;
            lbProdutos.Text = "Produtos";
            // 
            // txtProdutos
            // 
            txtProdutos.BorderStyle = BorderStyle.FixedSingle;
            txtProdutos.Location = new Point(507, 599);
            txtProdutos.Multiline = true;
            txtProdutos.Name = "txtProdutos";
            txtProdutos.ReadOnly = true;
            txtProdutos.ScrollBars = ScrollBars.Vertical;
            txtProdutos.Size = new Size(306, 149);
            txtProdutos.TabIndex = 30;
            // 
            // lbProdutoCodigo
            // 
            lbProdutoCodigo.AutoSize = true;
            lbProdutoCodigo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProdutoCodigo.Location = new Point(845, 641);
            lbProdutoCodigo.Name = "lbProdutoCodigo";
            lbProdutoCodigo.Size = new Size(159, 25);
            lbProdutoCodigo.TabIndex = 38;
            lbProdutoCodigo.Text = "Produto / Código";
            // 
            // txtProdutoCodigo
            // 
            txtProdutoCodigo.Location = new Point(845, 669);
            txtProdutoCodigo.Name = "txtProdutoCodigo";
            txtProdutoCodigo.Size = new Size(198, 27);
            txtProdutoCodigo.TabIndex = 36;
            // 
            // btBuscarProduto
            // 
            btBuscarProduto.BackColor = SystemColors.ActiveCaption;
            btBuscarProduto.FlatStyle = FlatStyle.Flat;
            btBuscarProduto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBuscarProduto.ForeColor = SystemColors.ControlText;
            btBuscarProduto.Location = new Point(1058, 663);
            btBuscarProduto.Name = "btBuscarProduto";
            btBuscarProduto.Size = new Size(116, 36);
            btBuscarProduto.TabIndex = 39;
            btBuscarProduto.Text = "Buscar";
            btBuscarProduto.UseVisualStyleBackColor = false;
            // 
            // btAlterarProduto
            // 
            btAlterarProduto.BackColor = SystemColors.ActiveBorder;
            btAlterarProduto.FlatStyle = FlatStyle.Flat;
            btAlterarProduto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterarProduto.ForeColor = SystemColors.ControlText;
            btAlterarProduto.Location = new Point(845, 712);
            btAlterarProduto.Name = "btAlterarProduto";
            btAlterarProduto.Size = new Size(116, 36);
            btAlterarProduto.TabIndex = 41;
            btAlterarProduto.Text = "Alterar";
            btAlterarProduto.UseVisualStyleBackColor = false;
            // 
            // btExcluirProduto
            // 
            btExcluirProduto.BackColor = Color.Crimson;
            btExcluirProduto.FlatStyle = FlatStyle.Flat;
            btExcluirProduto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluirProduto.ForeColor = SystemColors.ControlText;
            btExcluirProduto.Location = new Point(980, 712);
            btExcluirProduto.Name = "btExcluirProduto";
            btExcluirProduto.Size = new Size(116, 36);
            btExcluirProduto.TabIndex = 40;
            btExcluirProduto.Text = "Excluir";
            btExcluirProduto.UseVisualStyleBackColor = false;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 831);
            Controls.Add(btAlterarProduto);
            Controls.Add(btExcluirProduto);
            Controls.Add(btBuscarProduto);
            Controls.Add(lbProdutoCodigo);
            Controls.Add(txtProdutoCodigo);
            Controls.Add(lbProdutos);
            Controls.Add(txtProdutos);
            Controls.Add(btCadastrar);
            Controls.Add(lbValor);
            Controls.Add(txtValor);
            Controls.Add(lbProduto);
            Controls.Add(txtProduto);
            Controls.Add(lbCadastrarProduto);
            Controls.Add(btAlterarLogin);
            Controls.Add(txtBuscar);
            Controls.Add(lbAgendamentos);
            Controls.Add(txtAgendamentos);
            Controls.Add(lbClientes);
            Controls.Add(lbTitulo);
            Controls.Add(btExcluirLogin);
            Controls.Add(txtLogin);
            Controls.Add(lbLoginAgendamento);
            Controls.Add(btBuscarLogin);
            Controls.Add(txtClientes);
            Controls.Add(mnIrPara);
            MainMenuStrip = mnIrPara;
            Name = "frmCadastro";
            Text = "Cadastro de Clientes";
            Load += frmCadastroClientes_Load;
            mnIrPara.ResumeLayout(false);
            mnIrPara.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtClientes;
        private Button btBuscarLogin;
        private TextBox txtLogin;
        private Label lbLoginAgendamento;
        private Button btExcluirLogin;
        private MenuStrip mnIrPara;
        private ToolStripMenuItem irParaToolStripMenuItem;
        private ToolStripMenuItem miLogin;
        private ToolStripMenuItem miCadastro;
        private Label lbTitulo;
        private Label lbClientes;
        private TextBox txtAgendamentos;
        private Label lbAgendamentos;
        private TextBox txtBuscar;
        private Button btAlterarLogin;
        private TextBox txtProduto;
        private Label lbCadastrarProduto;
        private Label lbProduto;
        private Label lbValor;
        private TextBox txtValor;
        private Button btCadastrar;
        private Label lbProdutos;
        private TextBox txtProdutos;
        private Label lbProdutoCodigo;
        private TextBox txtProdutoCodigo;
        private Button btBuscarProduto;
        private Button btAlterarProduto;
        private Button btExcluirProduto;
        private Button btCadastrarProduto;
    }
}
