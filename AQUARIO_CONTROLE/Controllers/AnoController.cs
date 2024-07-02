using AQUARIO_CONTROLE.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQUARIO_CONTROLE.Controllers
{// A classe controller não se comunica diretamente com a Views é preciso criar uma classe para essa comunicação na pasta Models


    public class AnoController
    {
        public int Inserir(Ano obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Comunicação com o banco de dados
                con.ConnectionString = Properties.Settings.Default.Setting;
                //Comando de inserir na tabela do banco de dados 
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO ano ([ano]) VALUES (@ano)";
                cn.Parameters.Add("ano", SqlDbType.Int).Value = obj.Anos;// Classe Ano
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();// recebe o que está sendo executado na consulta
                return qtd;
            }
        }
        public List<Ano> Buscar(Ano obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM ano WHERE ano = @ano";
                cn.Parameters.Add("ano", SqlDbType.Int).Value = obj.Anos;
                cn.Connection = con;

                SqlDataReader dr;
                List<Ano> lista = new List<Ano>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Ano dado = new Ano();
                        dado.Id_ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Anos = Convert.ToInt32(dr["ano"]);
                        lista.Add(dado);
                    }
                   
                }
                return lista;
            }
        }
        public List<Ano> Listar() 
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM ano ";
                cn.Connection = con;

                SqlDataReader dr;
                List<Ano> lista = new List<Ano>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Ano dado = new Ano();
                        dado.Id_ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Anos = Convert.ToInt32(dr["ano"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
        public int Editar(Ano obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Comunicação com o banco de dados
                con.ConnectionString = Properties.Settings.Default.Setting;
                //Comando de inserir na tabela do banco de dados 
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE ano  SET ano = @ano WHERE id_ano = @id_ano";
                cn.Parameters.Add("ano", SqlDbType.Int).Value = obj.Anos;// Classe Ano
                cn.Parameters.Add("id_ano", SqlDbType.Int).Value = obj.Id_ano;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
        public int Deletar(Ano obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Comunicação com o banco de dados
                con.ConnectionString = Properties.Settings.Default.Setting;
                //Comando de inserir na tabela do banco de dados 
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM ano  WHERE id_ano = @id_ano";
                cn.Parameters.Add("id_ano", SqlDbType.Int).Value = obj.Id_ano;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
    }
}
