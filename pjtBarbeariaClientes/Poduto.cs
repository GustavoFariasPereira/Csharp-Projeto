using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                listaProdutos.Sort();
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
                Produto nome = new Produto(txtProduto.Text);
                listaProdutos.Sort((p1, p2) => p1.CompareTo(p2, p => p.nome));
                int buscar = listaProdutos.BinarySearch(nome, Comparer<Produto>.Create((p1, p2) => p1.CompareTo(p2, p => p.nome)));

                if (buscar < 0)
                {
                    if (txtValor.Text != String.Empty)
                    {
                        if (float.TryParse(txtValor.Text, out float valor))
                        {
                            Produto gerarId = new Produto();
                            int id = gerarId.gerarId(listaProdutos, Produto.ultimoId);
                            Produto produto = new Produto(txtProduto.Text, valor, id);
                            listaProdutos.Add(produto);
                            listaProdutos.Sort();
                            utilitario.salvarLista(listaProdutos);
                            txtProdutos.Text = utilitario.relatorio(listaProdutos);
                            MessageBox.Show("Cadastrado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Valor digitado inválido!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um valor para o produto!");
                    }
                }
                else
                {
                    MessageBox.Show("Nome já existente!");
                }
            }
            else
            {
                MessageBox.Show("Digite um nome para o produto!");
            }
        }

        public static Produto alterar = new Produto("", 0, 0);

        private int indice(Produto produto)
        {
            listaProdutos.Sort();
            int pos = listaProdutos.BinarySearch(produto);
            return pos;
        }

        private void alterando(Produto produto)
        {
            txtProduto.Text = produto.nome;
            txtValor.Text = produto.valor.ToString();
        }

        private void btBuscarProduto_Click(object sender, EventArgs e)
        {
            if (txtProdutoCodigo.Text != String.Empty)
            {
                if (int.TryParse(txtProdutoCodigo.Text, out int id))
                {
                    Produto codigo = new Produto(id);
                    listaProdutos.Sort();
                    int buscarId = listaProdutos.BinarySearch(codigo);

                    if (buscarId >= 0)
                    {
                        Produto produto = listaProdutos[buscarId];
                        txtBuscarProdutos.Text = produto.ToString();
                        btAlterarProduto.Enabled = true;
                        alterar = produto;
                    }
                    else
                    {
                        txtBuscarProdutos.Text = "Produto não encontrado!";
                    }
                }
                else
                {
                    Produto nome = new Produto(txtProdutoCodigo.Text);
                    listaProdutos.Sort((p1, p2) => p1.CompareTo(p2, p => p.nome));
                    int buscarNome = listaProdutos.BinarySearch(nome, Comparer<Produto>.Create((p1, p2) => p1.CompareTo(p2, p => p.nome)));

                    if (buscarNome >= 0)
                    {
                        Produto produto = listaProdutos[buscarNome];
                        txtBuscarProdutos.Text = produto.ToString();
                        btAlterarProduto.Enabled = true;
                        alterar = produto;
                    }
                    else
                    {
                        txtBuscarProdutos.Text = "Produto não encontrado!";
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite o nome do produto ou código!");
            }
        }

        private void btAlterarProduto_Click(object sender, EventArgs e)
        {
            alterando(alterar);
            btSalvar.Visible = true;
            btExcluir.Visible = true;
            btCancelar.Visible = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text != String.Empty)
            {
                if (txtValor.Text != String.Empty)
                {
                    if (float.TryParse(txtValor.Text, out float valor))
                    {
                        Produto produto = new Produto(txtProduto.Text, valor, alterar.id);
                        int pos = indice(produto);
                        listaProdutos[pos] = produto;
                        txtProdutos.Text = utilitario.relatorio(listaProdutos);
                        utilitario.salvarLista(listaProdutos);
                        MessageBox.Show("Produto alterado com sucesso!");
                    }
                    else MessageBox.Show("Valor do produto inválido!");
                }
                else MessageBox.Show("Digite o valor do produto!");
            }
            else MessageBox.Show("Digite o nome do produto!");
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int pos = indice(alterar);
            listaProdutos.RemoveAt(pos);
            txtProdutos.Text = utilitario.relatorio(listaProdutos);
            utilitario.salvarLista(listaProdutos);
            
            MessageBox.Show("Produto excluído com sucesso!");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            
            btSalvar.Visible = false;
            btExcluir.Visible = false;
            btCancelar.Visible = false;
        }
    }
}
