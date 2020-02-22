using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Gastos
    {
        private String id = "NULL";
        private String descricao;
        private String responsavel;
        private string data;
        private float valor;
        private Movimentacao movimentacao;

        public Gastos()
        {
        }

        public Movimentacao Movimentacao { get => movimentacao; set => movimentacao = value; }
        public float Valor { get => valor; set => valor = value; }
        public string Responsavel { get => responsavel; set => responsavel = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Data { get => data; set => data = value; }
        public String Id { get => id; set => id = value; }
    }
}
