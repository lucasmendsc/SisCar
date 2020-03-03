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

namespace UI
{
    public partial class frmVisualizar : Form
    {

        string marca, modelo, versao, anoFab, anoMod, cor, placa, renavam, obs;
        string nome, telefone;

        private void lbDescrição_Click(object sender, EventArgs e)
        {

        }

        
        public frmVisualizar(ArrayList row, int flag)
        {
            InitializeComponent();

            this.marca = row[1].ToString();
            this.modelo = row[2].ToString();
            this.versao = row[3].ToString();
            this.anoFab = row[4].ToString();
            this.anoMod = row[5].ToString();
            this.cor = row[6].ToString();
            this.placa = row[7].ToString();
            this.renavam = row[8].ToString();
            this.obs = row[9].ToString();
            
            if(flag == 1)
            {
                this.nome = row[12].ToString();
                this.telefone = row[13].ToString();
            }
            else
            {
                this.nome = row[15].ToString();
                this.telefone = row[16].ToString();
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void frmVisualizar_Load(object sender, EventArgs e)
        {

            limparLabels();


            lbMarca.Text = marca;
            lbModelo.Text = modelo;
            lbVersao.Text = versao;
            lbAnoFab.Text = anoFab;
            lbAnoMod.Text = anoMod;
            lbCor.Text = cor;
            lbPlaca.Text = placa;
            lbRenavam.Text = renavam;
            lbNome.Text = nome;
            lbTelefone.Text = telefone;
            
        }

        private void limparLabels()
        {
            lbMarca.Text = "";
            lbModelo.Text = "";
            lbVersao.Text = "";
            lbAnoFab.Text = "";
            lbAnoMod.Text = "";
            lbCor.Text = "";
            lbPlaca.Text = "";
            lbRenavam.Text = "";
            lbNome.Text = "";
            lbTelefone.Text = "";
            
        }
    }
}
