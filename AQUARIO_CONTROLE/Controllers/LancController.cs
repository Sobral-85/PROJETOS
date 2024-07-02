using AQUARIO_CONTROLE.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQUARIO_CONTROLE.Controllers
{
    class LancController
    {
        public int Inserir(Lancamento obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Comunicação com o banco de dados
                con.ConnectionString = Properties.Settings.Default.Setting;
                //Comando de inserir na tabela do banco de dados 
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO lancamento ([tipo],[descricao],[valor],[mes],[id_ano],[dataatual]) VALUES (@tipo,@descricao,@valor,@mes,@id_ano,@dataatual)";
                cn.Parameters.Add("tipo", SqlDbType.VarChar).Value = obj.Tipo;// Classe Ano
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = obj.Descricacao;
                cn.Parameters.Add("valor", SqlDbType.Decimal).Value = obj.Valor;
                cn.Parameters.Add("mes", SqlDbType.VarChar).Value = obj.Mes;
                cn.Parameters.Add("id_ano", SqlDbType.Int).Value = obj.Ano;
                cn.Parameters.Add("dataatual", SqlDbType.DateTime).Value = obj.Date;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
        public List<Lancamento> Buscar(Lancamento obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM lancamento WHERE dataatual = @dataatual";
                cn.Parameters.Add("dataatual", SqlDbType.DateTime).Value = obj.Date;
                cn.Connection = con;

                SqlDataReader dr;
                List<Lancamento> lista = new List<Lancamento>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamento dado = new Lancamento();
                        dado.Id_lancamento = Convert.ToInt32(dr["id_lancamento"]);
                        dado.Tipo = Convert.ToString(dr["tipo"]);
                        dado.Descricacao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);
                        dado.Mes = Convert.ToString(dr["mes"]);
                        dado.Ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Date = Convert.ToDateTime(dr["dataatual"]);
                        lista.Add(dado);

                    }

                }
                return lista;
            }
        }
        public List<Lancamento> BuscarTipo(Lancamento obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM lancamento WHERE tipo = @tipo";
                cn.Parameters.Add("tipo", SqlDbType.VarChar).Value = obj.Tipo;
                cn.Connection = con;

                SqlDataReader dr;
                List<Lancamento> lista = new List<Lancamento>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamento dado = new Lancamento();
                        dado.Id_lancamento = Convert.ToInt32(dr["id_lancamento"]);
                        dado.Tipo = Convert.ToString(dr["tipo"]);
                        dado.Descricacao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);
                        dado.Mes = Convert.ToString(dr["mes"]);
                        dado.Ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Date = Convert.ToDateTime(dr["dataatual"]);
                        lista.Add(dado);

                    }

                }
                return lista;
            }
        }
        public List<Lancamento> Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM lancamento ";
                cn.Connection = con;

                SqlDataReader dr;
                List<Lancamento> lista = new List<Lancamento>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamento dado = new Lancamento();
                        dado.Id_lancamento = Convert.ToInt32(dr["id_lancamento"]);
                        dado.Tipo = Convert.ToString(dr["tipo"]);
                        dado.Descricacao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);
                        dado.Mes = Convert.ToString(dr["mes"]);
                        dado.Ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Date = Convert.ToDateTime(dr["dataatual"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
        public int Editar(Lancamento obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Comunicação com o banco de dados
                con.ConnectionString = Properties.Settings.Default.Setting;
                //Comando de inserir na tabela do banco de dados 
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE lancamento  SET tipo = @tipo, descricao = @descricao, valor = @valor,mes = @mes,id_ano = @id_ano, dataatual = @dataatual WHERE id_lancamento = @id";
                cn.Parameters.Add("tipo", SqlDbType.VarChar).Value = obj.Tipo;// Classe Ano
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = obj.Descricacao;
                cn.Parameters.Add("valor", SqlDbType.Decimal).Value = obj.Valor;
                cn.Parameters.Add("mes", SqlDbType.VarChar).Value = obj.Mes;
                cn.Parameters.Add("id_ano", SqlDbType.Int).Value = obj.Ano;
                cn.Parameters.Add("dataatual", SqlDbType.DateTime).Value = obj.Date;
                cn.Parameters.Add("id", SqlDbType.Int).Value = obj.Ano;// Classe Ano
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
        public int Deletar(Lancamento obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Comunicação com o banco de dados
                con.ConnectionString = Properties.Settings.Default.Setting;
                //Comando de inserir na tabela do banco de dados 
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM lancamento  WHERE id_lancamento = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = obj.Id_lancamento;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
    }
}
