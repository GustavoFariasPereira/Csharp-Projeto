﻿namespace pjtBarbeariaClientes
{
    partial class frmLogin
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
            lbTitulo = new Label();
            txtSenha = new TextBox();
            lbSenha = new Label();
            txtLogin = new TextBox();
            lbLogin = new Label();
            btEntrar = new Button();
            lbCadastrar = new Label();
            btSair = new Button();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = SystemColors.Control;
            lbTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.DarkBlue;
            lbTitulo.Location = new Point(177, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(204, 76);
            lbTitulo.TabIndex = 1;
            lbTitulo.Text = "Barbearia\r\nBarba de Gato\r\n";
            lbTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(191, 239);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(177, 27);
            txtSenha.TabIndex = 19;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSenha.Location = new Point(191, 208);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(64, 25);
            lbSenha.TabIndex = 18;
            lbSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(191, 178);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(177, 27);
            txtLogin.TabIndex = 17;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(191, 147);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(59, 25);
            lbLogin.TabIndex = 16;
            lbLogin.Text = "Login";
            // 
            // btEntrar
            // 
            btEntrar.BackColor = Color.MediumSeaGreen;
            btEntrar.FlatStyle = FlatStyle.Flat;
            btEntrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEntrar.ForeColor = SystemColors.ControlText;
            btEntrar.Location = new Point(218, 327);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(116, 36);
            btEntrar.TabIndex = 20;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = false;
            btEntrar.Click += btEntrar_Click;
            // 
            // lbCadastrar
            // 
            lbCadastrar.AutoSize = true;
            lbCadastrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastrar.Location = new Point(217, 284);
            lbCadastrar.Name = "lbCadastrar";
            lbCadastrar.Size = new Size(117, 25);
            lbCadastrar.TabIndex = 21;
            lbCadastrar.Text = "Cadastrar-se";
            lbCadastrar.Click += lbCadastrar_Click;
            // 
            // btSair
            // 
            btSair.BackColor = Color.FromArgb(192, 0, 0);
            btSair.FlatStyle = FlatStyle.Flat;
            btSair.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSair.ForeColor = SystemColors.ControlLight;
            btSair.Location = new Point(550, 9);
            btSair.Name = "btSair";
            btSair.Size = new Size(40, 36);
            btSair.TabIndex = 22;
            btSair.Text = "X";
            btSair.UseVisualStyleBackColor = false;
            btSair.Click += btSair_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 450);
            Controls.Add(btSair);
            Controls.Add(lbCadastrar);
            Controls.Add(btEntrar);
            Controls.Add(txtSenha);
            Controls.Add(lbSenha);
            Controls.Add(txtLogin);
            Controls.Add(lbLogin);
            Controls.Add(lbTitulo);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private TextBox txtSenha;
        private Label lbSenha;
        private TextBox txtLogin;
        private Label lbLogin;
        private Button btEntrar;
        private Label lbCadastrar;
        private Button btSair;
    }
}