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
        string dataInicio, dataFim;
        public frmGastosCarro(string dtInicio, string dtFim)
        {
            this.dataInicio = dtInicio;
            this.dataFim = dtFim;
            InitializeComponent();
        }

        private void frmGastosCarro_Load(object sender, EventArgs e)
        {

            GastosVeiculosDAL gastos = new GastosVeiculosDAL();
            DataTable dt = gastos.buscarTodosOsGastos(dataInicio, dataFim);

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();


        }

        private string converterData(String data)
        {
            string dtConvert;

            string[] dt_temp = data.Split('/',' ');

            return dtConvert = dt_temp[0] + "/" + dt_temp[1]+"/"+dt_temp[2];
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
