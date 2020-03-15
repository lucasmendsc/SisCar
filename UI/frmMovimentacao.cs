using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using BLL;
using System.Drawing.Printing;
using System.Collections;

namespace UI
{
    public partial class frmMovimentacao : Form
    {
        private String consulta = null;
        public String Entrada_Saida = null;
        private String consulta1 = null;
        public string NomeCliente = null;
        public string CodigoCliente = null;
        int rowSelected = 0;

        public frmMovimentacao()
        {
            InitializeComponent();

            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();
            Movimentacao movimentacao = new Movimentacao();

            movimentacaobll.inserirCodigo(movimentacao);
            txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
            btEXCLUIR.Enabled = false;
            cbMARCA.Focus();

            ClienteBLL clientebll = new ClienteBLL();
            Cliente cliente = new Cliente();

            clientebll.inserirCodigo(cliente);
            txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
            btEXCLUIR.Enabled = false;
            txtCOD_CLIENTE.Enabled = false;


        }

        private void ZeraCampos()
        {
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();
            Movimentacao movimentacao = new Movimentacao();

            movimentacaobll.inserirCodigo(movimentacao);
            txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;

            //Limpa todos os campos  
            cbMARCA.SelectedIndex = -1;
            cbMODELO.SelectedIndex = -1;
            txtVERSAO.Clear();
            cbANO_FABRICACAO.SelectedIndex = -1;
            cbANO_MODELO.SelectedIndex = -1;
            txtCOR.Clear();
            txtPLACA.Clear();
            txtRENAVAM.Clear();
            txtOBSERVACOES.Clear();
            txtVALOR_ENTRADA.Clear();
            txtVALOR_SAIDA.Clear();
            //txtCOD_CLIENTE_ENTRADA.Clear();
            //txtCOD_CLIENTE_SAIDA.Clear();
            //txtNOME_CLIENTE_ENTRADA.Clear();
            //txtNOME_CLIENTE_SAIDA.Clear();            
            btEXCLUIR.Enabled = false;
            consulta = null;
        }

        /*private void PreencherValorTotal(DataTable dataTable)
         { 
             double totalVendas = 0;
             double totalCompras = 0;
             foreach (DataRow linha in dataTable.Rows)
             {
                 if( !String.IsNullOrEmpty(linha[14].ToString()))
                     totalVendas += Double.Parse(linha[14].ToString());
                 if (!String.IsNullOrEmpty(linha[11].ToString()))
                     totalCompras += Double.Parse(linha[11].ToString());
             }


             lbValorTotal.Text = "R$ " + totalVendas.ToString();
             lbValorLucro.Text = "R$ " + (totalVendas - totalCompras).ToString();
         }*/


        private void PreencherDataGrid(String Texto)
        {
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();
            DataTable dataTable = movimentacaobll.consultarMovimentacaoSaida(Texto);

            if (Entrada_Saida == "E")
            {
                
                dataGridView1.DataSource = movimentacaobll.consultarMovimentacaoApenasEntrada(Texto);
                dataGridView1.Columns[10].HeaderText = "Dt. Entrada";
                // dataGridView1.Columns[11].HeaderText = "Vr. Entrada";
                dataGridView1.Columns[12].HeaderText = "Cliente Entrada";

                dataGridView1.Columns[11].Visible = false;


            }
            else
            {
                dataGridView1.DataSource = movimentacaobll.consultarMovimentacaoSaida(Texto);
                dataGridView1.Columns[10].HeaderText = "Dt. Entrada";
                //dataGridView1.Columns[11].HeaderText = "Vr. Entrada";
                dataGridView1.Columns[12].HeaderText = "Cliente Entrada";
                dataGridView1.Columns[13].HeaderText = "Dt. Saída";
                dataGridView1.Columns[14].HeaderText = "Vr. Saída";
                dataGridView1.Columns[15].HeaderText = "Cliente Saída";

                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[14].Visible = false;

                
                //PreencherValorTotal(dataTable);
                

            }

            dataGridView1.Columns[0].HeaderText = "Cód. Mov.";
            dataGridView1.Columns[1].HeaderText = "Marca";
            dataGridView1.Columns[2].HeaderText = "Modelo";
            dataGridView1.Columns[3].HeaderText = "Versão";
            dataGridView1.Columns[4].HeaderText = "Ano Fab.";
            dataGridView1.Columns[5].HeaderText = "Ano Mod.";
            dataGridView1.Columns[6].HeaderText = "Cor";
            dataGridView1.Columns[7].HeaderText = "Placa";
            dataGridView1.Columns[8].HeaderText = "Renavam";
            dataGridView1.Columns[9].HeaderText = "Observações";

            dataGridView1.Columns[0].Visible = false;
            

            dataGridView1.Refresh();

        }

