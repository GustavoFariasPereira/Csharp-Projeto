using System.Diagnostics.Eventing.Reader;
using System.Numerics;
using System.Text;

namespace pjtBarbeariaClientes
{
    public partial class frmCadastro : Form
    {
        public static List<Cliente> listaClientes = new List<Cliente>();
        Utilitarios utilitario = new Utilitarios();

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            listaClientes = utilitario.carregarCliente();
            Console.WriteLine(listaClientes);
            if (listaClientes.Any())
            {
                //txtCadastrados.Text = String.Join(Environment.NewLine, listaClientes.Select(c => $"Nome: {c.nome}," +
                //$" Aniversário: {c.dataNascimento}, Telefone: {c.telefone}, E-mail: {c.email}"));
                txtCadastrados.Text = utilitario.relatorio(listaClientes);
            }
            else
            {
                txtCadastrados.Text = "Nenhum registro encontrado!";
            }
        }

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtLogin.Text);
            listaClientes.Sort();
            int busca = listaClientes.BinarySearch(c);
            if (busca >= 0)
            {
                listaClientes.RemoveAt(busca);

                utilitario.salvarCliente(listaClientes);

                txtCadastrados.Text = utilitario.relatorio(listaClientes);

                txtMensagem.Text = "Excluido com sucesso!";
            }
            else
            {
                txtMensagem.Text = "Não foi encontrado!";
            }
        }

        private void miLogin_Click(object sender, EventArgs e)
        {
            Form formLogin = new frmLogin();
            Utilitarios.trocarForm(formLogin);
        }

        private void miCadastro_Click(object sender, EventArgs e)
        {
            Form formCadastro = new frmCadastroCLiente();
            Utilitarios.trocarForm(formCadastro);
        }
    }
}
