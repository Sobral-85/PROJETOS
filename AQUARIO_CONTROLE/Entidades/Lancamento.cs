using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Campos que estão no Banco de dados
namespace AQUARIO_CONTROLE.Entidades
{
    public class Lancamento
    {
        //Campos que contém na base de dados 
        int id_lancamento;
        string tipo;
        string descricacao;
        decimal valor;
        string mes;
        int ano;
        DateTime date;

        //Metodo para envio e recebimento 
        public int Id_lancamento { get => id_lancamento; set => id_lancamento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descricacao { get => descricacao; set => descricacao = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public string Mes { get => mes; set => mes = value; }
        public int Ano { get => ano; set => ano = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
