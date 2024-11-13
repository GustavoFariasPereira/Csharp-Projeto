namespace pjtBarbeariaClientes
{
    partial class frmCadastroClientes
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
            lbNome = new Label();
            txtNome = new TextBox();
            txtAniversario = new TextBox();
            lbAniversario = new Label();
            txtTelefone = new TextBox();
            lbTelefone = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtMensagem = new TextBox();
            txtCadastrados = new TextBox();
            btConfirmar = new Button();
            txtLogin = new TextBox();
            lbLogin = new Label();
            txtSenha = new TextBox();
            lbSenha = new Label();
            btExcluir = new Button();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = SystemColors.Control;
            lbTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.DarkBlue;
            lbTitulo.Location = new Point(410, -1);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(283, 76);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Barbearia\r\nCadastro de Clientes\r\n";
            lbTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(35, 89);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(63, 25);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 120);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(323, 27);
            txtNome.TabIndex = 2;
            // 
            // txtAniversario
            // 
            txtAniversario.Location = new Point(35, 240);
            txtAniversario.Name = "txtAniversario";
            txtAniversario.Size = new Size(139, 27);
            txtAniversario.TabIndex = 4;
            txtAniversario.Text = "28/07/2005";
            txtAniversario.TextAlign = HorizontalAlignment.Center;
            // 
            // lbAniversario
            // 
            lbAniversario.AutoSize = true;
            lbAniversario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAniversario.Location = new Point(35, 209);
            lbAniversario.Name = "lbAniversario";
            lbAniversario.Size = new Size(109, 25);
            lbAniversario.TabIndex = 3;
            lbAniversario.Text = "Aniversário";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(35, 302);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(139, 27);
            txtTelefone.TabIndex = 6;
            txtTelefone.Text = "(13)97777-8888";
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTelefone.Location = new Point(35, 271);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(85, 25);
            lbTelefone.TabIndex = 5;
            lbTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 27);
            txtEmail.TabIndex = 8;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(35, 148);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(65, 25);
            lbEmail.TabIndex = 7;
            lbEmail.Text = "E-mail";
            // 
            // txtMensagem
            // 
            txtMensagem.BackColor = SystemColors.Window;
            txtMensagem.BorderStyle = BorderStyle.FixedSingle;
            txtMensagem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMensagem.ForeColor = Color.MediumSeaGreen;
            txtMensagem.Location = new Point(180, 213);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(178, 116);
            txtMensagem.TabIndex = 9;
            // 
            // txtCadastrados
            // 
            txtCadastrados.Location = new Point(658, 120);
            txtCadastrados.Multiline = true;
            txtCadastrados.Name = "txtCadastrados";
            txtCadastrados.ScrollBars = ScrollBars.Vertical;
            txtCadastrados.Size = new Size(402, 206);
            txtCadastrados.TabIndex = 10;
            txtCadastrados.Visible = false;
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
            txtLogin.Location = new Point(410, 179);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(177, 27);
            txtLogin.TabIndex = 13;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(410, 148);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(59, 25);
            lbLogin.TabIndex = 12;
            lbLogin.Text = "Login";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(410, 240);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(177, 27);
            txtSenha.TabIndex = 15;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSenha.Location = new Point(410, 209);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(64, 25);
            lbSenha.TabIndex = 14;
            lbSenha.Text = "Senha";
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
            btExcluir.Visible = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // frmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 450);
            Controls.Add(btExcluir);
            Controls.Add(txtSenha);
            Controls.Add(lbSenha);
            Controls.Add(txtLogin);
            Controls.Add(lbLogin);
            Controls.Add(btConfirmar);
            Controls.Add(txtCadastrados);
            Controls.Add(txtMensagem);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtTelefone);
            Controls.Add(lbTelefone);
            Controls.Add(txtAniversario);
            Controls.Add(lbAniversario);
            Controls.Add(txtNome);
            Controls.Add(lbNome);
            Controls.Add(lbTitulo);
            Name = "frmCadastroClientes";
            Text = "Cadastro de Clientes";
            Load += frmCadastroClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Label lbNome;
        private TextBox txtNome;
        private TextBox txtAniversario;
        private Label lbAniversario;
        private TextBox txtTelefone;
        private Label lbTelefone;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtMensagem;
        private TextBox txtCadastrados;
        private Button btConfirmar;
        private TextBox txtLogin;
        private Label lbLogin;
        private TextBox txtSenha;
        private Label lbSenha;
        private Button btExcluir;
    }
}
