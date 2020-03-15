using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class CaixaBLL
    {
        public void abrirCaixa(Caixa caixa, Lancamentos lancamentos)
        {
            CaixaDAL caixadal = new CaixaDAL();
            caixadal.novoCaixa(caixa);
            DataTable dt = caixadal.recuperarUltimoCaixa();
            lancamentos.Caixa = Int32.Parse(dt.Rows[0]["ID"].ToString());
            caixadal.inserirLancamento(lancamentos);
        }
        public void inserirLancamentos(Lancamentos lancamentos)
        {
            CaixaDAL caixadal = new CaixaDAL();
            caixadal.inserirLancamento(lancamentos);
        }

        public void fecharCaixa(Lancamentos lancamentos)
        {
            CaixaDAL caixadal = new CaixaDAL();
            //caixadal.inserirLancamento(lancamentos);
            caixadal.fechamentoCaixa(lancamentos.Caixa);
        }

        public DataTable recuperarCaixaAtual()
        {
            CaixaDAL caixadal = new CaixaDAL();
            return caixadal.recuperarCaixaAtual();
        }

        public DataTable consultaLancamentos(int id_caixa)
        {
            CaixaDAL caixadal = new CaixaDAL();
            return caixadal.consultarLancamentos(id_caixa);
        }

        public DataTable consultaLancamentos(string tipo, string dtInicio, string dtFim, string placa, string simb)
        {
            CaixaDAL caixadal = new CaixaDAL();
            return caixadal.consultarLancamentos(tipo, dtInicio, dtFim, placa, simb);
        }
        public DataTable consultarTodosOsCaixas()
        {
            CaixaDAL caixa = new CaixaDAL();
            return caixa.consultarTodosOsCaixas();
        }

        public DataTable consultarCaixaPorData(string data)
        {
            CaixaDAL caixadal = new CaixaDAL();
            return caixadal.consultarCaixaPorData(data);
        }
        public DataTable recuperarUltimoCaixa()
        {
            CaixaDAL caixadal = new CaixaDAL();
            return caixadal.recuperarUltimoCaixa();
        }

        public void reabrirCaixa(int id)
        {
            CaixaDAL caixadal = new CaixaDAL();
            caixadal.reabrirCaixa(id);
        }
    }
}
