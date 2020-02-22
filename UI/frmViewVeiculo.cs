using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using BLL;

namespace UI
{
    public partial class frmViewVeiculo : Form
    {
        Movimentacao movimentacao1 = new Movimentacao();
        public frmViewVeiculo()
        {
            //InitializeComponent();

            //MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();
            //Movimentacao movimentacao = new Movimentacao();

           // movimentacaobll.inserirCodigo(movimentacao);
           // txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
           // btApagar.Enabled = false;
           // cbMARCA.Focus();
        }

        public frmViewVeiculo(Movimentacao movimentacao)
        {
            InitializeComponent();
            frmViewVeiculo_Load(null, null);
            movimentacao1 = movimentacao;
            
            txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos.ToString();
            cbMARCA.Text = movimentacao.Cod_Marca.ToString();
            cbMODELO.Text = movimentacao.Cod_Modelo.ToString();
            txtVERSAO.Text = movimentacao.Versao.ToString();
            cbANO_FABRICACAO.Text = movimentacao.Ano_Fabricacao.ToString();
            cbANO_MODELO.Text = movimentacao.Ano_Modelo.ToString();
            txtCOR.Text = movimentacao.Cor.ToString();
            txtPLACA.Text = movimentacao.Placa.ToString();
            txtRENAVAM.Text = movimentacao.Renavam.ToString();
            txtOBSERVACOES.Text = movimentacao.Observacoes.ToString();
            txtVALOR_ENTRADA.Text = movimentacao.Valor_Entrada.ToString();

            PreencherDataGrid(int.Parse(txtCOD_MOV_VEICULOS.Text));
            

            
        }

        private void ZeraCampos()
        {
            txtDesc.Text = "";
            txtResp.Text = "";
            txtValor.Text = "";
        }


        private void frmViewVeiculo_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtResp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtOBSERVACOES_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public string converterDataTime(string data)
        {
            string[] dt = data.Split('/', ' ');

            return dt[0] + "." + dt[1] + "." + dt[2];
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Gastos gastos = new Gastos();
            GastosBLL gastosBLL = new GastosBLL();

            try
            {
                gastos.Descricao = txtDesc.Text;
                gastos.Responsavel = txtResp.Text;
                gastos.Data = converterDataTime(dtData.Text);
                gastos.Valor = float.Parse(txtValor.Text);
                gastos.Movimentacao = movimentacao1;

                gerarLancamento(gastos);

                gastosBLL.inserirGastos(gastos);

                

            }
            catch (Exception ex){
                MessageBox.Show("Erro ao inserir gastos: "+ex.Message);
            }

            PreencherDataGrid(int.Parse(txtCOD_MOV_VEICULOS.Text));

            ZeraCampos();
        }

        private void gerarLancamento(Gastos gastos)
        {
            CaixaBLL caixabll = new CaixaBLL();
            DataTable dataTable = caixabll.recuperarCaixaAtual();
            try
            {
                if (dataTable.Rows.Count > 0)
                {
                    Lancamentos lancamentos = new Lancamentos();
                    lancamentos.Tipo = "SAIDA";
                    lancamentos.Descricao = gastos.Descricao;
                    lancamentos.Data = converterDataTime(DateTime.Now.Date.ToString());
                    lancamentos.Valor = gastos.Valor;
                    lancamentos.Caixa = Convert.ToInt32(dataTable.Rows[0]["ID"].ToString());

                    caixabll.inserirLancamentos(lancamentos);
                    
                }
                else
                {
                    MessageBox.Show("O caixa está fe");
                }
            }catch(Exception ex)
            {
                throw new Exception("Erro para inserir lançamento no caixa:"+ex.Message);
            }
            
        }

        public double calcularValor(DataTable dgv)
        {

            double total = 0.0;

            foreach(DataRow linha in dgv.Rows)
            {
                total += Convert.ToDouble(linha["Valor"].ToString());
            }



            return total;

        }

        private void PreencherDataGrid(int idVeiculo)
        {
            GastosBLL gastosBLL = new GastosBLL();


            dataGridView1.DataSource = gastosBLL.consultarGastosVeiculos(idVeiculo);
            DataTable dataTable = gastosBLL.consultarGastosVeiculos(idVeiculo);

            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Descrição";
            dataGridView1.Columns[2].HeaderText = "Responsável";
            dataGridView1.Columns[3].HeaderText = "Data";
            dataGridView1.Columns[4].HeaderText = "Valor";

            lbCustos.Text = calcularValor(dataTable).ToString();
            lbValor.Text = (double.Parse(txtVALOR_ENTRADA.Text) + double.Parse(lbCustos.Text)).ToString();


        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos implementando esta função ");
            this.Dispose();
        }
    }
}
