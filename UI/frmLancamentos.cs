using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;
using System.Collections;

namespace UI
{
    public partial class frmLancamento : Form
    {

        public frmLancamento()
        {
            InitializeComponent();
        }

        public frmLancamento(int id)
        {
            InitializeComponent();
            id_caixa = id;
        }

        int id_caixa = 0;

        private void btConcluir_Click(object sender, EventArgs e)
        {
            verificarCampos();

            Lancamentos lancamentos = new Lancamentos();
            lancamentos.Descricao = txtDesc.Text;
            lancamentos.Data = dtLanc.Text.ToString();
            lancamentos.Valor = Convert.ToDouble(txtValor.Text);
            lancamentos.Caixa = id_caixa;
            CaixaBLL caixabll = new CaixaBLL();

            if (rbEntrada.Checked)
            {
                lancamentos.Tipo = "ENTRADA";
                caixabll.inserirLancamentos(lancamentos);


            }
            else if (rbSaida.Checked)
            {
                lancamentos.Tipo = "SAIDA";

                if (rbCaixa.Checked)
                {

                    caixabll.inserirLancamentos(lancamentos);
                }
                else if (rbVeiculo.Checked)
                {

                }

            }


            MessageBox.Show("Lançamento inserido com sucesso !");

            this.Close();

        }

        private string converterData(string data)
        {
            string[] dt = data.Split('/', ' ');
            return dt[0] + "." + dt[1] + "." + dt[2];
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void verificarCampos()
        {
            if (string.IsNullOrEmpty(txtDesc.Text))
                MessageBox.Show("A descrição deve ser informada");
            if (string.IsNullOrEmpty(txtValor.Text))
                MessageBox.Show("O valor deve ser informado");
        }


        private void frmLancamento_Load(object sender, EventArgs e)
        {
            string data = DateTime.Now.Date.ToString();

            dtLanc.Text = converterData(data);

            lbCategoria.Visible = false;
            rbVeiculo.Visible = false;
            rbCaixa.Visible = false;
            label6.Visible = false;
            edtPlaca.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (label6.Visible || edtPlaca.Visible)
            {
                label6.Visible = false;
                edtPlaca.Visible = false;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rbVeiculo_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            edtPlaca.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbSaida_CheckedChanged(object sender, EventArgs e)
        {
            lbCategoria.Visible = true;
            rbCaixa.Visible = true;
            rbVeiculo.Visible = true;
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (lbCategoria.Visible || rbVeiculo.Visible || rbCaixa.Visible)
            {
                lbCategoria.Visible = false;
                rbVeiculo.Visible = false;
                rbCaixa.Visible = false;
            }
            if (label6.Visible || edtPlaca.Visible)
            {
                label6.Visible = false;
                edtPlaca.Visible = false;
            }

        }
    }
}
