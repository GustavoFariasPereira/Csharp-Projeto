namespace pjtBarbeariaClientes
{
    partial class frmCadastroCliente
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
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtTelefone = new TextBox();
            lbTelefone = new Label();
            txtAniversario = new TextBox();
            lbAniversario = new Label();
            txtNome = new TextBox();
            lbNome = new Label();
            txtSenha = new TextBox();
            lbSenha = new Label();
            txtLogin = new TextBox();
            lbLogin = new Label();
            lbTitulo = new Label();
            btConfirmar = new Button();
            lbMensagem = new Label();
            btVoltarLogin = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 27);
            txtEmail.TabIndex = 16;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(92, 181);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(65, 25);
            lbEmail.TabIndex = 15;
            lbEmail.Text = "E-mail";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(92, 335);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(139, 27);
            txtTelefone.TabIndex = 14;
            txtTelefone.Text = "13977778888";
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTelefone.Location = new Point(92, 304);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(85, 25);
            lbTelefone.TabIndex = 13;
            lbTelefone.Text = "Telefone";
            // 
            // txtAniversario
            // 
            txtAniversario.Location = new Point(92, 273);
            txtAniversario.Name = "txtAniversario";
            txtAniversario.Size = new Size(139, 27);
            txtAniversario.TabIndex = 12;
            txtAniversario.Text = "28/07/2005";
            txtAniversario.TextAlign = HorizontalAlignment.Center;
            // 
            // lbAniversario
            // 
            lbAniversario.AutoSize = true;
            lbAniversario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAniversario.Location = new Point(92, 242);
            lbAniversario.Name = "lbAniversario";
            lbAniversario.Size = new Size(109, 25);
            lbAniversario.TabIndex = 11;
            lbAniversario.Text = "Aniversário";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(92, 153);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(323, 27);
            txtNome.TabIndex = 10;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(92, 122);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(63, 25);
            lbNome.TabIndex = 9;
            lbNome.Text = "Nome";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(92, 457);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(177, 27);
            txtSenha.TabIndex = 20;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSenha.Location = new Point(92, 426);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(64, 25);
            lbSenha.TabIndex = 19;
            lbSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(92, 396);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(177, 27);
            txtLogin.TabIndex = 18;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(92, 365);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(59, 25);
            lbLogin.TabIndex = 17;
            lbLogin.Text = "Login";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = SystemColors.Control;
            lbTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.DarkBlue;
            lbTitulo.Location = new Point(146, 20);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(204, 76);
            lbTitulo.TabIndex = 21;
            lbTitulo.Text = "Barbearia\r\nBarba de Gato";
            lbTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.MediumSeaGreen;
            btConfirmar.FlatStyle = FlatStyle.Flat;
            btConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btConfirmar.ForeColor = SystemColors.ControlText;
            btConfirmar.Location = new Point(299, 421);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(116, 36);
            btConfirmar.TabIndex = 23;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMensagem.ForeColor = Color.DarkBlue;
            lbMensagem.Location = new Point(300, 469);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(0, 25);
            lbMensagem.TabIndex = 24;
            // 
            // btVoltarLogin
            // 
            btVoltarLogin.BackColor = SystemColors.ActiveCaption;
            btVoltarLogin.FlatStyle = FlatStyle.Flat;
            btVoltarLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btVoltarLogin.ForeColor = SystemColors.ControlText;
            btVoltarLogin.Location = new Point(447, 12);
            btVoltarLogin.Name = "btVoltarLogin";
            btVoltarLogin.Size = new Size(75, 32);
            btVoltarLogin.TabIndex = 25;
            btVoltarLogin.Text = "Voltar";
            btVoltarLogin.UseVisualStyleBackColor = false;
            btVoltarLogin.Click += btVoltarLogin_Click;
            // 
            // frmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 540);
            Controls.Add(btVoltarLogin);
            Controls.Add(lbMensagem);
            Controls.Add(btConfirmar);
            Controls.Add(lbTitulo);
            Controls.Add(txtSenha);
            Controls.Add(lbSenha);
            Controls.Add(txtLogin);
            Controls.Add(lbLogin);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtTelefone);
            Controls.Add(lbTelefone);
            Controls.Add(txtAniversario);
            Controls.Add(lbAniversario);
            Controls.Add(txtNome);
            Controls.Add(lbNome);
            Name = "frmCadastroCliente";
            Text = "Cadastro";
            Load += frmCadastroCLiente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtTelefone;
        private Label lbTelefone;
        private TextBox txtAniversario;
        private Label lbAniversario;
        private TextBox txtNome;
        private Label lbNome;
        private TextBox txtSenha;
        private Label lbSenha;
        private TextBox txtLogin;
        private Label lbLogin;
        private Label lbTitulo;
        private Button btConfirmar;
        private Label lbMensagem;
        private Button btVoltarLogin;
    }
}