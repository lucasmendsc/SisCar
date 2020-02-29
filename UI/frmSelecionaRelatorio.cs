using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace UI
{
    public partial class frmSelecionaRelatorio : Form
    {
        public frmSelecionaRelatorio()
        {
            InitializeComponent();

            
        }

        private void frmSelecionaRelatorio_Load(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            list.Add("Todos os lançamentos");
            list.Add("Lançamentos saída loja");
            list.Add("Lançamentos entradas");
            list.Add("Lançamentos saidas veiculos");

            cbxRelatorios.DataSource = list;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btoOk_Click(object sender, EventArgs e)
        {
            frmRelatorio_lancamentos frmRelatorio = new frmRelatorio_lancamentos(dtInicio.Value.ToString("dd.MM.yyyy"), dtFim.Value.ToString("dd.MM.yyyy"), cbxRelatorios.SelectedIndex.ToString());
            frmRelatorio.Show();
        }
    }
}
