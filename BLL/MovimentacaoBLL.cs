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

      private static MovimentacaoBLL mySelf;

      private MovimentacaoBLL()
        {

        }

        public static MovimentacaoBLL getInstance()
        {
            if (mySelf == null)
                mySelf = new MovimentacaoBLL();
            return mySelf;
        }

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
            MovimentacaoDAL.getInstance().InserirCodigo(movimentacao);
        }

        public void inserirMovimentacaoEntrada(Movimentacao movimentacao)
        {
            MovimentacaoDAL.getInstance().InserirMovimentacaoEntrada(movimentacao);
        }

        public string inserirMovimentacaoSaida(Movimentacao movimentacao)
        {

            if (consultarMovimentacaoSaida(movimentacao.Placa) == null)
            {

                MovimentacaoDAL.getInstance().InserirMovimentacaoSaida(movimentacao);
                return "Movimentação inserida com sucesso !";
            }
            else
            {
                MovimentacaoDAL.getInstance().AtualizarMovimentacaoSaida(movimentacao);
                return "Movimentação atualizada com secesso !";
            }
        } 

        public void atulizarMovimentacaoEntrada(Movimentacao movimentacao)
        {
            MovimentacaoDAL.getInstance().AtualizarMovimentacaoEntrada(movimentacao);
        }

        public void excluirMovimentacao(Movimentacao movimentacao)
        {
            MovimentacaoDAL.getInstance().ExcluirMovimentacao(movimentacao);
        }
        public DataTable consultarMovimentacaoEntrada(string texto)
        {
            return MovimentacaoDAL.getInstance().ConsultarMovimentacaoEntrada(texto);
        }
        public DataTable consultarMovimentacaoApenasEntrada(String TEXTO)
        {
            return MovimentacaoDAL.getInstance().ConsultarMovimentacaoApenasEntrada(TEXTO); 
        }

        public DataTable consultarMovimentacaoSaida(String TEXTO)
        {
            return MovimentacaoDAL.getInstance().filtrarMovimentacaoSaidaPlaca(TEXTO);
        }
        public DataTable filtrarMovimentacaoSaida(string dataInicio, string dataFim)
        {
            return MovimentacaoDAL.getInstance().filtrarMovimentacaoSaida(dataInicio, dataFim);
        }
       
        public DataTable filtrarMovimentacaoEntrada(string dataInicio, string dataFim)
        {
            return MovimentacaoDAL.getInstance().filtrarMovimentacaoEntrada(dataInicio, dataFim);
        }
        public DataTable cunsultarTodaMovimentacao()
        {
            return MovimentacaoDAL.getInstance().consultarTodaMovimentacao();
        }

        public DataTable filtrarNomeSaida(string nome){
            return MovimentacaoDAL.getInstance().filtrarNomeSaida(nome);
        }

        public DataTable filtrarNomeEntrada(string nome)
        {
            return MovimentacaoDAL.getInstance().filtrarNomeEntrada(nome);
        }

        public DataTable filtrarModeloEntrada(string nome)
        {
            return MovimentacaoDAL.getInstance().filtrarModeloEntrada(nome);
        }

        public DataTable filtrarModeloSaida(string nome)
        {
            return MovimentacaoDAL.getInstance().filtrarModeloSaida(nome);
        }
    }
}
