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
using System.Collections;
using BLL;

namespace UI
{
    public partial class frmImprimirMovimentacao : Form
    {
        DataTable dt;
        ArrayList marcas = new ArrayList();
        ArrayList modelos = new ArrayList();
        ArrayList mov = new ArrayList();

        MovimentacaoBLL movBLL = new MovimentacaoBLL();
        MarcaBLL marcaBLL = new MarcaBLL();
        ModeloBLL modeloBLL = new ModeloBLL();
        ClienteBLL clienteBLL = new ClienteBLL();

        public frmImprimirMovimentacao()
        {
            InitializeComponent();
        }

        public frmImprimirMovimentacao(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
        }

        private void joinTables()
        {
            DataTable dtMarcas = marcaBLL.consultarMarca("%");
            DataTable dtModelos = modeloBLL.consultarModelo("%");
            DataTable dtCliente = clienteBLL.consultarCliente("%");
            DataTable dtMov = movBLL.cunsultarTodaMovimentacao();

            foreach (DataRow row in dtMov.Rows)
            {
                foreach (DataRow mod in dtModelos.Rows) 
                {
                    if (row["cod_modelo"].ToString() == mod["cod_modelo"].ToString())
                    {
                        row["observacoes"] = mod["ds_modelo"].ToString();

                    }
                }

                foreach (DataRow marc in dtMarcas.Rows)
                {
                    if (row["cod_marca"].ToString() == marc["cod_marca"].ToString())
                    {
                        row["renavam"] = marc["ds_marca"].ToString();

                    }
                }

                foreach (DataRow cli in dtCliente.Rows)
                {
                    if (row["cod_cliente_entrada"].ToString() == cli["cod_cliente"].ToString())
                    {
                        row["cor"] = cli["nome"].ToString();

                    }else if(row["cod_cliente_saida"] != null && row["cod_cliente_saida"].ToString() == cli["cod_cliente"].ToString())
                    {
                        row["versao"] = cli["nome"].ToString();
                    }
                    else
                    {
                        row["versao"] = "";
                    }
                }
            }



            dt = dtMov;


        }

        private void frmImprimirMovimentacao_Load(object sender, EventArgs e)
        {
            joinTables();
            reportViewer1.LocalReport.DataSources.Clear();
            if(dt != null)
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            else
            {
                MessageBox.Show("A consulta não retornou nenhum dado a ser impresso !");
            }
            

            this.reportViewer1.RefreshReport();
        }
    }
}
