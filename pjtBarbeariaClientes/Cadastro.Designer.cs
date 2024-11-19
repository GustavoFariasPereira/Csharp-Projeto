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
            lbTitulo = new Label();
            txtMensagem = new TextBox();
            txtCadastrados = new TextBox();
            btConfirmar = new Button();
            txtLogin = new TextBox();
            lbLogin = new Label();
            btExcluir = new Button();
            mnIrPara = new MenuStrip();
            irParaToolStripMenuItem = new ToolStripMenuItem();
            miLogin = new ToolStripMenuItem();
            miCadastro = new ToolStripMenuItem();
            mnIrPara.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = SystemColors.Control;
            lbTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.DarkBlue;
            lbTitulo.Location = new Point(407, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(283, 76);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Barbearia\r\nCadastro de Clientes\r\n";
            lbTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMensagem
            // 
            txtMensagem.BackColor = SystemColors.Window;
            txtMensagem.BorderStyle = BorderStyle.FixedSingle;
            txtMensagem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMensagem.ForeColor = Color.MediumSeaGreen;
            txtMensagem.Location = new Point(107, 224);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.ReadOnly = true;
            txtMensagem.Size = new Size(178, 116);
            txtMensagem.TabIndex = 9;
            // 
            // txtCadastrados
            // 
            txtCadastrados.Location = new Point(417, 176);
            txtCadastrados.Multiline = true;
            txtCadastrados.Name = "txtCadastrados";
            txtCadastrados.ReadOnly = true;
            txtCadastrados.ScrollBars = ScrollBars.Vertical;
            txtCadastrados.Size = new Size(402, 206);
            txtCadastrados.TabIndex = 10;
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.MediumSeaGreen;
            btConfirmar.FlatStyle = FlatStyle.Flat;
            btConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btConfirmar.ForeColor = SystemColors.ControlText;
            btConfirmar.Location = new Point(68, 346);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(116, 36);
            btConfirmar.TabIndex = 11;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(107, 187);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(178, 27);
            txtLogin.TabIndex = 13;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(107, 156);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(59, 25);
            lbLogin.TabIndex = 12;
            lbLogin.Text = "Login";
            // 
            // btExcluir
            // 
            btExcluir.BackColor = Color.Crimson;
            btExcluir.FlatStyle = FlatStyle.Flat;
            btExcluir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluir.ForeColor = SystemColors.ControlText;
            btExcluir.Location = new Point(200, 346);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(116, 36);
            btExcluir.TabIndex = 16;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // mnIrPara
            // 
            mnIrPara.ImageScalingSize = new Size(20, 20);
            mnIrPara.Items.AddRange(new ToolStripItem[] { irParaToolStripMenuItem });
            mnIrPara.Location = new Point(0, 0);
            mnIrPara.Name = "mnIrPara";
            mnIrPara.Size = new Size(1092, 28);
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
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 450);
            Controls.Add(btExcluir);
            Controls.Add(txtLogin);
            Controls.Add(lbLogin);
            Controls.Add(btConfirmar);
            Controls.Add(txtCadastrados);
            Controls.Add(txtMensagem);
            Controls.Add(lbTitulo);
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

        private Label lbTitulo;
        private TextBox txtMensagem;
        private TextBox txtCadastrados;
        private Button btConfirmar;
        private TextBox txtLogin;
        private Label lbLogin;
        private Button btExcluir;
        private MenuStrip mnIrPara;
        private ToolStripMenuItem irParaToolStripMenuItem;
        private ToolStripMenuItem miLogin;
        private ToolStripMenuItem miCadastro;
    }
}
