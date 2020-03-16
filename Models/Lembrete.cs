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
        private string data;
        private string status;

        public Lembrete()
        {
        }

        public Lembrete(string descricao, string data, string status)
        {
            this.descricao = descricao;
            this.data = data;
            this.status = status;
        }

      

        public string Descricao { get => descricao; set => descricao = value; }
        public string Data { get => data; set => data = value; }
        public string Status { get => status; set => status = value; }
        public string Id { get => id; set => id = value; }
    }
}
