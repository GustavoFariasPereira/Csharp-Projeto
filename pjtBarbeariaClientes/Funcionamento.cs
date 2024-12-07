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
        List<Semana> semanaA = new List<Semana>();
        List<Semana> semanaB = new List<Semana>();
        Utilitarios utilitario = new Utilitarios();
        public frmFuncionamento()
        {
            InitializeComponent();
        }

        private void frmFuncionamento_Load(object sender, EventArgs e)
        {

        }
    }
}
