using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class MovimentacaoBLL
    {
        MovimentacaoDAL movDal = new MovimentacaoDAL();
        public bool verificarCampos(Movimentacao movimentacao)
        {
            if (movimentacao.Cod_Marca.Trim().Length == 0)
            {    
                throw new Exception("É obrigatório o preenchimento do campo Marca!");                 
            }

            if (movimentacao.Cod_Modelo.Trim().Length == 0) 
            {
                throw new Exception("É obrigatório o preenchimento do campo Modelo!");
            }

            if (movimentacao.Versao.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Versão!");
            }

            if (movimentacao.Ano_Fabricacao.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Ano Fabricação!");
            }

            if (movimentacao.Ano_Modelo.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Ano Modelo!");
            }

            if (movimentacao.Cor.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Cor!");
            }

            if (movimentacao.Placa.Trim().Length == 0 || movimentacao.Placa == null || movimentacao.Placa.Length < 7 || movimentacao.Placa.Length > 8)
            {
                throw new Exception("Verifique o preenchimento do campo Placa!");
            }

            if (movimentacao.Renavam.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo CPF!");
            }

            if (!verificaPlacaUnica(movimentacao.Placa))
            {
                if (MessageBox.Show("Deseja prosseguir para atualizar ?", "Veículo já existe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    throw new Exception("Já existe um veículo com esta Placa");
                }
            }

            
            return true;
        }

        public Boolean verificaPlacaUnica(string placa)
        {
            DataTable dt = movDal.ConsultarMovimentacaoEntrada(null);

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



        public bool verificarCamposCompra(Movimentacao movimentacao)
        {
            if (movimentacao.Valor_Entrada.ToString().Trim().Length == 0)
            {
                movimentacao.Valor_Entrada = "0";
                //throw new Exception("É obrigatório o preenchimento do campo Valor de Entrada!");
            }

            if (movimentacao.Cod_Cliente_Entrada.Trim().Length == 0)
            {
                
                throw new Exception("É obrigatório o preenchimento do campo Cliente Entrada!");
            }

            try
            {
                Convert.ToString(Convert.ToDateTime(movimentacao.Data_Entrada));               
            }
            catch
            {
                throw new Exception("Preencha o campo Data Entrada Corretamente!");
            }

            return true;
        }



        public void inserirCodigo(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.InserirCodigo(movimentacao);
        }

        public void inserirMovimentacaoEntrada(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.InserirMovimentacaoEntrada(movimentacao);
        }

        public void inserirMovimentacaoSaida(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.InserirMovimentacaoSaida(movimentacao);
        } 

        public void atulizarMovimentacaoEntrada(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.AtualizarMovimentacaoEntrada(movimentacao);
        }

        public void atulizarMovimentacaoSaida(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.AtualizarMovimentacaoSaida(movimentacao);
        }

        public void excluirMovimentacao(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.ExcluirMovimentacao(movimentacao);
        }
        public DataTable consultarMovimentacaoEntrada(string texto)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            return movimentacaodal.ConsultarMovimentacaoEntrada(texto);
        }
        public DataTable consultarMovimentacaoApenasEntrada(String TEXTO)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            return movimentacaodal.ConsultarMovimentacaoApenasEntrada(TEXTO); 
        }

        public DataTable consultarMovimentacaoSaida(String TEXTO)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            return movimentacaodal.ConsultarMovimentacaoSaida(TEXTO);
        }
        public DataTable filtrarMovimentacaoSaida(string dataInicio, string dataFim)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            return movimentacaodal.filtrarMovimentacaoSaida(dataInicio, dataFim);
        }
        public DataTable filtrarMovimentacaoEntrada(string dataInicio, string dataFim)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            return movimentacaodal.filtrarMovimentacaoEntrada(dataInicio, dataFim);
        }
        public DataTable cunsultarTodaMovimentacao()
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            return movimentacaodal.consultarTodaMovimentacao();
        }

        public DataTable filtrarNomeSaida(string nome){
             MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            return movimentacaodal.filtrarNomeSaida(nome);
        }
    }
}
