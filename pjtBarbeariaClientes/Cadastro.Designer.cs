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
            label1 = new Label();
            lbNome = new Label();
            txtNome = new TextBox();
            txtDataNascimento = new TextBox();
            lbDataNascimento = new Label();
            txtTelefone = new TextBox();
            lbTelefone = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtMensagem = new TextBox();
            txtCadastrados = new TextBox();
            btConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 76);
            label1.TabIndex = 0;
            label1.Text = "Barbearia\r\nCadastro de Clientes\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(32, 98);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(69, 28);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(32, 129);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(307, 27);
            txtNome.TabIndex = 2;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(32, 187);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(123, 27);
            txtDataNascimento.TabIndex = 4;
            // 
            // lbDataNascimento
            // 
            lbDataNascimento.AutoSize = true;
            lbDataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDataNascimento.Location = new Point(32, 156);
            lbDataNascimento.Name = "lbDataNascimento";
            lbDataNascimento.Size = new Size(205, 28);
            lbDataNascimento.TabIndex = 3;
            lbDataNascimento.Text = "Data de Nascimento";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(32, 248);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(123, 27);
            txtTelefone.TabIndex = 6;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTelefone.Location = new Point(32, 217);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(93, 28);
            lbTelefone.TabIndex = 5;
            lbTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(32, 309);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(307, 27);
            txtEmail.TabIndex = 8;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(32, 278);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(72, 28);
            lbEmail.TabIndex = 7;
            lbEmail.Text = "E-mail";
            // 
            // txtMensagem
            // 
            txtMensagem.BorderStyle = BorderStyle.FixedSingle;
            txtMensagem.Location = new Point(170, 187);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(169, 116);
            txtMensagem.TabIndex = 9;
            // 
            // txtCadastrados
            // 
            txtCadastrados.Location = new Point(357, 130);
            txtCadastrados.Multiline = true;
            txtCadastrados.Name = "txtCadastrados";
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
            btConfirmar.Location = new Point(39, 342);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(116, 36);
            btConfirmar.TabIndex = 11;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += this.btConfirmar_Click;
            // 
            // frmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btConfirmar);
            Controls.Add(txtCadastrados);
            Controls.Add(txtMensagem);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtTelefone);
            Controls.Add(lbTelefone);
            Controls.Add(txtDataNascimento);
            Controls.Add(lbDataNascimento);
            Controls.Add(txtNome);
            Controls.Add(lbNome);
            Controls.Add(label1);
            Name = "frmCadastroClientes";
            Text = "Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbNome;
        private TextBox txtNome;
        private TextBox txtDataNascimento;
        private Label lbDataNascimento;
        private TextBox txtTelefone;
        private Label lbTelefone;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtMensagem;
        private TextBox txtCadastrados;
        private Button btConfirmar;
    }
}
