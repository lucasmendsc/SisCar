using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmFecharCaixa : Form
    {
        public frmFecharCaixa(string saldo)
        {
            InitializeComponent();
            CaixaBLL caixabll = new CaixaBLL();
            DataTable dt = caixabll.recuperarCaixaAtual();

            lbCaixa.Text = dt.Rows[0]["OPERADOR"].ToString();
            lbSaldoTot.Text = saldo;
            lbSaldoFin.Text = saldo;
            
        }

        private void verificarCampos()
        {
            if (string.IsNullOrEmpty(txtSangria.Text))
                MessageBox.Show("A sangria deve ser informada !");
        }

        private void btConcluir_Click(object sender, EventArgs e)
        {
            try
            {
                CaixaBLL caixabll = new CaixaBLL();
                DataTable dt = caixabll.recuperarCaixaAtual();
                Lancamentos lancamento = new Lancamentos();
                string data = DateTime.Now.Date.ToString();

                lancamento.Tipo = "FECHAMENTO";
                lancamento.Descricao = txtSangria.Text;
                lancamento.Data = converteData(data);
                lancamento.Valor = Double.Parse(dt.Rows[0]["SALDO"].ToString());
                lancamento.Caixa = Int32.Parse(dt.Rows[0]["ID"].ToString());

                caixabll.fecharCaixa(lancamento);
                MessageBox.Show("Caixa fechado com sucesso !");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao realizar fechamento do caixa: "+ex.Message);
            }
           
        }
        private string converteData(string data)
        {
            string[] dt = data.Split('/',' ');
            return dt[0] + "." + dt[1] + "." + dt[2];
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSangria_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmFecharCaixa_Load(object sender, EventArgs e)
        {
            lbData.Text = converteData(DateTime.Now.Date.ToString());
        }

        private void txtSangria_Enter(object sender, EventArgs e)
        {
            //calcula o saldo final:  (total - sangria)
            double totalCaixa = 0, sangria = 0, saldoFinal;
            totalCaixa = Convert.ToDouble(lbSaldoTot.Text);
            sangria = Convert.ToDouble(txtSangria.Text);
            saldoFinal = totalCaixa - sangria;


            lbSaldoFin.Text = saldoFinal.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
