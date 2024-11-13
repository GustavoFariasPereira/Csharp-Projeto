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

            if (listaClientes.Any())
            {
                listaClientes.Sort();
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
            else if (txtSenha.Text.Trim().Length != 8)
            {
                MessageBox.Show("Preencha os 8 digitos do campo Senha!");
                valido = false;
            }
            if (valido) 
            {
                Cliente 
            }
        }
    }
}
