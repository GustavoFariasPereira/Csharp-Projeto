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

            listaClientes = Utilitarios.carregarLista<Cliente>(@"D:\C#\Semestre2\BClientes.json");
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

                utilitario.salvarLista(listaClientes);

                txtClientes.Text = utilitario.relatorio(listaClientes);

                txtBuscar.Text = "Excluido com sucesso!";
            }
            else
            {
                txtBuscar.Text = "N�o foi encontrado!";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
