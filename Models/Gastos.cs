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
        private double valor;
        private string marca;
        private string modelo;
        private string cor;
        private string placa;
        private Movimentacao movimentacao;

        public Gastos()
        {
        }

        public Movimentacao Movimentacao { get => movimentacao; set => movimentacao = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Responsavel { get => responsavel; set => responsavel = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Data { get => data; set => data = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Placa { get => placa; set => placa = value; }
    }
}
