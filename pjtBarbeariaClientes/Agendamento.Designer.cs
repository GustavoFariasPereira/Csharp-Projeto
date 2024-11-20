namespace pjtBarbeariaClientes
{
    partial class frmAgendamento
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
            txtDataAgendamento = new TextBox();
            lbDataAgendamento = new Label();
            lbTitulo = new Label();
            txtHora = new TextBox();
            lbHora = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            txtLogin = new TextBox();
            lbLogin = new Label();
            lbTotal = new Label();
            btAgendar = new Button();
            lbAgendamentos = new Label();
            txtAgendamentos = new TextBox();
            radioButton1 = new RadioButton();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            SuspendLayout();
            // 
            // txtDataAgendamento
            // 
            txtDataAgendamento.Location = new Point(43, 206);
            txtDataAgendamento.Name = "txtDataAgendamento";
            txtDataAgendamento.Size = new Size(99, 27);
            txtDataAgendamento.TabIndex = 12;
            // 
            // lbDataAgendamento
            // 
            lbDataAgendamento.AutoSize = true;
            lbDataAgendamento.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDataAgendamento.Location = new Point(43, 178);
            lbDataAgendamento.Name = "lbDataAgendamento";
            lbDataAgendamento.Size = new Size(57, 25);
            lbDataAgendamento.TabIndex = 11;
            lbDataAgendamento.Text = "Data ";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = SystemColors.Control;
            lbTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.DarkBlue;
            lbTitulo.Location = new Point(12, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(147, 56);
            lbTitulo.TabIndex = 13;
            lbTitulo.Text = "Barbearia\r\nBarba de Gato\r\n";
            lbTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(45, 300);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(99, 27);
            txtHora.TabIndex = 15;
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHora.Location = new Point(45, 269);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(54, 25);
            lbHora.TabIndex = 14;
            lbHora.Text = "Hora";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(43, 142);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(43, 82);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 23;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(43, 112);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 24;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(171, 206);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(177, 27);
            txtLogin.TabIndex = 26;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(171, 175);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(59, 25);
            lbLogin.TabIndex = 25;
            lbLogin.Text = "Login";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.Location = new Point(153, 302);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(69, 25);
            lbTotal.TabIndex = 27;
            lbTotal.Text = "Total : ";
            // 
            // btAgendar
            // 
            btAgendar.BackColor = Color.MediumSeaGreen;
            btAgendar.FlatStyle = FlatStyle.Flat;
            btAgendar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAgendar.ForeColor = SystemColors.ControlText;
            btAgendar.Location = new Point(93, 352);
            btAgendar.Name = "btAgendar";
            btAgendar.Size = new Size(116, 36);
            btAgendar.TabIndex = 28;
            btAgendar.Text = "Agendar";
            btAgendar.UseVisualStyleBackColor = false;
            // 
            // lbAgendamentos
            // 
            lbAgendamentos.AutoSize = true;
            lbAgendamentos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAgendamentos.Location = new Point(282, 34);
            lbAgendamentos.Name = "lbAgendamentos";
            lbAgendamentos.Size = new Size(141, 25);
            lbAgendamentos.TabIndex = 29;
            lbAgendamentos.Text = "Agendamentos";
            // 
            // txtAgendamentos
            // 
            txtAgendamentos.Location = new Point(282, 62);
            txtAgendamentos.Multiline = true;
            txtAgendamentos.Name = "txtAgendamentos";
            txtAgendamentos.ReadOnly = true;
            txtAgendamentos.Size = new Size(197, 104);
            txtAgendamentos.TabIndex = 30;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(171, 251);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(133, 24);
            radioButton1.TabIndex = 31;
            radioButton1.TabStop = true;
            radioButton1.Text = "Não é para min";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(150, 112);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(101, 24);
            checkBox4.TabIndex = 34;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(150, 82);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(101, 24);
            checkBox5.TabIndex = 33;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(150, 142);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(101, 24);
            checkBox6.TabIndex = 32;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // frmAgendamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 450);
            Controls.Add(checkBox4);
            Controls.Add(checkBox5);
            Controls.Add(checkBox6);
            Controls.Add(radioButton1);
            Controls.Add(txtAgendamentos);
            Controls.Add(lbAgendamentos);
            Controls.Add(btAgendar);
            Controls.Add(lbTotal);
            Controls.Add(txtLogin);
            Controls.Add(lbLogin);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(txtHora);
            Controls.Add(lbHora);
            Controls.Add(lbTitulo);
            Controls.Add(txtDataAgendamento);
            Controls.Add(lbDataAgendamento);
            Name = "frmAgendamento";
            Text = "Agendamento";
            Load += Agendamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDataAgendamento;
        private Label lbDataAgendamento;
        private Label lbTitulo;
        private TextBox txtHora;
        private Label lbHora;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private TextBox txtLogin;
        private Label lbLogin;
        private Label lbTotal;
        private Button btAgendar;
        private Label lbAgendamentos;
        private TextBox txtAgendamentos;
        private RadioButton radioButton1;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
    }
}