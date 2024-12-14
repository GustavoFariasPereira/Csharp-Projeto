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
    public partial class frmFuncionamento : Form
    {
        Semana? semanaA = new Semana();
        Semana? semanaB = new Semana();
        Utilitarios utilitario = new Utilitarios();
        String enderecoA = "semanaA";
        String enderecoB = "semanaB";
        public frmFuncionamento()
        {
            InitializeComponent();
        }

        private void frmFuncionamento_Load(object sender, EventArgs e)
        {
            semanaA = utilitario.carregarObjeto<Semana>(@"C:\Users\gusta\OneDrive\Área de Trabalho\ProjetosC#\JSON\BSemanaA.json");
            semanaB = utilitario.carregarObjeto<Semana>(@"C:\Users\gusta\OneDrive\Área de Trabalho\ProjetosC#\JSON\BSemanaB.json");

            if (semanaA != null)
            {
                txtDiasHorasFuncionamento.Text = semanaA.ToString();
            }
            else
            {
                txtDiasHorasFuncionamento.Text = "Semana não encontrada!";
            }
        }

        private bool monitorCheckBox()
        {
            bool algumSelecionado = ckSegunda.Checked || ckTerca.Checked || ckQuarta.Checked || ckQuinta.Checked
                || ckSexta.Checked || ckSabado.Checked || ckDomingo.Checked;

            lbResultado.Text = algumSelecionado
                ? "Alguma opção foi selecionada."
                : "Nenhuma opção selecionada.";

            return algumSelecionado;
        }
        private bool monitorRadioButton()
        {
            bool algumSelecionado = rbEstaSemana.Checked || rbProximaSemana.Checked;

            lbResultado.Text = algumSelecionado
                ? "Alguma opção foi selecionada."
                : "Nenhuma opção selecionada.";

            return algumSelecionado;
        }
        private void desmarcar()
        {
            rbEstaSemana.Checked = rbProximaSemana.Checked =
            rbAberto.Checked = rbFechado.Checked = false;
        }
        private void habilitarTexto(bool habilitar)
        {
            if (habilitar)
            {
                txtAbertura.Enabled = txtPausa.Enabled = txtFechamento.Enabled = false;
                txtAbertura.Text = txtPausa.Text = txtFechamento.Text = "---";
            }
            else
            {
                txtAbertura.Enabled = txtPausa.Enabled = txtFechamento.Enabled = true;
                txtAbertura.Text = txtPausa.Text = txtFechamento.Text = String.Empty;
            }
        }
        private DateTime semana(RadioButton radioButton)
        {
            DateTime hoje = DateTime.Now;
            DayOfWeek dia = hoje.DayOfWeek;
            if (rbEstaSemana.Checked)
            {
                if (dia == DayOfWeek.Monday)
                {

                }
            }
            return DateTime.Now;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            bool algumSelecionado = monitorCheckBox();

            if (algumSelecionado)
            {
                gbSemana.Enabled = true;
            }
            else
            {
                gbSemana.Enabled = false;
                desmarcar();
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            bool algumSelecionado = monitorRadioButton();

            if (algumSelecionado)
            {
                gbFuncionamento.Enabled = true;
                if (rbAberto.Checked)
                {
                    habilitarTexto(false);
                }
                else habilitarTexto(true);

            }
            else
            {
                gbFuncionamento.Enabled = false;
                desmarcar();
                habilitarTexto(true);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtAbertura.Text != "---" || txtAbertura.Text != String.Empty) 
            {
                if (rbEstaSemana.Checked)
                {

                }
                else
                {

                }
            }
        }
    }
}
