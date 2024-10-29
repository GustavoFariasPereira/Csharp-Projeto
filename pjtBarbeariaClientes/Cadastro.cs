using System.Text;

namespace pjtBarbeariaClientes
{
    public partial class frmCadastroClientes : Form
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public String arquivo = "Área de Trabalho\\ProjetosC#\\clientes.dat";
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
            else if (!DateTime.TryParse(txtDataNascimento.Text, out dataNascimento))
            {
                txtMensagem.Text = "A data de nascimento do cliente inválida!";
                valido = false;
            }
            else if (txtTelefone.Text.Trim().Length != 11)
            {
                txtMensagem.Text = "O telefone do cliente é um campo obrigatório, deve estar no seguinte formato (13998887777)";
                valido = false;
            }

            if (valido)
            {
                Cliente p = new Cliente(txtNome.Text, dataNascimento, txtTelefone.Text);
                p.email = txtEmail.Text;

                clientes.Add(p);

                Utilitarios.saveUsuario(clientes, arquivo);

                limpaTela();

                txtCadastrados.Text = relatorio();
            }
        }

        private void limpaTela()
        {
            txtNome.Text =
            txtDataNascimento.Text =
            txtTelefone.Text =
            txtEmail.Text =
            txtMensagem.Text = String.Empty;
        }

        private String relatorio()
        {
            StringBuilder ret = new StringBuilder();

            //  clientes.Sort();

            foreach (Pessoa p in clientes)
            {
                ret.Append(p.ToString() + Environment.NewLine);
            }

            return ret.ToString();
        }
    }
}
