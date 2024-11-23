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
            txtBuscarCLientesAgendamentos = new TextBox();
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
            ckSugunda = new CheckBox();
            lbDiasFuncionamento = new Label();
            ckTerca = new CheckBox();
            ckDomingo = new CheckBox();
            ckQuarta = new CheckBox();
            ckSexta = new CheckBox();
            ckQuinta = new CheckBox();
            ckSabado = new CheckBox();
            btConfirmarBarbearia = new Button();
            lbHorariosFuncionamento = new Label();
            txtAbertura = new TextBox();
            lbAbertura = new Label();
            lbFechamento = new Label();
            txtFechamento = new TextBox();
            lbPausa = new Label();
            txtPausa = new TextBox();
            txtBuscarProdutos = new TextBox();
            btAlterarBarbearia = new Button();
            btExluirBarbearia = new Button();
            lbDiasHorasFuncionamento = new Label();
            txtDiasHorasFuncionamento = new TextBox();
            rbEstaSemana = new RadioButton();
            rbProximaSemana = new RadioButton();
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
            mnIrPara.Size = new Size(1741, 28);
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
            // txtBuscarCLientesAgendamentos
            // 
            txtBuscarCLientesAgendamentos.BackColor = SystemColors.Window;
            txtBuscarCLientesAgendamentos.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarCLientesAgendamentos.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarCLientesAgendamentos.ForeColor = Color.DarkBlue;
            txtBuscarCLientesAgendamentos.Location = new Point(64, 233);
            txtBuscarCLientesAgendamentos.Multiline = true;
            txtBuscarCLientesAgendamentos.Name = "txtBuscarCLientesAgendamentos";
            txtBuscarCLientesAgendamentos.ReadOnly = true;
            txtBuscarCLientesAgendamentos.ScrollBars = ScrollBars.Vertical;
            txtBuscarCLientesAgendamentos.Size = new Size(275, 144);
            txtBuscarCLientesAgendamentos.TabIndex = 22;
            txtBuscarCLientesAgendamentos.Text = "Buscar cliente e agendamento.";
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
            txtProduto.Location = new Point(64, 716);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(198, 27);
            txtProduto.TabIndex = 24;
            // 
            // lbCadastrarProduto
            // 
            lbCadastrarProduto.AutoSize = true;
            lbCadastrarProduto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastrarProduto.Location = new Point(64, 599);
            lbCadastrarProduto.Name = "lbCadastrarProduto";
            lbCadastrarProduto.Size = new Size(209, 31);
            lbCadastrarProduto.TabIndex = 25;
            lbCadastrarProduto.Text = "Cadastrar Produto";
            // 
            // lbProduto
            // 
            lbProduto.AutoSize = true;
            lbProduto.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProduto.Location = new Point(64, 688);
            lbProduto.Name = "lbProduto";
            lbProduto.Size = new Size(81, 25);
            lbProduto.TabIndex = 26;
            lbProduto.Text = "Produto";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbValor.Location = new Point(310, 688);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(56, 25);
            lbValor.TabIndex = 28;
            lbValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(310, 716);
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
            btCadastrar.Location = new Point(64, 759);
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
            lbProdutos.Location = new Point(507, 605);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(89, 25);
            lbProdutos.TabIndex = 31;
            lbProdutos.Text = "Produtos";
            // 
            // txtProdutos
            // 
            txtProdutos.BorderStyle = BorderStyle.FixedSingle;
            txtProdutos.Location = new Point(507, 647);
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
            lbProdutoCodigo.Location = new Point(877, 605);
            lbProdutoCodigo.Name = "lbProdutoCodigo";
            lbProdutoCodigo.Size = new Size(159, 25);
            lbProdutoCodigo.TabIndex = 38;
            lbProdutoCodigo.Text = "Produto / Código";
            // 
            // txtProdutoCodigo
            // 
            txtProdutoCodigo.Location = new Point(877, 633);
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
            btBuscarProduto.Location = new Point(1090, 627);
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
            btAlterarProduto.Location = new Point(877, 771);
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
            btExcluirProduto.Location = new Point(1010, 772);
            btExcluirProduto.Name = "btExcluirProduto";
            btExcluirProduto.Size = new Size(116, 36);
            btExcluirProduto.TabIndex = 40;
            btExcluirProduto.Text = "Excluir";
            btExcluirProduto.UseVisualStyleBackColor = false;
            // 
            // ckSugunda
            // 
            ckSugunda.AutoSize = true;
            ckSugunda.Location = new Point(986, 102);
            ckSugunda.Name = "ckSugunda";
            ckSugunda.Size = new Size(89, 24);
            ckSugunda.TabIndex = 42;
            ckSugunda.Text = "Segunda";
            ckSugunda.UseVisualStyleBackColor = true;
            // 
            // lbDiasFuncionamento
            // 
            lbDiasFuncionamento.AutoSize = true;
            lbDiasFuncionamento.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbDiasFuncionamento.Location = new Point(980, 40);
            lbDiasFuncionamento.Name = "lbDiasFuncionamento";
            lbDiasFuncionamento.Size = new Size(254, 30);
            lbDiasFuncionamento.TabIndex = 43;
            lbDiasFuncionamento.Text = "Dias de Funcionamento";
            // 
            // ckTerca
            // 
            ckTerca.AutoSize = true;
            ckTerca.Location = new Point(1093, 102);
            ckTerca.Name = "ckTerca";
            ckTerca.Size = new Size(66, 24);
            ckTerca.TabIndex = 44;
            ckTerca.Text = "Terça";
            ckTerca.UseVisualStyleBackColor = true;
            // 
            // ckDomingo
            // 
            ckDomingo.AutoSize = true;
            ckDomingo.Location = new Point(986, 162);
            ckDomingo.Name = "ckDomingo";
            ckDomingo.Size = new Size(94, 24);
            ckDomingo.TabIndex = 45;
            ckDomingo.Text = "Domingo";
            ckDomingo.UseVisualStyleBackColor = true;
            // 
            // ckQuarta
            // 
            ckQuarta.AutoSize = true;
            ckQuarta.Location = new Point(1200, 102);
            ckQuarta.Name = "ckQuarta";
            ckQuarta.Size = new Size(76, 24);
            ckQuarta.TabIndex = 46;
            ckQuarta.Text = "Quarta";
            ckQuarta.UseVisualStyleBackColor = true;
            // 
            // ckSexta
            // 
            ckSexta.AutoSize = true;
            ckSexta.Location = new Point(1093, 132);
            ckSexta.Name = "ckSexta";
            ckSexta.Size = new Size(67, 24);
            ckSexta.TabIndex = 47;
            ckSexta.Text = "Sexta";
            ckSexta.UseVisualStyleBackColor = true;
            // 
            // ckQuinta
            // 
            ckQuinta.AutoSize = true;
            ckQuinta.Location = new Point(986, 132);
            ckQuinta.Name = "ckQuinta";
            ckQuinta.Size = new Size(75, 24);
            ckQuinta.TabIndex = 48;
            ckQuinta.Text = "Quinta";
            ckQuinta.UseVisualStyleBackColor = true;
            // 
            // ckSabado
            // 
            ckSabado.AutoSize = true;
            ckSabado.Location = new Point(1200, 132);
            ckSabado.Name = "ckSabado";
            ckSabado.Size = new Size(82, 24);
            ckSabado.TabIndex = 49;
            ckSabado.Text = "Sabado";
            ckSabado.UseVisualStyleBackColor = true;
            // 
            // btConfirmarBarbearia
            // 
            btConfirmarBarbearia.BackColor = Color.MediumSeaGreen;
            btConfirmarBarbearia.FlatStyle = FlatStyle.Flat;
            btConfirmarBarbearia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btConfirmarBarbearia.ForeColor = SystemColors.ControlText;
            btConfirmarBarbearia.Location = new Point(991, 454);
            btConfirmarBarbearia.Name = "btConfirmarBarbearia";
            btConfirmarBarbearia.Size = new Size(116, 36);
            btConfirmarBarbearia.TabIndex = 50;
            btConfirmarBarbearia.Text = "Confirmar";
            btConfirmarBarbearia.UseVisualStyleBackColor = false;
            // 
            // lbHorariosFuncionamento
            // 
            lbHorariosFuncionamento.AutoSize = true;
            lbHorariosFuncionamento.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbHorariosFuncionamento.Location = new Point(980, 227);
            lbHorariosFuncionamento.Name = "lbHorariosFuncionamento";
            lbHorariosFuncionamento.Size = new Size(299, 30);
            lbHorariosFuncionamento.TabIndex = 51;
            lbHorariosFuncionamento.Text = "Horários de Funcionamento";
            // 
            // txtAbertura
            // 
            txtAbertura.BorderStyle = BorderStyle.FixedSingle;
            txtAbertura.Location = new Point(1108, 324);
            txtAbertura.Name = "txtAbertura";
            txtAbertura.Size = new Size(91, 27);
            txtAbertura.TabIndex = 52;
            // 
            // lbAbertura
            // 
            lbAbertura.AutoSize = true;
            lbAbertura.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAbertura.Location = new Point(986, 322);
            lbAbertura.Name = "lbAbertura";
            lbAbertura.Size = new Size(94, 25);
            lbAbertura.TabIndex = 53;
            lbAbertura.Text = "Abertura:";
            // 
            // lbFechamento
            // 
            lbFechamento.AutoSize = true;
            lbFechamento.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFechamento.Location = new Point(986, 404);
            lbFechamento.Name = "lbFechamento";
            lbFechamento.Size = new Size(121, 25);
            lbFechamento.TabIndex = 54;
            lbFechamento.Text = "Fechamento:";
            // 
            // txtFechamento
            // 
            txtFechamento.BorderStyle = BorderStyle.FixedSingle;
            txtFechamento.Location = new Point(1108, 406);
            txtFechamento.Name = "txtFechamento";
            txtFechamento.Size = new Size(91, 27);
            txtFechamento.TabIndex = 55;
            // 
            // lbPausa
            // 
            lbPausa.AutoSize = true;
            lbPausa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPausa.Location = new Point(986, 363);
            lbPausa.Name = "lbPausa";
            lbPausa.Size = new Size(67, 25);
            lbPausa.TabIndex = 57;
            lbPausa.Text = "Pausa:";
            // 
            // txtPausa
            // 
            txtPausa.BorderStyle = BorderStyle.FixedSingle;
            txtPausa.Location = new Point(1108, 365);
            txtPausa.Name = "txtPausa";
            txtPausa.Size = new Size(91, 27);
            txtPausa.TabIndex = 56;
            // 
            // txtBuscarProdutos
            // 
            txtBuscarProdutos.BackColor = SystemColors.Window;
            txtBuscarProdutos.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarProdutos.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarProdutos.ForeColor = Color.DarkBlue;
            txtBuscarProdutos.Location = new Point(877, 676);
            txtBuscarProdutos.Multiline = true;
            txtBuscarProdutos.Name = "txtBuscarProdutos";
            txtBuscarProdutos.ReadOnly = true;
            txtBuscarProdutos.ScrollBars = ScrollBars.Vertical;
            txtBuscarProdutos.Size = new Size(275, 79);
            txtBuscarProdutos.TabIndex = 58;
            txtBuscarProdutos.Text = "Buscar produto.";
            // 
            // btAlterarBarbearia
            // 
            btAlterarBarbearia.BackColor = SystemColors.ActiveBorder;
            btAlterarBarbearia.FlatStyle = FlatStyle.Flat;
            btAlterarBarbearia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterarBarbearia.ForeColor = SystemColors.ControlText;
            btAlterarBarbearia.Location = new Point(1118, 454);
            btAlterarBarbearia.Name = "btAlterarBarbearia";
            btAlterarBarbearia.Size = new Size(116, 36);
            btAlterarBarbearia.TabIndex = 62;
            btAlterarBarbearia.Text = "Alterar";
            btAlterarBarbearia.UseVisualStyleBackColor = false;
            // 
            // btExluirBarbearia
            // 
            btExluirBarbearia.BackColor = Color.Crimson;
            btExluirBarbearia.FlatStyle = FlatStyle.Flat;
            btExluirBarbearia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExluirBarbearia.ForeColor = SystemColors.ControlText;
            btExluirBarbearia.Location = new Point(1053, 496);
            btExluirBarbearia.Name = "btExluirBarbearia";
            btExluirBarbearia.Size = new Size(116, 36);
            btExluirBarbearia.TabIndex = 63;
            btExluirBarbearia.Text = "Excluir";
            btExluirBarbearia.UseVisualStyleBackColor = false;
            // 
            // lbDiasHorasFuncionamento
            // 
            lbDiasHorasFuncionamento.AutoSize = true;
            lbDiasHorasFuncionamento.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDiasHorasFuncionamento.Location = new Point(1315, 159);
            lbDiasHorasFuncionamento.Name = "lbDiasHorasFuncionamento";
            lbDiasHorasFuncionamento.Size = new Size(253, 25);
            lbDiasHorasFuncionamento.TabIndex = 65;
            lbDiasHorasFuncionamento.Text = "Dias / Horas Funcionamento";
            // 
            // txtDiasHorasFuncionamento
            // 
            txtDiasHorasFuncionamento.BorderStyle = BorderStyle.FixedSingle;
            txtDiasHorasFuncionamento.Location = new Point(1315, 201);
            txtDiasHorasFuncionamento.Multiline = true;
            txtDiasHorasFuncionamento.Name = "txtDiasHorasFuncionamento";
            txtDiasHorasFuncionamento.ReadOnly = true;
            txtDiasHorasFuncionamento.ScrollBars = ScrollBars.Vertical;
            txtDiasHorasFuncionamento.Size = new Size(402, 185);
            txtDiasHorasFuncionamento.TabIndex = 64;
            // 
            // rbEstaSemana
            // 
            rbEstaSemana.AutoSize = true;
            rbEstaSemana.Location = new Point(995, 282);
            rbEstaSemana.Name = "rbEstaSemana";
            rbEstaSemana.Size = new Size(112, 24);
            rbEstaSemana.TabIndex = 68;
            rbEstaSemana.TabStop = true;
            rbEstaSemana.Text = "Está semana";
            rbEstaSemana.UseVisualStyleBackColor = true;
            // 
            // rbProximaSemana
            // 
            rbProximaSemana.AutoSize = true;
            rbProximaSemana.Location = new Point(1113, 282);
            rbProximaSemana.Name = "rbProximaSemana";
            rbProximaSemana.Size = new Size(139, 24);
            rbProximaSemana.TabIndex = 69;
            rbProximaSemana.TabStop = true;
            rbProximaSemana.Text = "Próxima semana";
            rbProximaSemana.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1741, 888);
            Controls.Add(rbProximaSemana);
            Controls.Add(rbEstaSemana);
            Controls.Add(lbDiasHorasFuncionamento);
            Controls.Add(txtDiasHorasFuncionamento);
            Controls.Add(btExluirBarbearia);
            Controls.Add(btAlterarBarbearia);
            Controls.Add(txtBuscarProdutos);
            Controls.Add(lbPausa);
            Controls.Add(txtPausa);
            Controls.Add(txtFechamento);
            Controls.Add(lbFechamento);
            Controls.Add(lbAbertura);
            Controls.Add(txtAbertura);
            Controls.Add(lbHorariosFuncionamento);
            Controls.Add(btConfirmarBarbearia);
            Controls.Add(ckSabado);
            Controls.Add(ckQuinta);
            Controls.Add(ckSexta);
            Controls.Add(ckQuarta);
            Controls.Add(ckDomingo);
            Controls.Add(ckTerca);
            Controls.Add(lbDiasFuncionamento);
            Controls.Add(ckSugunda);
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
            Controls.Add(txtBuscarCLientesAgendamentos);
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
        private TextBox txtBuscarCLientesAgendamentos;
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
        private CheckBox ckSugunda;
        private Label lbDiasFuncionamento;
        private CheckBox ckTerca;
        private CheckBox ckDomingo;
        private CheckBox ckQuarta;
        private CheckBox ckSexta;
        private CheckBox ckQuinta;
        private CheckBox ckSabado;
        private Button btConfirmarBarbearia;
        private Label lbHorariosFuncionamento;
        private TextBox txtAbertura;
        private Label lbAbertura;
        private Label lbFechamento;
        private TextBox txtFechamento;
        private Label lbPausa;
        private TextBox txtPausa;
        private TextBox txtBuscarProdutos;
        private Button btAlterarBarbearia;
        private Button btExluirBarbearia;
        private Label lbDiasHorasFuncionamento;
        private TextBox txtDiasHorasFuncionamento;
        private RadioButton rbEstaSemana;
        private RadioButton rbProximaSemana;
    }
}
