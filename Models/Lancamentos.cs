using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Lancamentos
    {
        private int id;
        private string tipo;
        private string descricao;
        private string data;
        private double valor;
        private int caixa;

        

        public Lancamentos(int id, string tipo, string descricao, float valor, int caixa)
        {
            this.id = id;
            this.tipo = tipo;
            this.descricao = descricao;
            this.valor = valor;
            this.caixa = caixa;
        }

        public Lancamentos()
        {
        }


        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Caixa { get => caixa; set => caixa = value; }
        public string Data { get => data; set => data = value; }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
