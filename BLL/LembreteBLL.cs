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
    public class LembreteBLL
    {
        private static LembreteBLL mySelf;

        private LembreteBLL()
        {

        }

        public static LembreteBLL getInstance()
        {
            if (mySelf == null)
                mySelf = new LembreteBLL();
            return mySelf;
        }

        public void inserirLembrete(Lembrete lembrete)
        {
            LembreteDAL.getInstance().InserirLembrete(lembrete);
        }

        public void excluirLmebrete(Lembrete lembrete)
        {
            LembreteDAL.getInstance().ExcluirLembrete(lembrete);
        }

        public DataTable consultarTodosLembretes(string desricao)
        {
            return LembreteDAL.getInstance().ConsultarLembretes(desricao);
        }

        public DataTable consultarLembretePorId(int id)
        {
            return LembreteDAL.getInstance().RetornaLembretePorId(id);
        }

        public void atualizarLembrete(Lembrete lembrete)
        {
            LembreteDAL.getInstance().atualiizarLembrete(lembrete);
        }
    }
}
