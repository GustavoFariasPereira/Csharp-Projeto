namespace pjtBarbeariaClientes
{
    partial class frmCadastroCLiente
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
            txtMensagem = new TextBox();
            btConfirmar = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(33, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 27);
            txtEmail.TabIndex = 16;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(33, 94);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(65, 25);
            lbEmail.TabIndex = 15;
            lbEmail.Text = "E-mail";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(33, 248);
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
            lbTelefone.Location = new Point(33, 217);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(85, 25);
            lbTelefone.TabIndex = 13;
            lbTelefone.Text = "Telefone";
            // 
            // txtAniversario
            // 
            txtAniversario.Location = new Point(33, 186);
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
            lbAniversario.Location = new Point(33, 155);
            lbAniversario.Name = "lbAniversario";
            lbAniversario.Size = new Size(109, 25);
            lbAniversario.TabIndex = 11;
            lbAniversario.Text = "Aniversário";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(33, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(323, 27);
            txtNome.TabIndex = 10;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(33, 35);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(63, 25);
            lbNome.TabIndex = 9;
            lbNome.Text = "Nome";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(33, 370);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(177, 27);
            txtSenha.TabIndex = 20;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSenha.Location = new Point(33, 339);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(64, 25);
            lbSenha.TabIndex = 19;
            lbSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(33, 309);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(177, 27);
            txtLogin.TabIndex = 18;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(33, 278);
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
            lbTitulo.Location = new Point(469, 66);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(204, 76);
            lbTitulo.TabIndex = 21;
            lbTitulo.Text = "Barbearia\r\nBarba de Gato";
            lbTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMensagem
            // 
            txtMensagem.BackColor = SystemColors.Window;
            txtMensagem.BorderStyle = BorderStyle.FixedSingle;
            txtMensagem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMensagem.ForeColor = Color.MediumSeaGreen;
            txtMensagem.Location = new Point(469, 159);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.ReadOnly = true;
            txtMensagem.Size = new Size(204, 116);
            txtMensagem.TabIndex = 22;
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.MediumSeaGreen;
            btConfirmar.FlatStyle = FlatStyle.Flat;
            btConfirmar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btConfirmar.ForeColor = SystemColors.ControlText;
            btConfirmar.Location = new Point(240, 334);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(116, 36);
            btConfirmar.TabIndex = 23;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // frmCadastroCLiente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 450);
            Controls.Add(btConfirmar);
            Controls.Add(txtMensagem);
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
            Name = "frmCadastroCLiente";
            Text = "Cadastro";
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
        private TextBox txtMensagem;
        private Button btConfirmar;
    }
}