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
    public partial class frmFuncionamento : Form
    {
        Semana semanaA = new Semana();
        Semana semanaB = new Semana();
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

            if (semanaA.Any())
            {
                txtDiasHorasFuncionamento.Text = utilitario.relatorio(semanaA);
            }
        }
    }
}