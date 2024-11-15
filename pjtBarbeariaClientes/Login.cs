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
            Form form = new frmCadastroClientes();
            form.Visible = true;
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (txtLogin.Text.Trim() == String.Empty) 
            {
                MessageBox.Show("Preencha o campo Login!");
                valido = false;
            }
            else if (txtSenha.Text.Trim().Length != 6)
            {
                MessageBox.Show("Preencha os 6 digitos do campo Senha!");
                valido = false;
            }
            if (valido) 
            {
               
                Cliente login = new Cliente(txtLogin.Text);
                listaClientes.Sort();
                int buscarLogin = listaClientes.BinarySearch(login);

                if(buscarLogin < 0)
                {
                    MessageBox.Show("Login não cadastrado!");
                }
                else
                {
                    Cliente achouCliente = listaClientes[buscarLogin];

                    string hashEntrada = Utilitarios.myHash(txtSenha.Text);
                    Console.WriteLine("Hash esperado: " + achouCliente.hashSenha);
                    Console.WriteLine("Hash digitado: " + hashEntrada);

                    if (achouCliente.hashSenha != Utilitarios.myHash(txtSenha.Text))
                    {
                        MessageBox.Show("Senha incorreta!");
                        txtSenha.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Senha correta!");
                    }
                }
            }
        }
    }
}
