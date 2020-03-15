using BLL;
using Microsoft.Reporting.WinForms;
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
    public partial class frmRelatorioGeral : Form
    {
        string dtInicio, dtFim;
        public frmRelatorioGeral(string dataInicio, string dataFim)
        {
            InitializeComponent();
            this.dtInicio = dataInicio;
            this.dtFim = dataFim;
        }

        private void frmRelatorioGeral_Load(object sender, EventArgs e)
        {
            CaixaBLL caixaBLL = new CaixaBLL();
            DataTable dt = caixaBLL.consultaLancamentos("%", dtInicio, dtFim, "%", "<>");
            DataTable dtCaixa = caixaBLL.consultarTodosOsCaixas();
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportDataSource rds1 = new ReportDataSource("DataSet2", dtCaixa);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
    }
}
