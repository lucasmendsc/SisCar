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
    public partial class frmLembretes : Form
    {
        public frmLembretes()
        {
            InitializeComponent();
        }

        private void frmLembretes_Load(object sender, EventArgs e)
        {

        }

        private void preeencherDataGrid()
        {
            MarcaBLL marcabll = new MarcaBLL();
            dataGridView1.DataSource = marcabll.consultarMarca(NomeCliente);

            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Marca";
        }

        
    }
}
