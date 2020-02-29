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
        //Indice = 1 -> Lançamentos saída loja
        //Indice = 2 -> Lançamentos entradas
        //Indice = 3 -> Gastos Veiculos
        string tipo, dtInicio, dtFim, indiceRelatorio, placa;

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
            if (indiceRelatorio.Equals("0"))
            {
                tipo = "%";
                placa = "%";

            }else if (indiceRelatorio.Equals("1"))
            {
                tipo = "SAIDA";
                placa = "";
            }else if (indiceRelatorio.Equals("2"))
            {
                tipo = "ENTRADA";
                placa = "%";
            }

            CaixaBLL caixaBLL = new CaixaBLL();
            DataTable dt = caixaBLL.consultaLancamentos(tipo, dtInicio, dtFim, placa);
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
