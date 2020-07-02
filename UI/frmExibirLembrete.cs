using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using Models;
using DAL;
using System.Reflection;

namespace UI
{
    public partial class frmExibirLembrete : Form
    {
        private string lembrete;
        DataTable dt;
        String[] lista;
        public frmExibirLembrete()
        {
            InitializeComponent();
            this.dt = LembreteDAL.getInstance().RetornaLembretePorStatus(0);
            lista = new string[dt.Rows.Count];
            if (dt.Rows.Count > 0)
            {
                int indice = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    lista[indice] = dr[1].ToString();
                    indice++;
                }

                listCheck.Items.AddRange(lista);
                
            }

        }

        private void frmExibirLembrete_Load(object sender, EventArgs e)
        {
            

        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
