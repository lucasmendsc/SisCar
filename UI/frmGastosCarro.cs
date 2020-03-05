using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Microsoft.Reporting.WinForms;

namespace UI
{
    public partial class frmGastosCarro : Form
    {
        public frmGastosCarro(string dtInicio, string dtFim)
        {
            InitializeComponent();
        }

        private void frmGastosCarro_Load(object sender, EventArgs e)
        {

            GastosVeiculosDAL gastos = new GastosVeiculosDAL();
            DataTable dt = gastos.buscarTodosOsGastos();

            MessageBox.Show( dt.Rows[0].ToString());
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportDataSource rds1 = new ReportDataSource("DataSet2", dt);
            ReportDataSource rds2 = new ReportDataSource("DataSet3", dt);
            ReportDataSource rds3 = new ReportDataSource("DataSet4", dt);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rds1);
            reportViewer1.LocalReport.DataSources.Add(rds2);
            reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();


        }
    }
}
