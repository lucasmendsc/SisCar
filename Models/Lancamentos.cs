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
        private string placa;
        private string responsavel;

        

        public Lancamentos(int id, string tipo, string descricao, float valor, int caixa, string placa, string responsavel)
        {
            this.id = id;
            this.tipo = tipo;
            this.descricao = descricao;
            this.valor = valor;
            this.caixa = caixa;
            this.placa = placa;
            this.responsavel = responsavel;
        }

        public Lancamentos()
        {
        }


        public string Tipo { get => tipo; set => tipo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Caixa { get => caixa; set => caixa = value; }
        public string Data {get => data; set => data = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Responsavel { get => responsavel; set => responsavel = value; }

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
