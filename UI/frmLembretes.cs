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

namespace UI
{
    public partial class frmLembretes : Form
    {
        public frmLembretes()
        {
            InitializeComponent();
        }

        private void frmLembretes_Load(object sender, EventArgs e)
        {
            preeencherDataGrid(null);
        }

        private void preeencherDataGrid(string descricao)
        {
            chkLembrar.Checked = true;
            dataGridView1.DataSource =  LembreteBLL.getInstance().consultarTodosLembretes(descricao);

        }

        private void btGRAVAR_Click(object sender, EventArgs e)
        {
            //status 0 equivale a ativado
            //status 1 equivale a desativado
            checarCampos();
            Lembrete lembrete = new Lembrete();
            lembrete.Descricao = richTextBox1.Text;
            lembrete.Data = converteData(dtHora.Value.ToString());
            lembrete.Status = "0";
            try
            {
                if (txtCOD_LEMBRETE.Text.Equals(""))
                {
                    LembreteBLL.getInstance().inserirLembrete(lembrete);
                }
                else
                {
                    lembrete.Id = txtCOD_LEMBRETE.Text;
                    LembreteBLL.getInstance().atualizarLembrete(lembrete);
                }

                richTextBox1.Text = "";
                               
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar lembrete,"+ex.Message);
            }
            finally
            {
                MessageBox.Show("Lembrete cadastrado/atualizado com sucesso.");
            }
        }

        private void checarCampos()
        {
            if (richTextBox1.Text == "")
                MessageBox.Show("Campo lembrete vazio");
        }
        private string converteData(string data)
        {
            string[] dt = data.Split('/', ' ');
            return dt[0] + "." + dt[1] + "." + dt[2];
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            preeencherDataGrid(null);
        }

        private void btFECHAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zerarCampos()
        {
            txtCOD_LEMBRETE.Text = "";
            txtCONSULTA.Text = "";
            richTextBox1.Text = "";
            dtHora.Value = DateTime.Now;
        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            Lembrete lembrete = new Lembrete();
            lembrete.Descricao = richTextBox1.Text;
            lembrete.Id = txtCOD_LEMBRETE.Text;
            lembrete.Data = converteData(dtHora.Value.ToString());
            lembrete.Status = chkLembrar.Checked.ToString();

            if (MessageBox.Show("Deseja EXCLUIR esse lembrete ?", "Excluir lembrete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LembreteBLL.getInstance().excluirLmebrete(lembrete);
                zerarCampos();
                btEXCLUIR.Enabled = false;
            }
        }

        private void txtCONSULTA_KeyDown(object sender, KeyEventArgs e)
        {
            //realiza o filtro 
            if (e.KeyCode == Keys.Enter)
                preeencherDataGrid(txtCONSULTA.Text);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //converte as letras para maiusculas
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                tabControlLembretes.SelectTab(0);
                richTextBox1.Focus();
                btEXCLUIR.Enabled = true;
                txtCONSULTA.Text = "";

                txtCOD_LEMBRETE.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                richTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dtHora.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                if(dataGridView1.CurrentRow.Cells[3].Value.ToString().Equals("0"))
                    chkLembrar.Checked = true;
                else
                    chkLembrar.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("A Pesquisa selecionada, não contém Dados!", "Consulta Vazia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                zerarCampos();
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            zerarCampos();
        }
    }
}
