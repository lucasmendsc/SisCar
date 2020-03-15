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
using Microsoft.Reporting.WinForms;

namespace UI
{
    public partial class frmRelatorio_lancamentos : Form
    {
        //Indice = 0 -> Todos os relatorios
        //Indice = 1 -> Lançamentos saidas veiculos
        //Indice = 2 -> Lançamentos entradas
        //Indice = 3 -> Saídas loja
        string tipo, dtInicio, dtFim, indiceRelatorio, placa;
        string simbolo = "<>";

        public frmRelatorio_lancamentos()
        {
            InitializeComponent();
        }

        public frmRelatorio_lancamentos(string dtInicio, string dtFim, string indiceRelatorio)
        {
            InitializeComponent();
            this.dtInicio = dtInicio;
            this.dtFim = dtFim;
            this.indiceRelatorio = indiceRelatorio;
        }

        private void frmRelatorio_lancamentos_Load(object sender, EventArgs e)
        {
            if (indiceRelatorio.Equals("2"))
            {
                tipo = "ENTRADA";
                placa = "%";
            }else if (indiceRelatorio.Equals("3"))
            {
                tipo = "SAIDA";
                simbolo = "=";
                placa = "";
            }

            CaixaBLL caixaBLL = new CaixaBLL();
            DataTable dt = caixaBLL.consultaLancamentos(tipo, dtInicio, dtFim, placa, simbolo);
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
