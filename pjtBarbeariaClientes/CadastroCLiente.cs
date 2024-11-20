using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjtBarbeariaClientes
{
    public partial class frmCadastroCLiente : Form
    {
        List<Cliente> listaClientes = new List<Cliente>();
        Utilitarios utilitario = new Utilitarios();

        private void frmCadastroCLiente_Load(object sender, EventArgs e)
        {
            listaClientes = utilitario.carregarCliente();

            if (listaClientes.Any())
            {
                listaClientes.Sort();
            }
            else
            {
                MessageBox.Show("Nenhum cliente cadastrado!");
            }
        }

        public frmCadastroCLiente()
        {
            InitializeComponent();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            DateTime dataNascimento = DateTime.Now;

            if (txtNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Preencha o campo Nome!");
                valido = false;
            }
            else if (!DateTime.TryParse(txtAniversario.Text, out dataNascimento))
            {
                MessageBox.Show("Preencha o campo Aniversário! Ex: 01/01/2024");
                valido = false;
            }
            else if (txtTelefone.Text.Trim().Length != 11)
            {
                MessageBox.Show("Preencha o campo Telefone! Ex: 13987654321");
                valido = false;
            }
            if (valido)
            {
                if (txtLogin.Text.Trim() != String.Empty)
                {
                    Cliente login = new Cliente(txtLogin.Text);
                    listaClientes.Sort();
                    int buscarLogin = listaClientes.BinarySearch(login);

                    if (buscarLogin < 0)
                    {
                        if (txtSenha.Text.Trim().Length == 6)
                        {
                            String hashSenha = Utilitarios.myHash(txtSenha.Text);
                            Cliente cliente = new Cliente(txtLogin.Text, hashSenha, txtNome.Text, dataNascimento, txtTelefone.Text);
                            cliente.email = txtEmail.Text;

                            listaClientes.Add(cliente);
                            utilitario.salvarCliente(listaClientes);
                            MessageBox.Show("Cadastrado com sucesso!");
                            limparCampos();

                            Form formLogin = new frmLogin();
                            Utilitarios.trocarForm(formLogin);
                        }
                        else
                        {
                            MessageBox.Show("Preencha o campo Senha com 6 dígitos!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Este Login já existe!");
                    }
                }
                else
                {
                    MessageBox.Show("Preecha o campo Login!");
                }
            }
        }

        public void limparCampos()
        {
            txtNome.Text =
            txtAniversario.Text =
            txtEmail.Text =
            txtTelefone.Text =
            txtLogin.Text =
            txtSenha.Text = String.Empty;
        }

        private void btVoltarLogin_Click(object sender, EventArgs e)
        {
            Form formLogin = new frmLogin();
            Utilitarios.trocarForm(formLogin);
        }
    }
}
