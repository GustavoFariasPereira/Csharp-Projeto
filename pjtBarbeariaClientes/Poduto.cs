﻿using System;
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
                if (txtValor.Text != String.Empty) 
                {
                    float valor = 0;
                    if (float.TryParse(txtValor.Text, out valor))
                    {
                        Produto nome = new Produto(txtProduto.Text);
                        listaProdutos.Sort();
                        int buscar = listaProdutos.BinarySearch(nome);

                        if (buscar < 0)
                        {
                            Produto produto = new Produto(txtProduto.Text, valor);
                            listaProdutos.Add(produto);
                            utilitario.salvarLista(listaProdutos);
                            txtProdutos.Text = utilitario.relatorio(listaProdutos);
                            MessageBox.Show("Cadastrado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nome já existente!");
                        }
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
                MessageBox.Show("Digite um nome para o produto!");
            }
        }
    }
}
