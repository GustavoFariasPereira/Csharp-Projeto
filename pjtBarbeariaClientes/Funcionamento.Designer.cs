namespace pjtBarbeariaClientes
{
    partial class frmFuncionamento
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
            rbProximaSemana = new RadioButton();
            rbEstaSemana = new RadioButton();
            btExluir = new Button();
            lbPausa = new Label();
            txtPausa = new TextBox();
            txtFechamento = new TextBox();
            lbFechamento = new Label();
            lbAbertura = new Label();
            txtAbertura = new TextBox();
            btSalvar = new Button();
            ckSabado = new CheckBox();
            ckQuinta = new CheckBox();
            ckSexta = new CheckBox();
            ckQuarta = new CheckBox();
            ckDomingo = new CheckBox();
            ckTerca = new CheckBox();
            lbDiasFuncionamento = new Label();
            ckSegunda = new CheckBox();
            txtDiasHorasFuncionamento = new TextBox();
            gbFuncionamento = new GroupBox();
            rbFechado = new RadioButton();
            rbAberto = new RadioButton();
            gbSemana = new GroupBox();
            lbTitulo = new Label();
            gbDias = new GroupBox();
            txtBuscarDia = new TextBox();
            btAlterar = new Button();
            btBuscar = new Button();
            lbDia = new Label();
            txtDia = new TextBox();
            btCancelar = new Button();
            rbSemanaA = new RadioButton();
            rbSemanaB = new RadioButton();
            lbResultado = new Label();
            gbFuncionamento.SuspendLayout();
            gbSemana.SuspendLayout();
            gbDias.SuspendLayout();
            SuspendLayout();
            // 
            // rbProximaSemana
            // 
            rbProximaSemana.AutoSize = true;
            rbProximaSemana.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbProximaSemana.Location = new Point(6, 70);
            rbProximaSemana.Name = "rbProximaSemana";
            rbProximaSemana.Size = new Size(146, 24);
            rbProximaSemana.TabIndex = 89;
            rbProximaSemana.TabStop = true;
            rbProximaSemana.Text = "Próxima semana";
            rbProximaSemana.UseVisualStyleBackColor = true;
            rbProximaSemana.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rbEstaSemana
            // 
            rbEstaSemana.AutoSize = true;
            rbEstaSemana.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbEstaSemana.Location = new Point(6, 40);
            rbEstaSemana.Name = "rbEstaSemana";
            rbEstaSemana.Size = new Size(117, 24);
            rbEstaSemana.TabIndex = 88;
            rbEstaSemana.TabStop = true;
            rbEstaSemana.Text = "Está semana";
            rbEstaSemana.UseVisualStyleBackColor = true;
            rbEstaSemana.CheckedChanged += radioButton_CheckedChanged;
            // 
            // btExluir
            // 
            btExluir.BackColor = Color.Crimson;
            btExluir.FlatStyle = FlatStyle.Flat;
            btExluir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExluir.ForeColor = SystemColors.ControlText;
            btExluir.Location = new Point(172, 504);
            btExluir.Name = "btExluir";
            btExluir.Size = new Size(116, 36);
            btExluir.TabIndex = 87;
            btExluir.Text = "Excluir";
            btExluir.UseVisualStyleBackColor = false;
            // 
            // lbPausa
            // 
            lbPausa.AutoSize = true;
            lbPausa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPausa.Location = new Point(31, 414);
            lbPausa.Name = "lbPausa";
            lbPausa.Size = new Size(67, 25);
            lbPausa.TabIndex = 85;
            lbPausa.Text = "Pausa:";
            // 
            // txtPausa
            // 
            txtPausa.BorderStyle = BorderStyle.FixedSingle;
            txtPausa.Enabled = false;
            txtPausa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPausa.Location = new Point(153, 416);
            txtPausa.Name = "txtPausa";
            txtPausa.Size = new Size(91, 31);
            txtPausa.TabIndex = 84;
            txtPausa.Text = "---";
            txtPausa.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFechamento
            // 
            txtFechamento.BorderStyle = BorderStyle.FixedSingle;
            txtFechamento.Enabled = false;
            txtFechamento.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFechamento.Location = new Point(153, 457);
            txtFechamento.Name = "txtFechamento";
            txtFechamento.Size = new Size(91, 31);
            txtFechamento.TabIndex = 83;
            txtFechamento.Text = "---";
            txtFechamento.TextAlign = HorizontalAlignment.Center;
            // 
            // lbFechamento
            // 
            lbFechamento.AutoSize = true;
            lbFechamento.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFechamento.Location = new Point(31, 455);
            lbFechamento.Name = "lbFechamento";
            lbFechamento.Size = new Size(121, 25);
            lbFechamento.TabIndex = 82;
            lbFechamento.Text = "Fechamento:";
            // 
            // lbAbertura
            // 
            lbAbertura.AutoSize = true;
            lbAbertura.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAbertura.Location = new Point(31, 373);
            lbAbertura.Name = "lbAbertura";
            lbAbertura.Size = new Size(94, 25);
            lbAbertura.TabIndex = 81;
            lbAbertura.Text = "Abertura:";
            // 
            // txtAbertura
            // 
            txtAbertura.BorderStyle = BorderStyle.FixedSingle;
            txtAbertura.Enabled = false;
            txtAbertura.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAbertura.Location = new Point(153, 375);
            txtAbertura.Name = "txtAbertura";
            txtAbertura.Size = new Size(91, 31);
            txtAbertura.TabIndex = 80;
            txtAbertura.Text = "---";
            txtAbertura.TextAlign = HorizontalAlignment.Center;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.MediumSeaGreen;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvar.ForeColor = SystemColors.ControlText;
            btSalvar.Location = new Point(36, 505);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(116, 36);
            btSalvar.TabIndex = 78;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // ckSabado
            // 
            ckSabado.AutoSize = true;
            ckSabado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckSabado.Location = new Point(223, 65);
            ckSabado.Name = "ckSabado";
            ckSabado.Size = new Size(82, 24);
            ckSabado.TabIndex = 77;
            ckSabado.Text = "Sabado";
            ckSabado.UseVisualStyleBackColor = true;
            ckSabado.CheckedChanged += checkBox_CheckedChanged;
            // 
            // ckQuinta
            // 
            ckQuinta.AutoSize = true;
            ckQuinta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckQuinta.Location = new Point(9, 65);
            ckQuinta.Name = "ckQuinta";
            ckQuinta.Size = new Size(78, 24);
            ckQuinta.TabIndex = 76;
            ckQuinta.Text = "Quinta";
            ckQuinta.UseVisualStyleBackColor = true;
            ckQuinta.CheckedChanged += checkBox_CheckedChanged;
            // 
            // ckSexta
            // 
            ckSexta.AutoSize = true;
            ckSexta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckSexta.Location = new Point(116, 65);
            ckSexta.Name = "ckSexta";
            ckSexta.Size = new Size(69, 24);
            ckSexta.TabIndex = 75;
            ckSexta.Text = "Sexta";
            ckSexta.UseVisualStyleBackColor = true;
            ckSexta.CheckedChanged += checkBox_CheckedChanged;
            // 
            // ckQuarta
            // 
            ckQuarta.AutoSize = true;
            ckQuarta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckQuarta.Location = new Point(223, 35);
            ckQuarta.Name = "ckQuarta";
            ckQuarta.Size = new Size(79, 24);
            ckQuarta.TabIndex = 74;
            ckQuarta.Text = "Quarta";
            ckQuarta.UseVisualStyleBackColor = true;
            ckQuarta.CheckedChanged += checkBox_CheckedChanged;
            // 
            // ckDomingo
            // 
            ckDomingo.AutoSize = true;
            ckDomingo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckDomingo.Location = new Point(9, 95);
            ckDomingo.Name = "ckDomingo";
            ckDomingo.Size = new Size(96, 24);
            ckDomingo.TabIndex = 73;
            ckDomingo.Text = "Domingo";
            ckDomingo.UseVisualStyleBackColor = true;
            ckDomingo.CheckedChanged += checkBox_CheckedChanged;
            // 
            // ckTerca
            // 
            ckTerca.AutoSize = true;
            ckTerca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckTerca.Location = new Point(116, 35);
            ckTerca.Name = "ckTerca";
            ckTerca.Size = new Size(68, 24);
            ckTerca.TabIndex = 72;
            ckTerca.Text = "Terça";
            ckTerca.UseVisualStyleBackColor = true;
            ckTerca.CheckedChanged += checkBox_CheckedChanged;
            // 
            // lbDiasFuncionamento
            // 
            lbDiasFuncionamento.AutoSize = true;
            lbDiasFuncionamento.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbDiasFuncionamento.Location = new Point(531, 29);
            lbDiasFuncionamento.Name = "lbDiasFuncionamento";
            lbDiasFuncionamento.Size = new Size(254, 30);
            lbDiasFuncionamento.TabIndex = 71;
            lbDiasFuncionamento.Text = "Dias de Funcionamento";
            // 
            // ckSegunda
            // 
            ckSegunda.AutoSize = true;
            ckSegunda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckSegunda.Location = new Point(9, 35);
            ckSegunda.Name = "ckSegunda";
            ckSegunda.Size = new Size(91, 24);
            ckSegunda.TabIndex = 70;
            ckSegunda.Text = "Segunda";
            ckSegunda.UseVisualStyleBackColor = true;
            ckSegunda.CheckedChanged += checkBox_CheckedChanged;
            // 
            // txtDiasHorasFuncionamento
            // 
            txtDiasHorasFuncionamento.BorderStyle = BorderStyle.FixedSingle;
            txtDiasHorasFuncionamento.Location = new Point(531, 62);
            txtDiasHorasFuncionamento.Multiline = true;
            txtDiasHorasFuncionamento.Name = "txtDiasHorasFuncionamento";
            txtDiasHorasFuncionamento.ReadOnly = true;
            txtDiasHorasFuncionamento.ScrollBars = ScrollBars.Vertical;
            txtDiasHorasFuncionamento.Size = new Size(402, 185);
            txtDiasHorasFuncionamento.TabIndex = 90;
            // 
            // gbFuncionamento
            // 
            gbFuncionamento.Controls.Add(rbFechado);
            gbFuncionamento.Controls.Add(rbAberto);
            gbFuncionamento.Enabled = false;
            gbFuncionamento.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFuncionamento.Location = new Point(271, 211);
            gbFuncionamento.Name = "gbFuncionamento";
            gbFuncionamento.Size = new Size(203, 88);
            gbFuncionamento.TabIndex = 92;
            gbFuncionamento.TabStop = false;
            gbFuncionamento.Text = "Funcionamento";
            // 
            // rbFechado
            // 
            rbFechado.AutoSize = true;
            rbFechado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFechado.Location = new Point(104, 40);
            rbFechado.Name = "rbFechado";
            rbFechado.Size = new Size(88, 24);
            rbFechado.TabIndex = 94;
            rbFechado.TabStop = true;
            rbFechado.Text = "Fechado";
            rbFechado.UseVisualStyleBackColor = true;
            // 
            // rbAberto
            // 
            rbAberto.AutoSize = true;
            rbAberto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbAberto.Location = new Point(6, 40);
            rbAberto.Name = "rbAberto";
            rbAberto.Size = new Size(79, 24);
            rbAberto.TabIndex = 93;
            rbAberto.TabStop = true;
            rbAberto.Text = "Aberto";
            rbAberto.UseVisualStyleBackColor = true;
            rbAberto.CheckedChanged += radioButton_CheckedChanged;
            // 
            // gbSemana
            // 
            gbSemana.Controls.Add(rbEstaSemana);
            gbSemana.Controls.Add(rbProximaSemana);
            gbSemana.Enabled = false;
            gbSemana.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbSemana.Location = new Point(31, 211);
            gbSemana.Name = "gbSemana";
            gbSemana.Size = new Size(203, 125);
            gbSemana.TabIndex = 95;
            gbSemana.TabStop = false;
            gbSemana.Text = "Semana";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = SystemColors.Control;
            lbTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.DarkBlue;
            lbTitulo.Location = new Point(781, 511);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(165, 62);
            lbTitulo.TabIndex = 96;
            lbTitulo.Text = "Barbearia\r\nBarba de Gato\r\n";
            lbTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // gbDias
            // 
            gbDias.Controls.Add(ckSegunda);
            gbDias.Controls.Add(ckTerca);
            gbDias.Controls.Add(ckDomingo);
            gbDias.Controls.Add(ckQuarta);
            gbDias.Controls.Add(ckSexta);
            gbDias.Controls.Add(ckQuinta);
            gbDias.Controls.Add(ckSabado);
            gbDias.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDias.Location = new Point(31, 38);
            gbDias.Name = "gbDias";
            gbDias.Size = new Size(309, 133);
            gbDias.TabIndex = 97;
            gbDias.TabStop = false;
            gbDias.Text = "Dias";
            // 
            // txtBuscarDia
            // 
            txtBuscarDia.BackColor = SystemColors.Window;
            txtBuscarDia.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarDia.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarDia.ForeColor = Color.DarkBlue;
            txtBuscarDia.Location = new Point(531, 387);
            txtBuscarDia.Multiline = true;
            txtBuscarDia.Name = "txtBuscarDia";
            txtBuscarDia.ReadOnly = true;
            txtBuscarDia.ScrollBars = ScrollBars.Vertical;
            txtBuscarDia.Size = new Size(329, 79);
            txtBuscarDia.TabIndex = 102;
            txtBuscarDia.Text = "Buscar dia.";
            // 
            // btAlterar
            // 
            btAlterar.BackColor = SystemColors.ActiveBorder;
            btAlterar.Enabled = false;
            btAlterar.FlatStyle = FlatStyle.Flat;
            btAlterar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterar.ForeColor = SystemColors.ControlText;
            btAlterar.Location = new Point(762, 338);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(116, 37);
            btAlterar.TabIndex = 101;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = false;
            // 
            // btBuscar
            // 
            btBuscar.BackColor = SystemColors.ActiveCaption;
            btBuscar.FlatStyle = FlatStyle.Flat;
            btBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBuscar.ForeColor = SystemColors.ControlText;
            btBuscar.Location = new Point(629, 338);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(116, 36);
            btBuscar.TabIndex = 100;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = false;
            // 
            // lbDia
            // 
            lbDia.AutoSize = true;
            lbDia.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDia.Location = new Point(531, 316);
            lbDia.Name = "lbDia";
            lbDia.Size = new Size(40, 25);
            lbDia.TabIndex = 99;
            lbDia.Text = "Dia";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(531, 344);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(74, 27);
            txtDia.TabIndex = 98;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = SystemColors.Highlight;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.ForeColor = SystemColors.ControlText;
            btCancelar.Location = new Point(309, 504);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(116, 37);
            btCancelar.TabIndex = 103;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            // 
            // rbSemanaA
            // 
            rbSemanaA.AutoSize = true;
            rbSemanaA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbSemanaA.Location = new Point(531, 253);
            rbSemanaA.Name = "rbSemanaA";
            rbSemanaA.Size = new Size(100, 24);
            rbSemanaA.TabIndex = 95;
            rbSemanaA.Text = "Semana A";
            rbSemanaA.UseVisualStyleBackColor = true;
            // 
            // rbSemanaB
            // 
            rbSemanaB.AutoSize = true;
            rbSemanaB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbSemanaB.Location = new Point(637, 253);
            rbSemanaB.Name = "rbSemanaB";
            rbSemanaB.Size = new Size(99, 24);
            rbSemanaB.TabIndex = 104;
            rbSemanaB.Text = "Semana B";
            rbSemanaB.UseVisualStyleBackColor = true;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbResultado.Location = new Point(31, 343);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(27, 25);
            lbResultado.TabIndex = 105;
            lbResultado.Text = "...";
            // 
            // frmFuncionamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 592);
            Controls.Add(lbResultado);
            Controls.Add(rbSemanaB);
            Controls.Add(rbSemanaA);
            Controls.Add(btCancelar);
            Controls.Add(txtBuscarDia);
            Controls.Add(btAlterar);
            Controls.Add(btBuscar);
            Controls.Add(lbDia);
            Controls.Add(txtDia);
            Controls.Add(gbDias);
            Controls.Add(lbTitulo);
            Controls.Add(gbSemana);
            Controls.Add(gbFuncionamento);
            Controls.Add(txtDiasHorasFuncionamento);
            Controls.Add(btExluir);
            Controls.Add(lbPausa);
            Controls.Add(txtPausa);
            Controls.Add(txtFechamento);
            Controls.Add(lbFechamento);
            Controls.Add(lbAbertura);
            Controls.Add(txtAbertura);
            Controls.Add(btSalvar);
            Controls.Add(lbDiasFuncionamento);
            Name = "frmFuncionamento";
            Text = "Funcionamento";
            Load += frmFuncionamento_Load;
            gbFuncionamento.ResumeLayout(false);
            gbFuncionamento.PerformLayout();
            gbSemana.ResumeLayout(false);
            gbSemana.PerformLayout();
            gbDias.ResumeLayout(false);
            gbDias.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbProximaSemana;
        private RadioButton rbEstaSemana;
        private Button btExluir;
        private Label lbPausa;
        private TextBox txtPausa;
        private TextBox txtFechamento;
        private Label lbFechamento;
        private Label lbAbertura;
        private TextBox txtAbertura;
        private Button btSalvar;
        private CheckBox ckSabado;
        private CheckBox ckQuinta;
        private CheckBox ckSexta;
        private CheckBox ckQuarta;
        private CheckBox ckDomingo;
        private CheckBox ckTerca;
        private Label lbDiasFuncionamento;
        private CheckBox ckSegunda;
        private TextBox txtDiasHorasFuncionamento;
        private GroupBox gbFuncionamento;
        private RadioButton rbFechado;
        private RadioButton rbAberto;
        private GroupBox gbSemana;
        private Label lbTitulo;
        private GroupBox gbDias;
        private TextBox txtBuscarDia;
        private Button btAlterar;
        private Button btBuscar;
        private Label lbDia;
        private TextBox txtDia;
        private Button btCancelar;
        private RadioButton rbSemanaA;
        private RadioButton rbSemanaB;
        private Label lbResultado;
    }
}