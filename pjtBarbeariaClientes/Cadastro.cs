using System.Diagnostics.Eventing.Reader;
using System.Numerics;
using System.Text;

namespace pjtBarbeariaClientes
{
    public partial class frmCadastro : Form
    {
        public static List<Cliente> listaClientes = new List<Cliente>();
        Utilitarios utilitario = new Utilitarios();
        String endereco;
        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {

            listaClientes = utilitario.carregarLista<Cliente>(@"D:\C#\Semestre2\BClientes.json");
            Console.WriteLine(listaClientes);
            if (listaClientes.Any())
            {
                txtClientes.Text = utilitario.relatorio(listaClientes);
            }
            else
            {
                txtClientes.Text = "Nenhum registro encontrado!";
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

                utilitario.salvarLista(listaClientes, endereco);

                txtClientes.Text = utilitario.relatorio(listaClientes);

                txtBuscarCLientesAgendamentos.Text = "Excluido com sucesso!";
            }
            else
            {
                txtBuscarCLientesAgendamentos.Text = "Não foi encontrado!";
            }
        }

        private void miLogin_Click(object sender, EventArgs e)
        {
            utilitario.abrirNovoForm<frmLogin>(this);
        }

        private void miCadastro_Click(object sender, EventArgs e)
        {
            utilitario.abrirNovoForm<frmCadastroCLiente>(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
