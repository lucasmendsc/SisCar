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

namespace UI
{
    public partial class frmExibirLembrete : Form
    {
        private string lembrete;
        public frmExibirLembrete(string lembrete)
        {
            InitializeComponent();
            this.lembrete = lembrete;
        }

        private void frmExibirLembrete_Load(object sender, EventArgs e)
        {
            lbLembrete.Text = lembrete;

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
    }
}
