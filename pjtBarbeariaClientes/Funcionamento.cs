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
        List<Funcionamento> listaFuncionamentoA = new List<Funcionamento>();
        List<Funcionamento> listaFuncionamentoB = new List<Funcionamento>();
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
        private int contadorCheckBox()
        {
            int contador = 0;
            if (ckSegunda.Checked) contador++;
            if (ckTerca.Checked) contador++;
            if (ckQuarta.Checked) contador++;
            if (ckQuinta.Checked) contador++;
            if (ckSexta.Checked) contador++;
            if (ckSabado.Checked) contador++;
            if (ckDomingo.Checked) contador++;
            return contador;
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
        private DateTime semana()
        {
            DateTime hoje = DateTime.Now, data = DateTime.Now;

            DayOfWeek dia = hoje.DayOfWeek;
            if (rbEstaSemana.Checked)
            {
                if (dia == DayOfWeek.Monday) data = hoje.AddDays(0);
                else if (dia == DayOfWeek.Tuesday) data = hoje.AddDays(-1);
                else if (dia == DayOfWeek.Wednesday) data = hoje.AddDays(-2);
                else if (dia == DayOfWeek.Thursday) data = hoje.AddDays(-3);
                else if (dia == DayOfWeek.Friday) data = hoje.AddDays(-4);
                else if (dia == DayOfWeek.Saturday) data = hoje.AddDays(-5);
                else if (dia == DayOfWeek.Sunday) data = hoje.AddDays(-6);

            }
            else if (rbProximaSemana.Checked)
            {
                if (dia == DayOfWeek.Monday) data = hoje.AddDays(+7);
                else if (dia == DayOfWeek.Tuesday) data = hoje.AddDays(+6);
                else if (dia == DayOfWeek.Wednesday) data = hoje.AddDays(+5);
                else if (dia == DayOfWeek.Thursday) data = hoje.AddDays(+4);
                else if (dia == DayOfWeek.Friday) data = hoje.AddDays(+3);
                else if (dia == DayOfWeek.Saturday) data = hoje.AddDays(+2);
                else if (dia == DayOfWeek.Sunday) data = hoje.AddDays(+1);
            }
            return data;
        }
        private bool validarBtSalvar()
        {
            bool valido = true;
            TimeSpan hora;
            if (!TimeSpan.TryParse(txtAbertura.Text, out hora) && txtAbertura.Text == string.Empty
                && !TimeSpan.TryParse(txtPausa.Text, out hora) && txtPausa.Text == string.Empty
                && !TimeSpan.TryParse(txtFechamento.Text, out hora) && txtFechamento.Text == string.Empty) valido = false;
            return valido;
        }
        private void desmarcarCheckBox()
        {
            ckSegunda.Checked = false;
            ckSegunda.Enabled = true;
             ckTerca.Checked = false;
             ckTerca.Enabled = true;
              ckQuarta.Checked = false;
              ckQuarta.Enabled = true;
               ckQuinta.Checked = false;
               ckQuinta.Enabled = true;
                ckSexta.Checked = false;
                ckSexta.Enabled = true;
                 ckSabado.Checked = false; 
                 ckSabado.Enabled = true;
                  ckDomingo.Checked = false;
                  ckDomingo.Enabled = true;
        }
        private static bool segA = false;
        private static bool terA = false;
        private static bool quaA = false;
        private static bool quiA = false;
        private static bool sexA = false;
        private static bool sabA = false;
        private static bool domA = false;

        private static bool segB = false;
        private static bool terB = false;
        private static bool quaB = false;
        private static bool quiB = false;
        private static bool sexB = false;
        private static bool sabB = false;
        private static bool domB = false;

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
                //desmarcarCheckBox();
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
            if (validarBtSalvar())
            {
                DateTime data = semana();
                TimeSpan.TryParse(txtAbertura.Text, out TimeSpan abertura);
                TimeSpan.TryParse(txtPausa.Text, out TimeSpan pausa);
                TimeSpan.TryParse(txtFechamento.Text, out TimeSpan fechamento);
                if (contadorCheckBox() == 1)
                {
                    if (rbEstaSemana.Checked)
                    {
                        if (ckSegunda.Checked)
                        {
                            Funcionamento segunda = new Funcionamento(data, abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(segunda);
                            //lbResultado.Text = utilitario.relatorio(listaFuncionamentoA);
                            ckSegunda.Checked = false;
                            ckSegunda.Enabled = false;
                            segA = true;
                        }
                        else if (ckTerca.Checked)
                        {
                            Funcionamento terca = new Funcionamento(data.AddDays(+1), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(terca);
                            ckTerca.Checked = false;
                            ckTerca.Enabled = false;
                            terA = true;
                        }
                        else if (ckQuarta.Checked)
                        {
                            Funcionamento quarta = new Funcionamento(data.AddDays(+2), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(quarta);
                            ckQuarta.Checked = false;
                            ckQuarta.Enabled = false;
                            quaA = true;
                        }
                        else if (ckQuinta.Checked)
                        {
                            Funcionamento quinta = new Funcionamento(data.AddDays(+3), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(quinta);
                            ckQuinta.Checked = false;
                            ckQuinta.Enabled = false;
                            quiA = true;
                        }
                        else if (ckSexta.Checked)
                        {
                            Funcionamento sexta = new Funcionamento(data.AddDays(+4), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(sexta);
                            ckSexta.Checked = false;
                            ckSexta.Enabled = false;
                            sexA = true;
                        }
                        else if (ckSabado.Checked)
                        {
                            Funcionamento sabado = new Funcionamento(data.AddDays(+5), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(sabado);
                            ckSabado.Checked = false;
                            ckSabado.Enabled = false;
                            sabA = true;
                        }
                        else if (ckDomingo.Checked)
                        {
                            Funcionamento domingo = new Funcionamento(data.AddDays(+6), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(domingo);
                            ckDomingo.Checked = false;
                            ckDomingo.Enabled = false;
                            domA = true;
                        }
                    }
                    else if (rbProximaSemana.Checked)
                    {
                        if (ckSegunda.Checked)
                        {
                            Funcionamento segunda = new Funcionamento(data, abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(segunda);
                            ckSegunda.Checked = false;
                            ckSegunda.Enabled = false;
                            segB = true;

                        }
                        else if (ckTerca.Checked)
                        {
                            Funcionamento terca = new Funcionamento(data.AddDays(+1), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(terca);
                            ckTerca.Checked = false;
                            ckTerca.Enabled = false;
                            terB = true;
                        }
                        else if (ckQuarta.Checked)
                        {
                            Funcionamento quarta = new Funcionamento(data.AddDays(+2), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(quarta);
                            ckQuarta.Checked = false;
                            ckQuarta.Enabled = false;
                            quaB = true;
                        }
                        else if (ckQuinta.Checked)
                        {
                            Funcionamento quinta = new Funcionamento(data.AddDays(+3), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(quinta);
                            ckQuinta.Checked = false;
                            ckQuinta.Enabled = false;
                            quiB = true;
                        }
                        else if (ckSexta.Checked)
                        {
                            Funcionamento sexta = new Funcionamento(data.AddDays(+4), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(sexta);
                            ckSexta.Checked = false;
                            ckSexta.Enabled = false;
                            sexB = true;
                        }
                        else if (ckSabado.Checked)
                        {
                            Funcionamento sabado = new Funcionamento(data.AddDays(+5), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(sabado);
                            ckSabado.Checked = false;
                            ckSabado.Enabled = false;
                            sabB = true;
                        }
                        else if (ckDomingo.Checked)
                        {
                            Funcionamento domingo = new Funcionamento(data.AddDays(+6), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(domingo);
                            ckDomingo.Checked = false;
                            ckDomingo.Enabled = false;
                            domB = true;
                        }
                    }
                }
                else if (contadorCheckBox() > 1)
                {
                    if (rbEstaSemana.Checked)
                    {
                        if (ckSegunda.Checked)
                        {
                            Funcionamento segunda = new Funcionamento(data, abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(segunda);
                            //lbResultado.Text = utilitario.relatorio(listaFuncionamentoA);
                            ckSegunda.Checked = false;
                            ckSegunda.Enabled = false;
                            segA = true;
                        }
                        if (ckTerca.Checked)
                        {
                            Funcionamento terca = new Funcionamento(data.AddDays(+1), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(terca);
                            ckTerca.Checked = false;
                            ckTerca.Enabled = false;
                            terA = true;
                        }
                        if (ckQuarta.Checked)
                        {
                            Funcionamento quarta = new Funcionamento(data.AddDays(+2), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(quarta);
                            ckQuarta.Checked = false;
                            ckQuarta.Enabled = false;
                            quaA = true;
                        }
                        if (ckQuinta.Checked)
                        {
                            Funcionamento quinta = new Funcionamento(data.AddDays(+3), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(quinta);
                            ckQuinta.Checked = false;
                            ckQuinta.Enabled = false;
                            quiA = true;
                        }
                        if (ckSexta.Checked)
                        {
                            Funcionamento sexta = new Funcionamento(data.AddDays(+4), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(sexta);
                            ckSexta.Checked = false;
                            ckSexta.Enabled = false;
                            sexA = true;
                        }
                        if (ckSabado.Checked)
                        {
                            Funcionamento sabado = new Funcionamento(data.AddDays(+5), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(sabado);
                            ckSabado.Checked = false;
                            ckSabado.Enabled = false;
                            sabA = true;
                        }
                        if (ckDomingo.Checked)
                        {
                            Funcionamento domingo = new Funcionamento(data.AddDays(+6), abertura, pausa, fechamento);
                            listaFuncionamentoA.Add(domingo);
                            ckDomingo.Checked = false;
                            ckDomingo.Enabled = false;
                            domA = true;
                        }
                    }
                    else if (rbProximaSemana.Checked)
                    {
                        if (ckSegunda.Checked)
                        {
                            Funcionamento segunda = new Funcionamento(data, abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(segunda);
                            ckSegunda.Checked = false;
                            ckSegunda.Enabled = false;
                            segB = true;

                        }
                        if (ckTerca.Checked)
                        {
                            Funcionamento terca = new Funcionamento(data.AddDays(+1), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(terca);
                            ckTerca.Checked = false;
                            ckTerca.Enabled = false;
                            terB = true;
                        }
                        if (ckQuarta.Checked)
                        {
                            Funcionamento quarta = new Funcionamento(data.AddDays(+2), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(quarta);
                            ckQuarta.Checked = false;
                            ckQuarta.Enabled = false;
                            quaB = true;
                        }
                        if (ckQuinta.Checked)
                        {
                            Funcionamento quinta = new Funcionamento(data.AddDays(+3), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(quinta);
                            ckQuinta.Checked = false;
                            ckQuinta.Enabled = false;
                            quiB = true;
                        }
                        if (ckSexta.Checked)
                        {
                            Funcionamento sexta = new Funcionamento(data.AddDays(+4), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(sexta);
                            ckSexta.Checked = false;
                            ckSexta.Enabled = false;
                            sexB = true;
                        }
                        if (ckSabado.Checked)
                        {
                            Funcionamento sabado = new Funcionamento(data.AddDays(+5), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(sabado);
                            ckSabado.Checked = false;
                            ckSabado.Enabled = false;
                            sabB = true;
                        }
                        if (ckDomingo.Checked)
                        {
                            Funcionamento domingo = new Funcionamento(data.AddDays(+6), abertura, pausa, fechamento);
                            listaFuncionamentoB.Add(domingo);
                            ckDomingo.Checked = false;
                            ckDomingo.Enabled = false;
                            domB = true;
                        }
                    }
                }
                desmarcarCheckBox();
            }
        }

        private void rbEstaSemana_CheckedChanged(object sender, EventArgs e)
        {
            ckSegunda.Enabled = true;
            ckTerca.Enabled = true;
            ckQuarta.Enabled = true;
            ckQuinta.Enabled = true;
            ckSexta.Enabled = true;
            ckSabado.Enabled = true;
            ckDomingo.Enabled = true;
            if (rbEstaSemana.Checked)
            {
                if (segA) ckSegunda.Checked = ckSegunda.Enabled = false;
                if (terA) ckTerca.Checked = ckTerca.Enabled = false;
                if (quaA) ckQuarta.Checked = ckQuarta.Enabled = false;
                if (quiA) ckQuinta.Checked = ckQuinta.Enabled = false;
                if (sexA) ckSexta.Checked = ckSexta.Enabled = false;
                if (sabA) ckSabado.Checked = ckSabado.Enabled = false;
                if (domA) ckDomingo.Checked = ckDomingo.Enabled = false;
            }
        }

        private void rbProximaSemana_CheckedChanged(object sender, EventArgs e)
        {
            ckSegunda.Enabled = true;
            ckTerca.Enabled = true;
            ckQuarta.Enabled = true;
            ckQuinta.Enabled = true;
            ckSexta.Enabled = true;
            ckSabado.Enabled = true;
            ckDomingo.Enabled = true;
            if (rbProximaSemana.Checked)
            {
                if (segB) ckSegunda.Checked = ckSegunda.Enabled = false;
                if (terB) ckTerca.Checked = ckTerca.Enabled = false;
                if (quaB) ckQuarta.Checked = ckQuarta.Enabled = false;
                if (quiB) ckQuinta.Checked = ckQuinta.Enabled = false;
                if (sexB) ckSexta.Checked = ckSexta.Enabled = false;
                if (sabB) ckSabado.Checked = ckSabado.Enabled = false;
                if (domB) ckDomingo.Checked = ckDomingo.Enabled = false;
            }
        }
    }
}
