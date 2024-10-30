using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace pjtBarbeariaClientes
{
    public partial class frmCadastroClientes : Form
    {
        public static List<Cliente> listaClientes = new List<Cliente>();
        public String arquivo = "Área de Trabalho\\ProjetosC#\\clientes.dat";

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            if (File.Exists(arquivo))
            {
                listaClientes = Utilitarios.loadUsuario(arquivo);
                txtCadastrados.Text = relatorio();
            }
            else
            {
                listaClientes = new List<Cliente>();
            }
        }

        public frmCadastroClientes()
        {
            InitializeComponent();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            DateTime dataNascimento = DateTime.Now;

            if (txtNome.Text.Trim() == String.Empty)
            {
                txtMensagem.Text = "O nome do cliente é um campo obrigatório!";
                valido = false;
            }
            else if (!DateTime.TryParse(txtAniversario.Text, out dataNascimento))
            {
                txtMensagem.Text = "A data de nascimento do cliente inválida!";
                valido = false;
            }
            else if (txtTelefone.Text.Trim().Length != 11)
            {
                txtMensagem.Text = "O telefone do cliente é um campo obrigatório, deve estar no seguinte formato (13998887777)";
                valido = false;
            }
            else if (txtSenha.Text.Trim().Length != 8)
            {
                txtMensagem.Text = "A senha deve ter 8 digítos!";
                valido = false;
            }
            Cliente testeLogin = new Cliente(txtLogin.Text);
            int pos = listaClientes.BinarySearch(testeLogin);
            if (pos == 0)
            {
                txtMensagem.Text = "Este login já existe!";
                valido = false;
            }
            if (valido)
            {
                Cliente c = new Cliente(txtLogin.Text, txtSenha.Text, txtNome.Text,
                    dataNascimento, txtTelefone.Text);
                c.email = txtEmail.Text;

                listaClientes.Add(c);

                Utilitarios.saveUsuario(listaClientes, arquivo);

                limpaTela();

                txtCadastrados.Text = relatorio();
            }
        }

        private void limpaTela()
        {
            txtNome.Text =
            txtAniversario.Text =
            txtTelefone.Text =
            txtEmail.Text =
            txtMensagem.Text = String.Empty;
        }

        private String relatorio()
        {
            StringBuilder ret = new StringBuilder();

            //  clientes.Sort();

            foreach (Pessoa p in listaClientes)
            {
                ret.Append(p.ToString() + Environment.NewLine);
            }

            return ret.ToString();
        }

        
    }
}
