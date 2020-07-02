using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using BLL;

namespace UI
{
    public partial class Veiculos_Crud : Form
    {

        Movimentacao movimentacao = new Movimentacao();


        public Veiculos_Crud()
        {
            InitializeComponent();
        }

        private void PreencherDataGrid(String Texto)
        {

            dataGridView1.DataSource = MovimentacaoBLL.getInstance().consultarMovimentacaoApenasEntrada(Texto);
            dataGridView1.Columns[0].HeaderText = "Cód. Mov.";
            dataGridView1.Columns[1].HeaderText = "Marca";
            dataGridView1.Columns[2].HeaderText = "Modelo";
            dataGridView1.Columns[3].HeaderText = "Versão";
            dataGridView1.Columns[4].HeaderText = "Ano Fab.";
            dataGridView1.Columns[5].HeaderText = "Ano Mod.";
            dataGridView1.Columns[6].HeaderText = "Cor";
            dataGridView1.Columns[7].HeaderText = "Placa";
            dataGridView1.Columns[8].HeaderText = "Renavam";
            dataGridView1.Columns[9].HeaderText = "Observações";
            dataGridView1.Columns[10].HeaderText = "Dt. Entrada";
            dataGridView1.Columns[11].HeaderText = "Vr. Entrada";
            dataGridView1.Columns[12].HeaderText = "Cliente Entrada";

           
        }


        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }
         private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PreencherDataGrid(null);
        }

        private void txtConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PreencherDataGrid(txtConsulta.Text);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e){
            movimentacao.Cod_Mov_Veiculos = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            movimentacao.Cod_Marca = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            movimentacao.Cod_Modelo = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            movimentacao.Versao = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            movimentacao.Ano_Fabricacao = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            movimentacao.Ano_Modelo = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            movimentacao.Cor = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            movimentacao.Placa = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            movimentacao.Renavam = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            movimentacao.Observacoes = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            movimentacao.Valor_Entrada = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            frmViewVeiculo frmViewVeiculo = new frmViewVeiculo(movimentacao);
            frmViewVeiculo.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
