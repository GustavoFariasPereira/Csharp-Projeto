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
            listaClientes = Utilitarios.carregarLista<Cliente>(@"D:\C#\Semestre2\BClientes.json");
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
            Utilitarios.abrirNovoForm<frmCadastroCLiente>(this);
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != String.Empty)
            {
                if (txtSenha.Text.Trim().Length == 6)
                {
                    Cliente login = new Cliente(txtLogin.Text);
                    listaClientes.Sort();
                    int buscarLogin = listaClientes.BinarySearch(login);

                    if (buscarLogin >= 0)
                    {
                        Cliente achouCliente = listaClientes[buscarLogin];

                        if (achouCliente.hashSenha == Utilitarios.myHash(txtSenha.Text))
                        {
                            if (achouCliente.login == "ADM")
                            {
                                Utilitarios.abrirNovoForm<frmCadastro>(this);
                            }
                            else
                            {
                                MessageBox.Show("Senha correta!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta!");
                            txtSenha.Text = String.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login não cadastrado!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os 6 digitos do campo Senha!");
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo Login!");
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Utilitarios.fecharAplicativo(this);
        }
    }
}
