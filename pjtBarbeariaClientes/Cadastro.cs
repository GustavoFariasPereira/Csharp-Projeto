using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace pjtBarbeariaClientes
{
    public partial class frmCadastroClientes : Form
    {
        public static List<Cliente> listaClientes = new List<Cliente>();
        Utilitarios utilitario = new Utilitarios();

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            listaClientes = utilitario.carregarCliente();

            if (listaClientes.Any())
            {
                //txtCadastrados.Text = String.Join(Environment.NewLine, listaClientes.Select(c => $"Nome: {c.nome}," +
                //$" Aniversário: {c.dataNascimento}, Telefone: {c.telefone}, E-mail: {c.email}"));
                txtCadastrados.Text = relatorio();
            }
            else
            {
                txtCadastrados.Text = "Nenhum registro encontrado!";
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
            else if (txtSenha.Text.Trim().Length != 6)
            {
                txtMensagem.Text = "A senha deve ter 6 digítos!";
                valido = false;
            }
            Cliente testeLogin = new Cliente(txtLogin.Text);
            listaClientes.Sort();
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

                utilitario.salvarCliente(listaClientes);

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

            foreach (Pessoa p in listaClientes)
            {
                ret.Append(p.ToString() + Environment.NewLine);
            }

            return ret.ToString();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtLogin.Text);
            listaClientes.Sort();
            int busca = listaClientes.BinarySearch(c);
            if (busca != -1)
            {
                listaClientes.RemoveAt(busca);

                utilitario.salvarCliente(listaClientes);

                txtCadastrados.Text = relatorio();

                txtMensagem.Text = "Excluido com sucesso!";
            }
            else
            {
                txtMensagem.Text = "Não foi encontrado!";
            }
            
        }
    }
}
