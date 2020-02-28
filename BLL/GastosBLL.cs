﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class GastosBLL
    {

        public void inserirGastos(Gastos gastos)
        {
            GastosVeiculosDAL gastosVeiculosDAL = new GastosVeiculosDAL();
            gastosVeiculosDAL.InserirGastosVeiculos(gastos);
        }

        public void inserirLancamentoComoGasto(Lancamentos lancamentos)
        {
            try
            {

                Movimentacao movimentacao = new Movimentacao();
                DataTable dataTable = buscarVeiculoPorPlaca(lancamentos.Placa);
                Gastos gastos = new Gastos();

                if (dataTable.Rows.Count > 0)
                {
                    movimentacao.Cod_Mov_Veiculos = dataTable.Rows[0]["cod_mov_veiculos"].ToString();
                    gastos.Movimentacao = movimentacao;

                    gastos.Descricao = lancamentos.Descricao;
                    gastos.Data = converterDataTime(DateTime.Now.Date.ToString());
                    gastos.Responsavel = lancamentos.Responsavel;
                    gastos.Valor = lancamentos.Valor;

                    GastosVeiculosDAL gastosVeiculosDAL = new GastosVeiculosDAL();
                    gastosVeiculosDAL.InserirGastosVeiculos(gastos);

                    gerarLancamento(gastos, lancamentos.Placa);
                     MessageBox.Show("Lamcamento realizado com sucesso !");
                }
                else
                {
                    MessageBox.Show("Placa não invalida ou inexistente nos registros.");
                }
            }catch(Exception e){
                MessageBox.Show("Ocorreu um erro ao inserir um Lançamento.");
            }
        }



        private void gerarLancamento(Gastos gastos, string placa)
        {
            CaixaBLL caixabll = new CaixaBLL();
            DataTable dataTable = caixabll.recuperarCaixaAtual();
            try
            {
                if (dataTable.Rows.Count > 0)
                {
                    Lancamentos lancamentos = new Lancamentos();
                    lancamentos.Tipo = "SAIDA";
                    lancamentos.Descricao = gastos.Descricao;
                    lancamentos.Data = converterDataTime(DateTime.Now.Date.ToString());
                    lancamentos.Valor = gastos.Valor;
                    lancamentos.Placa = placa;
                    lancamentos.Responsavel = gastos.Responsavel;
                    lancamentos.Caixa = Convert.ToInt32(dataTable.Rows[0]["ID"].ToString());

                    caixabll.inserirLancamentos(lancamentos);

                }
                else
                {
                    MessageBox.Show("Erro ao gerar lançamento");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro para inserir lançamento no caixa:" + ex.Message);
            }

        }


        public DataTable consultarGastosVeiculos(int id)
        {
            GastosVeiculosDAL gastosVeiculosDAL = new GastosVeiculosDAL();
            return gastosVeiculosDAL.ConsultarGastosVeiculos(id);
        }
        public DataTable buscarVeiculoPorPlaca(string placa)
        {
            GastosVeiculosDAL gastosVeiculosDAL = new GastosVeiculosDAL();
            return gastosVeiculosDAL.buscarVeiculoPorPlaca(placa);
        }

        public string converterDataTime(string data)
        {
            string[] dt = data.Split('/', ' ');

            return dt[0] + "." + dt[1] + "." + dt[2];
        }
    }
}
