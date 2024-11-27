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
    public partial class frmProduto : Form
    {
        List<Produto> listaProdutos = new List<Produto>();
        Utilitarios utilitario = new Utilitarios();
        public frmProduto()
        {
            InitializeComponent();
        }

        private void Poduto_Load(object sender, EventArgs e)
        {
            listaProdutos = utilitario.carregarLista<Produto>(@"D:\C#\Semestre2\BProdutos.json");

            if (listaProdutos.Any())
            {
                txtProdutos.Text = utilitario.relatorio(listaProdutos);
            }
            else
            {
                txtProdutos.Text = "Nenhum produto cadastrado!";
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text != String.Empty)
            {
                
                listaProdutos.Sort();
                
            }
        }
    }
}
