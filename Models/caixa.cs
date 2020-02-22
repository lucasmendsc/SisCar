using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Models
{
    public class Caixa
    {
        private int id;
        private string operador;
        private string data;
        private ArrayList lancamentos = new ArrayList();
        private float saldo;
        private String situacao;

        public Caixa()
        {

        }

        public Caixa(string operador, string data, ArrayList lancamentos)
        {
            this.operador = operador;
            this.data = data;
            this.lancamentos = lancamentos;
        }

        public string Operador { get => operador; set => operador = value; }
        public string Data { get => data; set => data = value; }
        public ArrayList Lancamentos { get => lancamentos; set => lancamentos = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public int Id { get => id; set => id = value; }
        public string Situacao { get => situacao; set => situacao = value; }

        public override bool Equals(object obj)
        {
            return obj is Caixa caixa &&
                   operador == caixa.operador &&
                   data == caixa.data &&
                   EqualityComparer<ArrayList>.Default.Equals(lancamentos, caixa.lancamentos);
        }

        public override int GetHashCode()
        {
            var hashCode = 1699147144;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(operador);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(data);
            hashCode = hashCode * -1521134295 + EqualityComparer<ArrayList>.Default.GetHashCode(lancamentos);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
