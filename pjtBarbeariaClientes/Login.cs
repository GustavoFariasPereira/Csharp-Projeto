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
    public partial class frmLogin : Form
    {
        List<Cliente> listaClientes = new List<Cliente>();
        Utilitarios utilitario = new Utilitarios();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            listaClientes = utilitario.carregarCliente();
            Console.WriteLine(listaClientes);
            if (listaClientes.Any())
            {
                listaClientes.Sort();
                Console.WriteLine(listaClientes);
            }
            else
            {
                MessageBox.Show("Não tem registro de clientes!");
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbCadastrar_Click(object sender, EventArgs e)
        {
            Form formAtivo = utilitario.obterFormAtivo();
            Form formCadastro = new frmCadastroCliente();
            formAtivo.Visible = false;
            formCadastro.Visible = true;
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != String.Empty) 
            {
                Cliente login = new Cliente(txtLogin.Text);
                listaClientes.Sort();
                int buscarLogin = listaClientes.BinarySearch(login);

                if (buscarLogin >= 0)
                {
                    Cliente achouCliente = listaClientes[buscarLogin];

                    if(txtSenha.Text.Trim().Length == 6)
                    { 
                        if (achouCliente.hashSenha != Utilitarios.myHash(txtSenha.Text))
                        {
                            MessageBox.Show("Senha incorreta!");
                            txtSenha.Text = String.Empty;
                        }
                        else
                        {
                            if(achouCliente.login == "ADM")
                            {
                                Form formAtivo = utilitario.obterFormAtivo();
                                Form formADM = new frmADM();
                                formAtivo.Visible = false;
                                formADM.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Senha correta!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha o campo Senha com 6 dígitos!");
                    }
                }
                else
                {
                    MessageBox.Show("Login não cadastrado!");
                }  
            }
            else
            {
                MessageBox.Show("Preencha o campo Login!");
            }
        }
    }
}
