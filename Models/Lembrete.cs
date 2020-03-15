using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Lembrete
    {
        private string id = "NULL";
        private string descricao;
        private DateTime data;
        private int status;

        public Lembrete()
        {
        }

        public Lembrete(string descricao, DateTime data, int status)
        {
            this.descricao = descricao;
            this.data = data;
            this.status = status;
        }

      

        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Status { get => status; set => status = value; }
        public string Id { get => id; set => id = value; }
    }
}
