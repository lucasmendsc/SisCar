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
        public frmRelatorio_lancamentos()
        {
            InitializeComponent();
        }

        private void frmRelatorio_lancamentos_Load(object sender, EventArgs e)
        {
            CaixaBLL caixaBLL = new CaixaBLL();
            DataTable dt = caixaBLL.consultaLancamentos();
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
