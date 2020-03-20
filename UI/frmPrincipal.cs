using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using BLL;
using DAL;
using Models;
using Tulpep.NotificationWindow;

namespace UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar o Connecta automotivo?", "Connecta ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            Application.Exit();
        }
        public string usuario;

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            PerfilBLL perfilbll = new PerfilBLL();
            Perfil perfil = new Perfil();

            toolStripStatusLabel1.Text = "Bem-vindo " + usuario + "!";

            if (perfilbll.VerificarCoreFundo(perfil).Equals("C"))
                
                this.BackColor = ColorTranslator.FromHtml(perfilbll.RetornarCoreFundo(perfil));
            
            else if (perfilbll.VerificarCoreFundo(perfil).Equals("I"))
            
                this.BackgroundImage = Image.FromFile(perfilbll.RetornarCoreFundo(perfil));

            exibirLembretes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Data: " + DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = "Hora: " + DateTime.Now.ToShortTimeString();

            
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void consultaDetranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "www.detran.pe.gov.br");
        }

        private void exibirBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exibirBarraToolStripMenuItem.Checked)
                toolStrip1.Show();
            else
                toolStrip1.Hide();
        }

        private void corDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg1 = new DialogResult();
            
            if (this.BackgroundImage != null)
            {
                dlg1 = MessageBox.Show("Deseja descartar o papel de parede atual?", "Cor de Fundo", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            };

            if ((dlg1 == DialogResult.Yes) || (dlg1 == DialogResult.None))
            {
                Perfil perfil = new Perfil();
                PerfilBLL perfilbll = new PerfilBLL();

                colorDialog1.ShowDialog();
                this.BackColor = colorDialog1.Color;
                perfil.Cor = ColorTranslator.ToHtml(this.BackColor);
                perfilbll.SalvarCor(perfil);
                this.BackgroundImage = null;
            };            
        }

        private void papelDeParedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecione a figura para o fundo";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Arquivos de Imagem|(*.bmp;*.jpg; *.gif)|Todos os arquivos|*.*";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                Perfil perfil = new Perfil();
                PerfilBLL perfilbll = new PerfilBLL();

                perfil.Imagem = openFileDialog1.FileName;
                perfilbll.SalvarImagem(perfil);
            };               
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes1 = new frmClientes();
            frmClientes1.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios1 = new frmUsuarios();
            frmUsuarios1.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas frmMarcas1 = new frmMarcas();
            frmMarcas1.ShowDialog();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModelos frmModelos1 = new frmModelos();
            frmModelos1.ShowDialog();
        }

        private void entradaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacao frmMovimentacao1 = new frmMovimentacao();
            frmMovimentacao1.Entrada_Saida = "E";
            frmMovimentacao1.ShowDialog();
        }

        private void saídaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacao frmMovimentacao1 = new frmMovimentacao();
            frmMovimentacao1.Entrada_Saida = "S";
            frmMovimentacao1.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoque frmEstoque1 = new frmEstoque();
            frmEstoque1.ShowDialog();
        }

        private void gráficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraficos frmGraficos1 = new frmGraficos();
            frmGraficos1.ShowDialog();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Veiculos_Crud veiculos_Crud = new Veiculos_Crud();
            veiculos_Crud.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {         

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes1 = new frmClientes();
            frmClientes1.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmCaixa frmCaixa = new frmCaixa();
            frmCaixa.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLembretes frmLembretes = new frmLembretes();
            frmLembretes.ShowDialog();
        }

        public void exibirLembretes()
        {
            DataTable dt = LembreteBLL.getInstance().consultarTodosLembretes(null);

            foreach (DataRow dr in dt.Rows)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "LEMBRETE";
                popup.ContentText = dr["descricao"].ToString();
                popup.Delay = 1000000;
                popup.Popup();// show 

                               
            }

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            exibirLembretes();
        }
    }
}