        private void frmMovimentacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ZeraCampos();

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void frmMovimentacao_Load(object sender, EventArgs e)
        {
            MarcaBLL marcabll = new MarcaBLL();
            if (Entrada_Saida == "E")
            {
                gbVenda.Visible = false;
                this.Text = "Entrada (Compra)";

                btGRAVAR.Enabled = true;
                btEXCLUIR.Enabled = true;
                chkBoxFiltro.Visible = false;

            }
            else
            {
                gbCompra.Visible = false;
                this.Text = "Saída (Venda)";
                tabControl1.SelectTab(1);

                btGRAVAR.Enabled = false;
                btEXCLUIR.Enabled = false;
            }
            preencherDataGrid_clientes();

            cbMARCA.DataSource = marcabll.retornaMarca();
            cbMARCA.DisplayMember = marcabll.retornaMarca().Columns[1].ToString();
            cbMARCA.ValueMember = marcabll.retornaMarca().Columns[0].ToString();
            cbMARCA.SelectedIndex = -1;
        }

        private string converterData(string data)
        {
            string[] dt = data.Split('/');

            return dt[0] + "." + dt[1] + "." + dt[2];
        }

        private void btGRAVAR_Click(object sender, EventArgs e)
        {

            string codCliente = cadastrarCliente();
            Movimentacao movimentacao = new Movimentacao();
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();

            try
            {
                movimentacao.Cod_Mov_Veiculos = txtCOD_MOV_VEICULOS.Text;
                movimentacao.Cod_Marca = Convert.ToString(cbMARCA.SelectedValue);
                movimentacao.Cod_Modelo = Convert.ToString(cbMODELO.SelectedValue);
                movimentacao.Versao = txtVERSAO.Text;
                movimentacao.Ano_Fabricacao = cbANO_FABRICACAO.Text;
                movimentacao.Ano_Modelo = cbANO_MODELO.Text;
                movimentacao.Cor = txtCOR.Text;
                movimentacao.Placa = txtPLACA.Text;
                movimentacao.Renavam = txtRENAVAM.Text;
                movimentacao.Observacoes = txtOBSERVACOES.Text;

                movimentacaobll.verificarCampos(movimentacao);

                if (Entrada_Saida == "E" && codCliente != null)
                {
                    movimentacao.Valor_Entrada = txtVALOR_ENTRADA.Text.Replace(",", ".");
                    movimentacao.Data_Entrada = converterData(txtDATA_ENTRADA.Text);
                    movimentacao.Cod_Cliente_Entrada = codCliente;
                    movimentacaobll.verificarCamposCompra(movimentacao);
                }
                else
                {
                    movimentacao.Valor_Saida = txtVALOR_SAIDA.Text.Replace(",", ".");
                    movimentacao.Data_Saida = converterData(txtDATA_SAIDA.Text);
                    movimentacao.Cod_Cliente_Saida = codCliente;
                    movimentacaobll.verificarCamposVenda(movimentacao);
                    ZeraCamposClientes();
                }

                if (consulta == null && Entrada_Saida == "E")
                {
                    movimentacaobll.inserirMovimentacaoEntrada(movimentacao);
                    MessageBox.Show("A movimentação foi inserida com Sucesso!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (consulta == null && Entrada_Saida == "S")
                {
                    movimentacaobll.inserirMovimentacaoSaida(movimentacao);
                    MessageBox.Show("A saida foi inserida com Sucesso!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (consulta != null && Entrada_Saida == "E")
                {
                    movimentacaobll.atulizarMovimentacaoEntrada(movimentacao);
                    MessageBox.Show("A atualização da movimentação foi efetuado com Sucesso!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (consulta != null && Entrada_Saida == "S")
                {
                    movimentacaobll.atulizarMovimentacaoSaida(movimentacao);
                    MessageBox.Show("A saida foi efetuado com Sucesso!", "Atualização Efetuada com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    consulta = null;
                }

                ZeraCampos();
                movimentacaobll.inserirCodigo(movimentacao);
                txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao inserir: " + ex.Message);
            }
        }

        private void ZeraCamposClientes()
        {
            //Limpa todos os campos
            txtCOD_CLIENTE.Clear();
            txtNOME.Clear();
            txtCPF.Clear();
            txtDATA_NASC.Text = DateTime.Now.ToString();
            txtENDERECO.Clear();
            txtBAIRRO.Clear();
            txtCEP.Clear();
            txtCIDADE.Clear();
            txtFONE1.Clear();
            txtFONE2.Clear();
            txtRG.Clear();
            cbESTADO.SelectedIndex = -1;
            rbMASCULINO.Checked = false;
            rbFEMININO.Checked = false;
            ckRESTRICAO.Checked = false;
            txtCOD_CLIENTE.Enabled = false;
            txtNOME.Focus();
            btEXCLUIR.Enabled = false;

        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            try{
                Movimentacao movimentacao = new Movimentacao();
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();

            movimentacao.Cod_Mov_Veiculos = txtCOD_MOV_VEICULOS.Text;

            if (MessageBox.Show("Deseja EXCLUIR essa Movimentação?", "Excluir Movimentação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                movimentacaobll.excluirMovimentacao(movimentacao);
                ZeraCampos();
                movimentacaobll.inserirCodigo(movimentacao);
                txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
                consulta = null;
                btEXCLUIR.Enabled = false;
            }
            }catch(Exception){
                MessageBox.Show("Ocorreu um erro ao excluir movimentação.");
            }
            
        }

        private void txtCONSULTA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PreencherDataGrid(txtCONSULTA.Text);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            PreencherDataGrid(null);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ClienteBLL clientebll = new ClienteBLL();
            Cliente cliente = new Cliente();
            Movimentacao movimentacao = new Movimentacao();
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();

            btGRAVAR.Enabled = true;
            btEXCLUIR.Enabled = true;

            try
            {
                tabControl1.SelectTab(0);
                consulta = "S";
                cbMARCA.Focus();
                btEXCLUIR.Enabled = true;
                txtCONSULTA.Text = "";

                txtCOD_MOV_VEICULOS.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbMARCA.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cbMODELO.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtVERSAO.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cbANO_FABRICACAO.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cbANO_MODELO.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtCOR.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtPLACA.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtRENAVAM.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtOBSERVACOES.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

                if (Entrada_Saida == "E")
                {
                    txtDATA_ENTRADA.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    txtVALOR_ENTRADA.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    cliente.Nome = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    clientebll.pesquisarCliente(cliente);
                    int codigoDoCliente = Convert.ToInt32(cliente.Cod_Cliente);
                    cliente = clientebll.GetCliente(codigoDoCliente);
                    txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
                    txtNOME.Text = cliente.Nome;
                    txtCPF.Text = cliente.CPF;
                    txtDATA_NASC.Text = cliente.Data_Nasc.ToString();
                    txtRG.Text = cliente.Rg;
                    txtENDERECO.Text = cliente.Endereco;
                    txtBAIRRO.Text = cliente.Bairro;
                    txtCEP.Text = cliente.CEP;
                    txtCIDADE.Text = cliente.Cidade;
                    cbESTADO.Text = cliente.Estado;
                    txtFONE1.Text = cliente.Fone1;
                    txtFONE2.Text = cliente.Fone2;


                }
                else
                {
                    if (!chkBoxFiltro.Checked)
                    {

                        txtVALOR_SAIDA.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                        cliente.Nome = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                        clientebll.pesquisarCliente(cliente);
                        int codigoDoCliente = Convert.ToInt32(cliente.Cod_Cliente);
                        cliente = clientebll.GetCliente(codigoDoCliente);
                        txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
                        txtNOME.Text = cliente.Nome;
                        txtCPF.Text = cliente.CPF;
                        txtDATA_NASC.Text = cliente.Data_Nasc.ToString();
                        txtRG.Text = cliente.Rg;
                        txtENDERECO.Text = cliente.Endereco;
                        txtBAIRRO.Text = cliente.Bairro;
                        txtCEP.Text = cliente.CEP;
                        txtCIDADE.Text = cliente.Cidade;
                        cbESTADO.Text = cliente.Estado;
                        txtFONE1.Text = cliente.Fone1;
                        txtFONE2.Text = cliente.Fone2;
                    }
                }


                if (cliente.Sexo == "M")
                    rbMASCULINO.Checked = true;
                else
                    rbFEMININO.Checked = true;

                if (cliente.Restricao == "S")
                    ckRESTRICAO.Checked = true;
                else
                    ckRESTRICAO.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("A Pesquisa selecionada, não contém Dados!", "Consulta Vazia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ZeraCampos();
                movimentacaobll.inserirCodigo(movimentacao);
                txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
            }
        }

        private void btFECHAR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNOME_CLIENTE_ENTRADA_DoubleClick(object sender, EventArgs e)
        {
            frmClientes frmClientes1 = new frmClientes();
            frmClientes1.ShowDialog();
            txtCOD_CLIENTE.Text = frmClientes1.CodigoCliente;
            txtNOME.Text = frmClientes1.NomeCliente;
        }

        private void txtNOME_CLIENTE_SAIDA_DoubleClick(object sender, EventArgs e)
        {
            frmClientes frmClientes1 = new frmClientes();
            frmClientes1.ShowDialog();
            txtCOD_CLIENTE.Text = frmClientes1.CodigoCliente;
            txtNOME.Text = frmClientes1.NomeCliente;
        }

        private void cbMARCA_SelectedValueChanged(object sender, EventArgs e)
        {
            ModeloBLL modelobll = new ModeloBLL();

            cbMODELO.DataSource = modelobll.retornaModelo(cbMARCA.Text);
            cbMODELO.ValueMember = modelobll.retornaModelo(cbMARCA.Text).Columns[0].ToString();
            cbMODELO.DisplayMember = modelobll.retornaModelo(cbMARCA.Text).Columns[2].ToString();
            cbMODELO.SelectedIndex = -1;
        }

        private void txtVALOR_ENTRADA_KeyDown(object sender, KeyEventArgs e)
        {
            if (((((e.KeyValue >= 96) && (e.KeyValue <= 105)) || ((e.KeyValue >= 48) && (e.KeyValue <= 57))) || ((e.KeyValue == 188) || (e.KeyValue == 8) || (e.KeyValue == 36))) == false)
                SendKeys.Send("{BACKSPACE}");
        }

        private void txtVALOR_SAIDA_KeyDown(object sender, KeyEventArgs e)
        {
            if (((((e.KeyValue >= 96) && (e.KeyValue <= 105)) || ((e.KeyValue >= 48) && (e.KeyValue <= 57))) || ((e.KeyValue == 188) || (e.KeyValue == 8) || (e.KeyValue == 36))) == false)
                SendKeys.Send("{BACKSPACE}");
        }

        private void filtrarDataGrid(string dataInicio, string dataFim)
        {

            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();



            if (Entrada_Saida == "E")
            {
                dataGridView1.DataSource = movimentacaobll.filtrarMovimentacaoEntrada(dataInicio, dataFim);
                dataGridView1.Columns[0].HeaderText = "Cód. Mov.";
                dataGridView1.Columns[1].HeaderText = "Marca";
                dataGridView1.Columns[2].HeaderText = "Modelo";
                dataGridView1.Columns[3].HeaderText = "Versão";
                dataGridView1.Columns[4].HeaderText = "Ano Fab.";
                dataGridView1.Columns[5].HeaderText = "Ano Mod.";
                dataGridView1.Columns[6].HeaderText = "Cor";
                dataGridView1.Columns[7].HeaderText = "Placa";
                dataGridView1.Columns[8].HeaderText = "Renavam";
                dataGridView1.Columns[9].HeaderText = "Observações";
                dataGridView1.Columns[10].HeaderText = "Dt. Entrada";
                //dataGridView1.Columns[11].HeaderText = "Vr. Entrada";
                dataGridView1.Columns[12].HeaderText = "Cliente Entrada";


            }
            else
            {
                if (chkBoxFiltro.Checked)
                {
                    dataGridView1.DataSource = movimentacaobll.filtrarMovimentacaoEntrada(dataInicio, dataFim);
                    dataGridView1.Columns[0].HeaderText = "Cód. Mov.";
                    dataGridView1.Columns[1].HeaderText = "Marca";
                    dataGridView1.Columns[2].HeaderText = "Modelo";
                    dataGridView1.Columns[3].HeaderText = "Versão";
                    dataGridView1.Columns[4].HeaderText = "Ano Fab.";
                    dataGridView1.Columns[5].HeaderText = "Ano Mod.";
                    dataGridView1.Columns[6].HeaderText = "Cor";
                    dataGridView1.Columns[7].HeaderText = "Placa";
                    dataGridView1.Columns[8].HeaderText = "Renavam";
                    dataGridView1.Columns[9].HeaderText = "Observações";
                    dataGridView1.Columns[10].HeaderText = "Dt. Entrada";
                    dataGridView1.Columns[11].HeaderText = "Vr. Entrada";
                    dataGridView1.Columns[12].HeaderText = "Cliente Entrada";
                }
                else
                {

                    dataGridView1.DataSource = movimentacaobll.filtrarMovimentacaoSaida(dataInicio, dataFim);
                    DataTable dataTable = movimentacaobll.filtrarMovimentacaoEntrada(dataInicio, dataFim);
                    dataGridView1.Columns[0].HeaderText = "Cód. Mov.";
                    dataGridView1.Columns[1].HeaderText = "Marca";
                    dataGridView1.Columns[2].HeaderText = "Modelo";
                    dataGridView1.Columns[3].HeaderText = "Versão";
                    dataGridView1.Columns[4].HeaderText = "Ano Fab.";
                    dataGridView1.Columns[5].HeaderText = "Ano Mod.";
                    dataGridView1.Columns[6].HeaderText = "Cor";
                    dataGridView1.Columns[7].HeaderText = "Placa";
                    dataGridView1.Columns[8].HeaderText = "Renavam";
                    dataGridView1.Columns[9].HeaderText = "Observações";
                    dataGridView1.Columns[10].HeaderText = "Dt. Saída";
                    dataGridView1.Columns[11].HeaderText = "Vr. Saída";
                    dataGridView1.Columns[12].HeaderText = "Cliente Saída";
                    dataGridView1.Columns[13].HeaderText = "Dt. Entrada";
                    dataGridView1.Columns[14].HeaderText = "Vr. Entrada";
                    dataGridView1.Columns[15].HeaderText = "Cliente Entrada";

                    //PreencherValorTotal(dataTable);
                }
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Left:

                   dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowSelected].Selected = true;
                   
                    break;

                case MouseButtons.Right:
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowSelected].Selected = true;
                    Point point = new Point(this.Location.X + dataGridView1.Location.X + 15,
                    this.Location.Y + dataGridView1.Location.Y + 30);
                    contextMenuStrip1.Show(point);
                    break;
            }
            rowSelected = e.RowIndex;
            
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtRENAVAM_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCONSULTA_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbValorTotal_Click(object sender, EventArgs e)
        {

        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            string data1 = dtInicio.Value.ToString("dd.MM.yyyy");
            string data2 = dtFim.Value.ToString("dd.MM.yyyy");
            //Console.WriteLine(data1.ToString());
            //Console.WriteLine(data2.ToString());

            filtrarDataGrid(data1, data2);

        }

        private void chkBoxFiltro_CheckedChanged(object sender, EventArgs e)
        {


            if (chkBoxFiltro.Checked)
            {
                String texto = "";
                MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();
                DataTable dataTable = movimentacaobll.consultarMovimentacaoSaida(texto);


                //lbTTvendas.Visible = false;
                //lbValorTotal.Visible = false;
                //lbLucro.Visible = false;
                //lbValorLucro.Visible = false;
                dataGridView1.DataSource = movimentacaobll.consultarMovimentacaoEntrada(texto);
                dataGridView1.Columns[0].HeaderText = "Cód. Mov.";
                dataGridView1.Columns[1].HeaderText = "Marca";
                dataGridView1.Columns[2].HeaderText = "Modelo";
                dataGridView1.Columns[3].HeaderText = "Versão";
                dataGridView1.Columns[4].HeaderText = "Ano Fab.";
                dataGridView1.Columns[5].HeaderText = "Ano Mod.";
                dataGridView1.Columns[6].HeaderText = "Cor";
                dataGridView1.Columns[7].HeaderText = "Placa";
                dataGridView1.Columns[8].HeaderText = "Renavam";
                dataGridView1.Columns[9].HeaderText = "Observações";
                dataGridView1.Columns[10].HeaderText = "Dt. Entrada";
                dataGridView1.Columns[11].HeaderText = "Vr. Entrada";
                dataGridView1.Columns[12].HeaderText = "Cliente Entrada";

                dataGridView1.Refresh();
            }
            else
            {

                PreencherDataGrid("");
            }



        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtCIDADE_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZeraCamposC()
        {
            ClienteBLL clientebll = new ClienteBLL();
            Cliente cliente = new Cliente();

            clientebll.inserirCodigo(cliente);
            txtCOD_CLIENTE.Text = cliente.Cod_Cliente;

            //Limpa todos os campos
            txtCOD_CLIENTE.Clear();
            txtNOME.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtDATA_NASC.Text = DateTime.Now.ToString();
            txtENDERECO.Clear();
            txtBAIRRO.Clear();
            txtCEP.Clear();
            txtCIDADE.Clear();
            txtFONE1.Clear();
            txtFONE2.Clear();
            txtDATA_ENTRADA.Text = DateTime.Now.ToString();
            txtDATA_SAIDA.Text = DateTime.Now.ToString();
            cbESTADO.SelectedIndex = -1;
            rbMASCULINO.Checked = false;
            rbFEMININO.Checked = false;
            ckRESTRICAO.Checked = false;
            txtCOD_CLIENTE.Enabled = false;
            txtNOME.Focus();
            consulta1 = null;
        }

        private void PreencherDataGridC(String NomeCliente)
        {
            ClienteBLL clientebll = new ClienteBLL();
            dataGridView1.DataSource = clientebll.consultarCliente(NomeCliente);

            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "CPF";
            dataGridView1.Columns[3].HeaderText = "Data Nasc.";
            dataGridView1.Columns[4].HeaderText = "Endereço";
            dataGridView1.Columns[5].HeaderText = "Bairro";
            dataGridView1.Columns[6].HeaderText = "CEP";
            dataGridView1.Columns[7].HeaderText = "Cidade";
            dataGridView1.Columns[8].HeaderText = "Estado";
            dataGridView1.Columns[9].HeaderText = "Fone 1";
            dataGridView1.Columns[10].HeaderText = "Fone 2";
            dataGridView1.Columns[11].HeaderText = "Sexo";
            dataGridView1.Columns[12].HeaderText = "Restrição";
            dataGridView1.Columns[13].HeaderText = "Rg";
        }

        private void btFECHAR_ClickC(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ZeraCamposC();

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        //gravar cliente
        private String cadastrarCliente()
        {
            Cliente cliente = new Cliente();
            ClienteBLL clientebll = new ClienteBLL();
            string codClienteInsert = "";

            try
            {
                cliente.Cod_Cliente = txtCOD_CLIENTE.Text;
                cliente.Nome = txtNOME.Text;
                cliente.CPF = txtCPF.Text;
                cliente.Rg = txtRG.Text;
                cliente.Data_Nasc = txtDATA_NASC.Text;
                cliente.Endereco = txtENDERECO.Text;
                cliente.Bairro = txtBAIRRO.Text;
                cliente.CEP = txtCEP.Text;
                cliente.Cidade = txtCIDADE.Text;
                cliente.Fone1 = txtFONE1.Text;
                cliente.Fone2 = txtFONE2.Text;
                cliente.Estado = cbESTADO.Text;


                string[] dtNascimento = cliente.Data_Nasc.Split('/');
                cliente.Data_Nasc = dtNascimento[0] + "." + dtNascimento[1] + "." + dtNascimento[2];



                if (rbMASCULINO.Checked)
                    cliente.Sexo = "M";
                else
                    cliente.Sexo = "F";

                if (ckRESTRICAO.Checked)
                    cliente.Restricao = "S";
                else
                    cliente.Restricao = "N";

                clientebll.verificarCampos(cliente);

                Cliente clienteBusca = clientebll.GetCliente(Convert.ToInt32(cliente.Cod_Cliente));

                if (clienteBusca == null)
                {
                    clientebll.inserirCliente(cliente);
                    codClienteInsert = cliente.Cod_Cliente;
                    MessageBox.Show("O cliente " + cliente.Nome + " foi cadastrado!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ZeraCamposC();
                    clientebll.inserirCodigo(cliente);
                    txtCOD_CLIENTE.Text = cliente.Cod_Cliente;

                }
                else
                {
                    clientebll.atulizarCliente(cliente);
                    codClienteInsert = cliente.Cod_Cliente;
                    //MessageBox.Show("A atualização do usuário: " + cliente.Nome + " foi feita com Sucesso!", "Atualização Efetuada com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ZeraCamposC();
                    clientebll.inserirCodigo(cliente);
                    txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
                    consulta1 = null;
                }

                return codClienteInsert;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo cliente" + ex.Message);
            }
            return null;
        }

        private void tabPage2_EnterC(object sender, EventArgs e)
        {
            PreencherDataGridC(null);
        }

        private void txtCONSULTA_KeyDownC(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                PreencherDataGridC(txtCONSULTA.Text);

        }

        private void dataGridView1_DoubleClickC(object sender, EventArgs e)
        {

        }

        //Excluir cliente
        private void Excluir_Cliente(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBLL clientebll = new ClienteBLL();

            try{
            cliente.Cod_Cliente = txtCOD_CLIENTE.Text;
            cliente.Nome = txtNOME.Text;

            if (MessageBox.Show("Deseja EXCLUIR o usuário " + cliente.Nome + "?", "Excluir Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clientebll.excluirCliente(cliente);
                ZeraCamposC();
                clientebll.inserirCodigo(cliente);
                txtCOD_CLIENTE.Text = cliente.Cod_Cliente;
                consulta1 = null;
            }
            }catch(Exception){
                MessageBox.Show("Ocorreu um erro ao excluir um cliente.");
            }
            
        }

        private void txtDATA_NASC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void preencherDataGrid_clientes()
        {
            ClienteBLL clientebll = new ClienteBLL();
            dataGridViewCliente.DataSource = clientebll.consultarCliente(NomeCliente);

            dataGridViewCliente.Columns[0].HeaderText = "Código";
            dataGridViewCliente.Columns[1].HeaderText = "Nome";
            dataGridViewCliente.Columns[2].HeaderText = "CPF";
            dataGridViewCliente.Columns[3].HeaderText = "Data Nasc.";
            dataGridViewCliente.Columns[4].HeaderText = "Endereço";
            dataGridViewCliente.Columns[5].HeaderText = "Bairro";
            dataGridViewCliente.Columns[6].HeaderText = "CEP";
            dataGridViewCliente.Columns[7].HeaderText = "Cidade";
            dataGridViewCliente.Columns[8].HeaderText = "Estado";
            dataGridViewCliente.Columns[9].HeaderText = "Fone 1";
            dataGridViewCliente.Columns[10].HeaderText = "Fone 2";
            dataGridViewCliente.Columns[11].HeaderText = "Sexo";
            dataGridViewCliente.Columns[12].HeaderText = "Restrição";

            dataGridViewCliente.Columns[0].Visible = false;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btLimparCampos_Click(object sender, EventArgs e)
        {
            ZeraCampos();
            ZeraCamposClientes();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            preencherDataGrid_clientes();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            preencherDataGrid_clientes();
        }

        private void btLimpaFiltro_Click(object sender, EventArgs e)
        {
            PreencherDataGrid(null);
        }


        private void edtCpfConsultaCliente_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ClienteBLL clientebll = new ClienteBLL();
                dataGridViewCliente.DataSource = clientebll.consultarCliente(edtCpfConsultaCliente.Text);

                dataGridViewCliente.Columns[0].HeaderText = "Código";
                dataGridViewCliente.Columns[1].HeaderText = "Nome";
                dataGridViewCliente.Columns[2].HeaderText = "CPF";
                dataGridViewCliente.Columns[3].HeaderText = "Data Nasc.";
                dataGridViewCliente.Columns[4].HeaderText = "Endereço";
                dataGridViewCliente.Columns[5].HeaderText = "Bairro";
                dataGridViewCliente.Columns[6].HeaderText = "CEP";
                dataGridViewCliente.Columns[7].HeaderText = "Cidade";
                dataGridViewCliente.Columns[8].HeaderText = "Estado";
                dataGridViewCliente.Columns[9].HeaderText = "Fone 1";
                dataGridViewCliente.Columns[10].HeaderText = "Fone 2";
                dataGridViewCliente.Columns[11].HeaderText = "Sexo";
                dataGridViewCliente.Columns[12].HeaderText = "Restrição";
            }
        }

        private void edtCpfConsultaCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            try
            {

                txtCOD_CLIENTE.Text = dataGridViewCliente.CurrentRow.Cells[0].Value.ToString();
                txtNOME.Text = dataGridViewCliente.CurrentRow.Cells[1].Value.ToString();
                txtCPF.Text = dataGridViewCliente.CurrentRow.Cells[2].Value.ToString();
                txtRG.Text = dataGridViewCliente.CurrentRow.Cells[13].Value.ToString();
                txtDATA_NASC.Text = dataGridViewCliente.CurrentRow.Cells[3].Value.ToString();
                txtENDERECO.Text = dataGridViewCliente.CurrentRow.Cells[4].Value.ToString();
                txtBAIRRO.Text = dataGridViewCliente.CurrentRow.Cells[5].Value.ToString();
                txtCEP.Text = dataGridViewCliente.CurrentRow.Cells[6].Value.ToString();
                txtCIDADE.Text = dataGridViewCliente.CurrentRow.Cells[7].Value.ToString();
                cbESTADO.Text = dataGridViewCliente.CurrentRow.Cells[8].Value.ToString();
                txtFONE1.Text = dataGridViewCliente.CurrentRow.Cells[9].Value.ToString();
                txtFONE2.Text = dataGridViewCliente.CurrentRow.Cells[10].Value.ToString();
                cliente.Sexo = dataGridViewCliente.CurrentRow.Cells[11].Value.ToString();
                cliente.Restricao = dataGridViewCliente.CurrentRow.Cells[12].Value.ToString();


                if (cliente.Sexo == "M")
                    rbMASCULINO.Checked = true;
                else
                    rbFEMININO.Checked = true;

                if (cliente.Restricao == "S")
                    ckRESTRICAO.Checked = true;
                else
                    ckRESTRICAO.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("A Pesquisa selecionada, não contém Dados!", "Consulta Vazia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            tabControl1.SelectTab(0);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                switch (MouseButtons)
                {
                    case MouseButtons.Left:

                        break;

                    case MouseButtons.Right:
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[rowSelected].Selected = true;
                        Point point = new Point(this.Location.X + dataGridView1.Location.X + e.X + 15,
                        this.Location.Y + dataGridView1.Location.Y + e.Y + 30);
                        contextMenuStrip1.Show(point);
                        break;
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList row = new ArrayList();
            int flag = 0;
            //1 para entrada
            //2 para saida

            if (dataGridView1[1, rowSelected].Value != null)
            {

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {

                    row.Add(dataGridView1[i, rowSelected].Value.ToString());
                }


                if (Entrada_Saida == "E")
                {
                    flag = 1;
                }
                else
                {
                    if (chkBoxFiltro.Checked)
                        flag = 1;
                    else

                        flag = 2;
                }

                frmVisualizar frmVisualizar = new frmVisualizar(row, flag);
                frmVisualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há itens a serem visualizados !");
            }

            
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void Cliente_consulta(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MovimentacaoBLL movimentacaoBLL = new MovimentacaoBLL();
                //movimentacaoBLL.filtrarNomeSaida(clienteConsulta.Text);
                dataGridView1.Columns[0].HeaderText = "Cód. Mov.";
                dataGridView1.Columns[1].HeaderText = "Marca";
                dataGridView1.Columns[2].HeaderText = "Modelo";
                dataGridView1.Columns[3].HeaderText = "Versão";
                dataGridView1.Columns[4].HeaderText = "Ano Fab.";
                dataGridView1.Columns[5].HeaderText = "Ano Mod.";
                dataGridView1.Columns[6].HeaderText = "Cor";
                dataGridView1.Columns[7].HeaderText = "Placa";
                dataGridView1.Columns[8].HeaderText = "Renavam";
                dataGridView1.Columns[9].HeaderText = "Observações";
                dataGridView1.Columns[10].HeaderText = "Dt. Entrada";
                //dataGridView1.Columns[11].HeaderText = "Vr. Entrada";
                dataGridView1.Columns[12].HeaderText = "Cliente Entrada";
            }
        }

        private void txtPLACA_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = null;
            MovimentacaoBLL movimentacaobll = new MovimentacaoBLL();

            if (Entrada_Saida == "E")
            { 
                dt = movimentacaobll.consultarMovimentacaoApenasEntrada(null);
            }
            else
            {
                dt = movimentacaobll.consultarMovimentacaoSaida(null);
            }



            frmImprimirMovimentacao frmImprimir = new frmImprimirMovimentacao(dt);
            frmImprimir.ShowDialog();
        }
    }
}
