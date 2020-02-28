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
        public void abrirCaixa(Caixa caixa)
        {
            CaixaDAL caixadal = new CaixaDAL();
            caixadal.novoCaixa(caixa);
        }
        public void inserirLancamentos(Lancamentos lancamentos)
        {
            CaixaDAL caixadal = new CaixaDAL();
            caixadal.inserirLancamento(lancamentos);
        }

        public void fecharCaixa(Lancamentos lancamentos)
        {
            CaixaDAL caixadal = new CaixaDAL();
            caixadal.inserirLancamento(lancamentos);
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

        public DataTable consultaLancamentos()
        {
            CaixaDAL caixadal = new CaixaDAL();
            return caixadal.consultarLancamentos();
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
