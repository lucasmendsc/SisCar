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
    public partial class frmCaixa : Form
    {

        private string dataCaixa = "";
        private int idCaixa = 0;
        public frmCaixa()
        {
            InitializeComponent();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btAbrirCaixa_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Hide();
                string situãcao = retornaSitiacao();
                String dataNow = converterDataTime(DateTime.Now.Date.ToString());
                if (situãcao != null)
                {
                    if (situãcao.Equals("A"))
                    {
                        MessageBox.Show("O caixa ainda está aberto !");
                    }
                    else if (dataCaixa.Equals(dataNow))
                    {
                        MessageBox.Show("Existe um caixa com a data de hoje");
                        reabrirCaixa();
                        
                    }else
                    {
                        frmAbrirCaixa frmAbrirCaixa = new frmAbrirCaixa();
                        frmAbrirCaixa.ShowDialog();
                    }
                }
                else
                {
                    frmAbrirCaixa frmAbrirCaixa = new frmAbrirCaixa();
                    frmAbrirCaixa.ShowDialog();
                }

            }
            finally
            {
                this.Show();
                verificarSituacaoCaixa();
            }
            
            
        }

        private void reabrirCaixa()
        {
            try
            {
                CaixaBLL caixabll = new CaixaBLL();
                caixabll.reabrirCaixa(idCaixa);
                verificarSituacaoCaixa();

            }catch(Exception ex)
            {
                MessageBox.Show("Impossivel reabrir caixa: " + ex.Message);
            }
            
        }

        public string converterDataTime(string data)
        {
            string[] dt = data.Split('/',' ');

            return dt[0] + "." + dt[1] + "." + dt[2];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCaixa_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private string retornaSitiacao()
        {
            CaixaBLL caixabll = new CaixaBLL();
            DataTable dataTable = caixabll.recuperarUltimoCaixa();

            if (dataTable.Rows.Count > 0)
            {
                string situacao = dataTable.Rows[0]["SITUACAO"].ToString();
                dataCaixa = converterDataTime(dataTable.Rows[0]["DATA"].ToString());
                idCaixa = Convert.ToInt32(dataTable.Rows[0]["ID"].ToString());
                return situacao;
            }
            return null;
        }

        

        private void verificarSituacaoCaixa()
        {
            string dt = DateTime.Now.Date.ToString();
            CaixaBLL caixabll = new CaixaBLL();
            DataTable dataTable = caixabll.recuperarUltimoCaixa();

            if (dataTable.Rows.Count > 0)
            {
                string situacao = retornaSitiacao();
                if (situacao.Equals("A"))
                {
                    lbSituacaoF.Visible = false;
                    lbSituacaoA.Visible = true;

                    lbOperador.Text = dataTable.Rows[0]["OPERADOR"].ToString();
                    lbSaldoInicial.Text = dataTable.Rows[0]["SALDO"].ToString();
                    lbDataCaixa.Text = dataTable.Rows[0]["DATA"].ToString();
                    
                    preencherDataGrid();
                }
                else if (situacao.Equals("F") || situacao.Equals(""))
                {
                    lbDataCaixa.Text = converterDataTime(dt);
                    lbSaldoInicial.Text = "0,00";
                    lbSaldo.Text = "0,0";
                    lbSituacaoA.Visible = false;
                    lbSituacaoF.Visible = true;

                    limparDataGrid();
                }
            }
        }



        private void frmCaixa_Load(object sender, EventArgs e)
        {
            verificarSituacaoCaixa();
        }

        private void limparDataGrid()
        {
            for (int i = 0; i < dataGridLanc.RowCount; i++)
            {
                dataGridLanc.Rows[i].DataGridView.Columns.Clear();
            }
            dataGridLanc.Refresh();
        }

        private void btEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbSituacaoF.Visible)
                {
                   
                }
                CaixaBLL caixabll = new CaixaBLL();
                DataTable dataTable = caixabll.recuperarUltimoCaixa();
                int id_caixa = Convert.ToInt32(dataTable.Rows[0]["ID"].ToString());
                this.Hide();
                frmLancamento frmLancamento = new frmLancamento(id_caixa);
                frmLancamento.ShowDialog();
            }
            finally
            {
                
                this.Show();
                preencherDataGrid();
                dataGridLanc.Refresh();
            }

        }


        private void preencherDataGrid()
        {
            CaixaBLL caixabll = new CaixaBLL();
            DataTable dataTable = caixabll.recuperarUltimoCaixa();
            int id_caixa = Convert.ToInt32(dataTable.Rows[0]["ID"].ToString());
            dataGridLanc.DataSource = caixabll.consultaLancamentos(id_caixa);
            DataTable dataTable1 = caixabll.consultaLancamentos(id_caixa);

            dataGridLanc.Columns[0].HeaderText = "ID";
            dataGridLanc.Columns[1].HeaderText = "TIPO";
            dataGridLanc.Columns[2].HeaderText = "DESCRIÇÃO";
            dataGridLanc.Columns[3].HeaderText = "DATA";
            dataGridLanc.Columns[4].HeaderText = "VALOR.";
            dataGridLanc.Columns[5].HeaderText = "ID_CAIXA";

            this.dataGridLanc.Columns[0].Visible = false;
            this.dataGridLanc.Columns[5].Visible = false;

            double entradas = 0, saidas = 0, saldo = 0;
            foreach (DataRow linha in dataTable1.Rows)
            {
                if (linha["TIPO"].Equals("ENTRADA"))
                {
                    entradas += Convert.ToDouble(linha["VALOR"].ToString());
                }
                else if (linha["TIPO"].Equals("SAIDA"))
                {
                    saidas += Convert.ToDouble(linha["VALOR"].ToString());
                }

            }
            saldo = entradas - saidas;
            double saldoInicial = Convert.ToDouble(dataTable.Rows[0]["SALDO"].ToString());
            lbSaldoInicial.Text = saldoInicial.ToString();
            lbSaldo.Text = (saldoInicial + saldo).ToString();
        }

        private void btFecharCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmFecharCaixa frmFecharCaixa = new frmFecharCaixa(lbSaldo.Text);
                frmFecharCaixa.ShowDialog();
            }
            finally
            {
                this.Show();
                verificarSituacaoCaixa();
            }
            
        }

        private void dataGridLanc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dataGridLanc.Rows[e.RowIndex];
            if (row.Cells["TIPO"].Value != null) {
                if (row.Cells["TIPO"].Value.Equals("SAIDA"))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if ((row.Cells["TIPO"].Value.Equals("ENTRADA")))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
    }
}
