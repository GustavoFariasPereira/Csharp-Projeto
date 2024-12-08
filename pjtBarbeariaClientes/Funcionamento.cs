using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            // Verifica se algum CheckBox está selecionado
            bool algumSelecionado = ckSegunda.Checked || ckTerca.Checked || ckQuarta.Checked || ckQuinta.Checked
                || ckSexta.Checked || ckSabado.Checked || ckDomingo.Checked;

            // Atualiza o texto do Label
            lbResultado.Text = algumSelecionado
                ? "Alguma opção foi selecionada."
                : "Nenhuma opção selecionada.";

            // Retorna true se algum CheckBox estiver selecionado
            return algumSelecionado;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // Chama o método e verifica o retorno
            bool algumSelecionado = monitorCheckBox();

            // Use o valor retornado, se necessário
            if (algumSelecionado)
            {
                Console.WriteLine("Há opções selecionadas.");
            }
            else
            {
                Console.WriteLine("Nenhuma opção está selecionada.");
            }
        }
    }
}
