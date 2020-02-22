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
using UI;

namespace UI
{
    public partial class frmAbrirCaixa : Form
    {
        public frmAbrirCaixa()
        {
            InitializeComponent();
        }

        private void frmAbrirCaixa_Load(object sender, EventArgs e)
        {
            string dt = DateTime.Now.Date.ToString();
            dtAbrirCaixa.Text = converteData(dt);
        }

        private void btConcluir_Click(object sender, EventArgs e)
        {
            CaixaBLL caixabll = new CaixaBLL();
            Caixa caixa = new Caixa();
            try
            {

                if (verificarCampos())
                {
                    caixa.Operador = txtOperador.Text;
                    caixa.Data = dtAbrirCaixa.Text;
                    caixa.Saldo = Convert.ToInt32(txtSaldo.Text);
                    caixa.Situacao = "A";

                    caixabll.abrirCaixa(caixa);
                    this.Close();                   
                }
            }catch(Exception)
            {
                MessageBox.Show("Verifique os campos!", "Consulta Vazia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            
        }

        private Boolean verificarCampos()
        {
            if (string.IsNullOrEmpty(txtOperador.Text))
            {
                MessageBox.Show("O campo Operador deve ser preenchido.");
                return false;
            }else if (string.IsNullOrEmpty(txtSaldo.Text))
            {
                MessageBox.Show("O campo valor deve ser preenchido");
                return false;
            }
            return true;
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

        //Garante que só aceita numeros no valor
        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
