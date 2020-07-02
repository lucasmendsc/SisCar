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
using Microsoft.ReportingServices.Diagnostics.Internal;

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
            Movimentacao movimentacao = new Movimentacao();

            MovimentacaoBLL.getInstance().inserirCodigo(movimentacao);
            txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
            btEXCLUIR.Enabled = false;
            cbMARCA.Focus();

            ClienteBLL clientebll = new ClienteBLL();
            Cliente cliente = new Cliente();

            txtCOD_CLIENTE.Text = clientebll.inserirCodigo().ToString();
            btEXCLUIR.Enabled = false;
            txtCOD_CLIENTE.Enabled = false;


        }

        private void ZeraCampos()
        {
            Movimentacao movimentacao = new Movimentacao();

            MovimentacaoBLL.getInstance().inserirCodigo(movimentacao);
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
            btEXCLUIR.Enabled = false;
            consulta = null;
        }

        //aqui verifico se estou na tela de entrada ou tela de saida
       

        private void PreencherDataGrid(DataTable dt, String Texto)
        {
                if (Entrada_Saida == "E")
                {
                    if (dt == null) {
                        DataTable apenasEntrada = MovimentacaoBLL.getInstance().consultarMovimentacaoApenasEntrada(Texto);
                        dataGridView1.DataSource = apenasEntrada;

                        preencheLabelQuantidade(apenasEntrada);
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                        preencheLabelQuantidade(dt);
                    }

                    dataGridView1.Columns[10].HeaderText = "Dt. Entrada";
                    // dataGridView1.Columns[11].HeaderText = "Vr. Entrada";
                    dataGridView1.Columns[12].HeaderText = "Cliente Entrada";

                    dataGridView1.Columns[11].Visible = false;

                    

                }
                else
                {
                if (chkBoxFiltro.Checked)
                {
                    dataGridView1.DataSource = dt;
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

                    preencheLabelQuantidade(dt);

                    dataGridView1.Refresh();

                }
                else
                {

                    if (dt == null)
                    {
                        DataTable saidas = MovimentacaoBLL.getInstance().consultarMovimentacaoSaida(Texto);
                        dataGridView1.DataSource = saidas;
                        preencheLabelQuantidade(saidas);
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                        preencheLabelQuantidade(dt);
                    }

                    dataGridView1.Columns[10].HeaderText = "Dt. Entrada";
                    dataGridView1.Columns[12].HeaderText = "Cliente Entrada";
                    dataGridView1.Columns[13].HeaderText = "Dt. Saída";
                    dataGridView1.Columns[15].HeaderText = "Cliente Saída";

                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[14].Visible = false;

                }

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

            //if (e.KeyCode == Keys.Enter)
                //SendKeys.Send("{TAB}");
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
                PreencherDataGrid(null,null);
                
            }

            cbMARCA.DataSource = marcabll.retornaMarca();
            cbMARCA.DisplayMember = marcabll.retornaMarca().Columns[1].ToString();
            cbMARCA.ValueMember = marcabll.retornaMarca().Columns[0].ToString();
            cbMARCA.SelectedIndex = -1;
        }

        private string converterData(string data)
        {
            return data.Replace('/','.');
        }

        private void btGRAVAR_Click(object sender, EventArgs e)
        {

            string codCliente = cadastrarCliente();
            Movimentacao movimentacao = new Movimentacao();
            

            try
            {
                movimentacao.Cod_Mov_Veiculos = txtCOD_MOV_VEICULOS.Text;
                movimentacao.Cod_Marca = Convert.ToString(cbMARCA.SelectedValue);
                movimentacao.Cod_Modelo = Convert.ToString(cbMODELO.SelectedValue);
                movimentacao.Versao = (txtVERSAO.Text).Replace(',',' ');
                movimentacao.Ano_Fabricacao = cbANO_FABRICACAO.Text;
                movimentacao.Ano_Modelo = cbANO_MODELO.Text;
                movimentacao.Cor = txtCOR.Text;
                movimentacao.Placa = (txtPLACA.Text).Replace(' ','0');
                movimentacao.Renavam = txtRENAVAM.Text;
                movimentacao.Observacoes = (txtOBSERVACOES.Text).Replace(',','.');

                MovimentacaoBLL.getInstance().verificarCampos(movimentacao);


                if (Entrada_Saida == "E" && codCliente != null)
                {
                    if (!verificaPlacaUnica(movimentacao.Placa))
                    {
                        if (MessageBox.Show("Deseja prosseguir para atualizar ?", "Veículo já existe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            throw new Exception("Já existe um veículo com esta Placa");
                        }
                    }

                    movimentacao.Valor_Entrada = "0";
                    movimentacao.Data_Entrada = converterData(txtDATA_ENTRADA.Text);
                    movimentacao.Cod_Cliente_Entrada = codCliente;
                    MovimentacaoBLL.getInstance().verificarCamposCompra(movimentacao);
                }
                else
                {
                    movimentacao.Valor_Saida = "0";
                    movimentacao.Data_Saida = converterData(txtDATA_SAIDA.Text);
                    movimentacao.Cod_Cliente_Saida = codCliente;
                    
                }

                if (consulta == null && Entrada_Saida == "E")
                {
                    MovimentacaoBLL.getInstance().inserirMovimentacaoEntrada(movimentacao);
                    MessageBox.Show("A movimentação foi inserida com Sucesso!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (consulta == null && Entrada_Saida == "S")
                {
                    MovimentacaoBLL.getInstance().inserirMovimentacaoSaida(movimentacao);
                    MessageBox.Show("A saida foi inserida com Sucesso!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (consulta != null && Entrada_Saida == "E")
                {
                    MovimentacaoBLL.getInstance().atulizarMovimentacaoEntrada(movimentacao);
                    MessageBox.Show("A atualização da movimentação foi efetuado com Sucesso!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (consulta != null && Entrada_Saida == "S")
                {
                    MessageBox.Show(MovimentacaoBLL.getInstance().inserirMovimentacaoSaida(movimentacao),"Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    //movimentacaobll.atulizarMovimentacaoSaida(movimentacao);
                    //MessageBox.Show("A saida foi efetuado com Sucesso!", "Atualização Efetuada com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    consulta = null;
                }

                ZeraCampos();
                ZeraCamposClientes();
                MovimentacaoBLL.getInstance().inserirCodigo(movimentacao);
                txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir entrada/saida: "+ ex.Message);
            }

            MovimentacaoBLL.getInstance().inserirCodigo(movimentacao);
            txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
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

        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            try{
                Movimentacao movimentacao = new Movimentacao();

                movimentacao.Cod_Mov_Veiculos = txtCOD_MOV_VEICULOS.Text;

            if(MessageBox.Show("Deseja EXCLUIR o cliente da Movimentação?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    Cliente cliente = new Cliente();
                    cliente.Cod_Cliente = txtCOD_CLIENTE.Text;
                    ClienteBLL clienteBLL = new ClienteBLL();
                    clienteBLL.excluirCliente(cliente);
                    ZeraCamposClientes();

                    MessageBox.Show("Cliente removido com sucesso !");

            }
            if (MessageBox.Show("Deseja EXCLUIR essa Movimentação?", "Excluir Movimentação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MovimentacaoBLL.getInstance().excluirMovimentacao(movimentacao);
                ZeraCampos();
                MovimentacaoBLL.getInstance().inserirCodigo(movimentacao);
                txtCOD_MOV_VEICULOS.Text = movimentacao.Cod_Mov_Veiculos;
                consulta = null;
                btEXCLUIR.Enabled = false;
            }

            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            PreencherDataGrid(null,null);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ClienteBLL clientebll = new ClienteBLL();
            Cliente cliente = new Cliente();
            Movimentacao movimentacao = new Movimentacao();

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
                MovimentacaoBLL.getInstance().inserirCodigo(movimentacao);
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

            if (Entrada_Saida == "E")
            {
                DataTable entradas = MovimentacaoBLL.getInstance().filtrarMovimentacaoEntrada(dataInicio, dataFim);
                dataGridView1.DataSource = entradas;
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

                preencheLabelQuantidade(entradas);

            }
            else
            {
                if (chkBoxFiltro.Checked)
                {
                    DataTable entradas = MovimentacaoBLL.getInstance().filtrarMovimentacaoEntrada(dataInicio, dataFim);
                    dataGridView1.DataSource = entradas;
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

                    preencheLabelQuantidade(entradas);
                }
                else
                {
                    DataTable saidas = MovimentacaoBLL.getInstance().filtrarMovimentacaoSaida(dataInicio, dataFim);
                    dataGridView1.DataSource = saidas;
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
                    preencheLabelQuantidade(saidas);
                }
            }



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
                DataTable entradas = MovimentacaoBLL.getInstance().consultarMovimentacaoEntrada(texto);
                PreencherDataGrid(entradas, texto);
            }
            else
            {
                PreencherDataGrid(null,"");
            }

        }


        private void ZeraCamposC()
        {
 
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
            DataTable clientes = clientebll.consultarCliente(NomeCliente);
            dataGridView1.DataSource = clientes;
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

            preencheLabelQuantidade(clientes);
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
                cliente.Data_Nasc = (txtDATA_NASC.Text).Replace('/','.');
                cliente.Endereco = retirarVirgula(txtENDERECO.Text);
                cliente.Bairro = retirarVirgula(txtBAIRRO.Text);
                cliente.CEP = txtCEP.Text;
                cliente.Cidade = txtCIDADE.Text;
                cliente.Fone1 = txtFONE1.Text;
                cliente.Fone2 = txtFONE2.Text;
                cliente.Estado = cbESTADO.Text;

                if (rbMASCULINO.Checked)
                    cliente.Sexo = "M";
                else
                    cliente.Sexo = "F";

                if (ckRESTRICAO.Checked)
                    cliente.Restricao = "S";
                else
                    cliente.Restricao = "N";

                clientebll.verificarCampos(cliente);

                Cliente clienteBusca = clientebll.consultarClienteCpf(cliente.CPF);

                if (clienteBusca == null)
                {
                    clientebll.inserirCliente(cliente);
                    codClienteInsert = clientebll.inserirCodigo().ToString();
                    txtCOD_CLIENTE.Text = codClienteInsert;
                    MessageBox.Show("O cliente " + cliente.Nome + " foi cadastrado!", "Cadastro Efetuado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    cliente.Cod_Cliente = clienteBusca.Cod_Cliente;
                    clientebll.atulizarCliente(cliente);
                    codClienteInsert = clienteBusca.Cod_Cliente;
                    txtCOD_CLIENTE.Text = clienteBusca.Cod_Cliente;
                    MessageBox.Show("O cliente : " + cliente.Nome + " foi atualizado com Sucesso!", "Atualização Efetuada com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    consulta1 = null;
                }

                return codClienteInsert;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir cliente: " + ex.Message);
            }
            return null;
        }

        private string retirarVirgula(string str)
        {
            return str.Replace(',',' ');
        }


        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void preencherDataGrid_clientes()
        {
            ClienteBLL clientebll = new ClienteBLL();
            DataTable clientes = clientebll.consultarCliente(NomeCliente);
            dataGridViewCliente.DataSource = clientes;

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

            preencheLabelQuantidade(clientes);
        }


        private void btLimparCampos_Click(object sender, EventArgs e)
        {
            ZeraCampos();
            ZeraCamposClientes();
        }

        private void btLimpaFiltro_Click(object sender, EventArgs e)
        {
            PreencherDataGrid(null,null);
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

       


        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = null;

            if (Entrada_Saida == "E")
            { 
                dt = MovimentacaoBLL.getInstance().consultarMovimentacaoApenasEntrada(null);
            }
            else
            {
                dt = MovimentacaoBLL.getInstance().consultarMovimentacaoSaida(null);
            }



            frmImprimirMovimentacao frmImprimir = new frmImprimirMovimentacao(dt);
            frmImprimir.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!chkBoxFiltro.Enabled)
            {
                PreencherDataGrid(null,null);
            }
                
        }

        private void preencheLabelQuantidade(DataTable dt)
        {
            lbQuant.Text = (dt.Rows.Count).ToString();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            preencherDataGrid_clientes();
        }


        public Boolean verificaPlacaUnica(string placa)
        {
            DataTable dt = MovimentacaoDAL.getInstance().ConsultarMovimentacaoEntrada(null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (placa.Equals(dr["placa"].ToString()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        private void txtOBSERVACOES_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string temp = txtOBSERVACOES.Text;
                txtOBSERVACOES.Clear();
                txtOBSERVACOES.Text = temp+"\n";
                txtOBSERVACOES.Focus();
            }
        }

        private void txtCONSULTA_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtCONSULTA.Text == " ")
                {
                    PreencherDataGrid(null, null);
                }
                else
                {
                    string placa = txtCONSULTA.Text.ToUpper();
                    if (Entrada_Saida == "E" || chkBoxFiltro.Checked)
                    {
                        
                        PreencherDataGrid(MovimentacaoBLL.getInstance().consultarMovimentacaoEntrada(placa), null);
                        txtCONSULTA.Clear();
                    }
                    else
                    {
                        PreencherDataGrid(MovimentacaoBLL.getInstance().consultarMovimentacaoSaida(placa), null);
                        txtCONSULTA.Clear();
                    }
                }
            }

            if(e.KeyCode == Keys.Tab)
            {
                clienteConsulta.Focus();
            }
        }

        //consultar por nome
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (Entrada_Saida == "E" || chkBoxFiltro.Checked)
                {
                    try
                    {
                        PreencherDataGrid(MovimentacaoBLL.getInstance().filtrarNomeEntrada(clienteConsulta.Text), null);
                        clienteConsulta.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (dataGridView1.DataSource != null)
                    {
                        try
                        {
                            PreencherDataGrid(MovimentacaoBLL.getInstance().filtrarNomeSaida(clienteConsulta.Text), null);
                            clienteConsulta.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Tab)
            {
                txtModelo.Focus();
            }
        }

        private void txtModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (Entrada_Saida == "E" || chkBoxFiltro.Checked)
                    {
                    
                        PreencherDataGrid(MovimentacaoBLL.getInstance().filtrarModeloEntrada(txtModelo.Text),null);
                        txtModelo.Clear();
                    }
                    else
                    {
                        PreencherDataGrid(MovimentacaoBLL.getInstance().filtrarModeloSaida(txtModelo.Text), null);
                        txtModelo.Clear();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(e.KeyCode == Keys.Tab)
            {
                btFiltrar.Focus();
            }
        }
    }

}
