﻿namespace pjtBarbeariaClientes
{
    partial class frmProduto
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
            lbProdutos = new Label();
            txtProdutos = new TextBox();
            btCadastrar = new Button();
            lbValor = new Label();
            txtValor = new TextBox();
            lbProduto = new Label();
            txtProduto = new TextBox();
            lbCadastrarProduto = new Label();
            txtBuscarProdutos = new TextBox();
            btAlterarProduto = new Button();
            btExcluir = new Button();
            btBuscarProduto = new Button();
            lbProdutoCodigo = new Label();
            txtProdutoCodigo = new TextBox();
            lbTitulo = new Label();
            btCancelar = new Button();
            btSalvar = new Button();
            SuspendLayout();
            // 
            // lbProdutos
            // 
            lbProdutos.AutoSize = true;
            lbProdutos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProdutos.Location = new Point(469, 41);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(89, 25);
            lbProdutos.TabIndex = 39;
            lbProdutos.Text = "Produtos";
            // 
            // txtProdutos
            // 
            txtProdutos.BorderStyle = BorderStyle.FixedSingle;
            txtProdutos.Location = new Point(469, 83);
            txtProdutos.Multiline = true;
            txtProdutos.Name = "txtProdutos";
            txtProdutos.ReadOnly = true;
            txtProdutos.ScrollBars = ScrollBars.Vertical;
            txtProdutos.Size = new Size(306, 149);
            txtProdutos.TabIndex = 38;
            // 
            // btCadastrar
            // 
            btCadastrar.BackColor = Color.MediumSeaGreen;
            btCadastrar.FlatStyle = FlatStyle.Flat;
            btCadastrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCadastrar.ForeColor = SystemColors.ControlText;
            btCadastrar.Location = new Point(26, 195);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(116, 36);
            btCadastrar.TabIndex = 37;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = false;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbValor.Location = new Point(272, 124);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(56, 25);
            lbValor.TabIndex = 36;
            lbValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(272, 152);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(116, 27);
            txtValor.TabIndex = 35;
            // 
            // lbProduto
            // 
            lbProduto.AutoSize = true;
            lbProduto.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProduto.Location = new Point(26, 124);
            lbProduto.Name = "lbProduto";
            lbProduto.Size = new Size(81, 25);
            lbProduto.TabIndex = 34;
            lbProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(26, 152);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(198, 27);
            txtProduto.TabIndex = 32;
            // 
            // lbCadastrarProduto
            // 
            lbCadastrarProduto.AutoSize = true;
            lbCadastrarProduto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastrarProduto.Location = new Point(26, 35);
            lbCadastrarProduto.Name = "lbCadastrarProduto";
            lbCadastrarProduto.Size = new Size(209, 31);
            lbCadastrarProduto.TabIndex = 33;
            lbCadastrarProduto.Text = "Cadastrar Produto";
            // 
            // txtBuscarProdutos
            // 
            txtBuscarProdutos.BackColor = SystemColors.Window;
            txtBuscarProdutos.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarProdutos.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscarProdutos.ForeColor = Color.DarkBlue;
            txtBuscarProdutos.Location = new Point(26, 353);
            txtBuscarProdutos.Multiline = true;
            txtBuscarProdutos.Name = "txtBuscarProdutos";
            txtBuscarProdutos.ReadOnly = true;
            txtBuscarProdutos.ScrollBars = ScrollBars.Vertical;
            txtBuscarProdutos.Size = new Size(329, 79);
            txtBuscarProdutos.TabIndex = 64;
            txtBuscarProdutos.Text = "Buscar produto.";
            // 
            // btAlterarProduto
            // 
            btAlterarProduto.BackColor = SystemColors.ActiveBorder;
            btAlterarProduto.Enabled = false;
            btAlterarProduto.FlatStyle = FlatStyle.Flat;
            btAlterarProduto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterarProduto.ForeColor = SystemColors.ControlText;
            btAlterarProduto.Location = new Point(372, 304);
            btAlterarProduto.Name = "btAlterarProduto";
            btAlterarProduto.Size = new Size(116, 37);
            btAlterarProduto.TabIndex = 63;
            btAlterarProduto.Text = "Alterar";
            btAlterarProduto.UseVisualStyleBackColor = false;
            btAlterarProduto.Click += btAlterarProduto_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = Color.Crimson;
            btExcluir.FlatStyle = FlatStyle.Flat;
            btExcluir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluir.ForeColor = SystemColors.ControlText;
            btExcluir.Location = new Point(162, 196);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(116, 36);
            btExcluir.TabIndex = 62;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Visible = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // btBuscarProduto
            // 
            btBuscarProduto.BackColor = SystemColors.ActiveCaption;
            btBuscarProduto.FlatStyle = FlatStyle.Flat;
            btBuscarProduto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBuscarProduto.ForeColor = SystemColors.ControlText;
            btBuscarProduto.Location = new Point(239, 304);
            btBuscarProduto.Name = "btBuscarProduto";
            btBuscarProduto.Size = new Size(116, 36);
            btBuscarProduto.TabIndex = 61;
            btBuscarProduto.Text = "Buscar";
            btBuscarProduto.UseVisualStyleBackColor = false;
            btBuscarProduto.Click += btBuscarProduto_Click;
            // 
            // lbProdutoCodigo
            // 
            lbProdutoCodigo.AutoSize = true;
            lbProdutoCodigo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProdutoCodigo.Location = new Point(26, 282);
            lbProdutoCodigo.Name = "lbProdutoCodigo";
            lbProdutoCodigo.Size = new Size(159, 25);
            lbProdutoCodigo.TabIndex = 60;
            lbProdutoCodigo.Text = "Produto / Código";
            // 
            // txtProdutoCodigo
            // 
            txtProdutoCodigo.Location = new Point(26, 310);
            txtProdutoCodigo.Name = "txtProdutoCodigo";
            txtProdutoCodigo.Size = new Size(198, 27);
            txtProdutoCodigo.TabIndex = 59;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = SystemColors.Control;
            lbTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.DarkBlue;
            lbTitulo.Location = new Point(610, 449);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(165, 62);
            lbTitulo.TabIndex = 65;
            lbTitulo.Text = "Barbearia\r\nBarba de Gato\r\n";
            lbTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = SystemColors.Highlight;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.ForeColor = SystemColors.ControlText;
            btCancelar.Location = new Point(299, 196);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(116, 37);
            btCancelar.TabIndex = 66;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Visible = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.MediumSeaGreen;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvar.ForeColor = SystemColors.ControlText;
            btSalvar.Location = new Point(26, 195);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(116, 38);
            btSalvar.TabIndex = 67;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Visible = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 532);
            Controls.Add(btSalvar);
            Controls.Add(btExcluir);
            Controls.Add(btCancelar);
            Controls.Add(lbTitulo);
            Controls.Add(txtBuscarProdutos);
            Controls.Add(btAlterarProduto);
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
            Name = "frmProduto";
            Text = "Poduto";
            Load += Poduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProdutos;
        private TextBox txtProdutos;
        private Button btCadastrar;
        private Label lbValor;
        private TextBox txtValor;
        private Label lbProduto;
        private TextBox txtProduto;
        private Label lbCadastrarProduto;
        private TextBox txtBuscarProdutos;
        private Button btAlterarProduto;
        private Button btExcluir;
        private Button btBuscarProduto;
        private Label lbProdutoCodigo;
        private TextBox txtProdutoCodigo;
        private Label lbTitulo;
        private Button btCancelar;
        private Button btSalvar;
    }
}