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
            list.Add("Lançamentos saidas veiculos");
            list.Add("Lançamentos entradas");
            list.Add("Lançamentos saidas loja");

            cbxRelatorios.DataSource = list;
        }

       
        private void btoOk_Click(object sender, EventArgs e)
        {
            switch (cbxRelatorios.SelectedIndex.ToString())
            {
                case "0":
                    frmRelatorioGeral frm = new frmRelatorioGeral(dtInicio.Value.ToString("dd.MM.yyyy"), dtFim.Value.ToString("dd.MM.yyyy"));
                    frm.ShowDialog();
                    break;
                case "1":
                    frmGastosCarro frmGastos = new frmGastosCarro(dtInicio.Value.ToString("dd.MM.yyyy"), dtFim.Value.ToString("dd.MM.yyyy"));
                    frmGastos.ShowDialog();
                    break;
                default:
                    frmRelatorio_lancamentos frmRelatorio = new frmRelatorio_lancamentos(dtInicio.Value.ToString("dd.MM.yyyy"), dtFim.Value.ToString("dd.MM.yyyy"), cbxRelatorios.SelectedIndex.ToString());
                    frmRelatorio.ShowDialog();
                    break;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
