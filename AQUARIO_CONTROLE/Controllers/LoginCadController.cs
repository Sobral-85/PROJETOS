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
    public class LoginCadController
    {
        public bool tem = false;
        public string mensagem = "";
      
        public int Inserir(CadLogin obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO acesso([email],[senha]) VALUES(@email,@senha)";
                cn.Parameters.Add("email", SqlDbType.NVarChar).Value = obj.Login;
                cn.Parameters.Add("senha", SqlDbType.NVarChar).Value = obj.Senha;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd; 
            }
        }
        public int Editar(CadLogin obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandText = "UPDATE acesso SET email = @email  WHERE email = @email";
                cn.Parameters.Add("email", SqlDbType.NVarChar).Value = obj.Login;
                cn.Parameters.Add("senha", SqlDbType.NVarChar).Value = obj.Senha;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
        public bool VerificarLogin(CadLogin obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                bool result = false;
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandText = "SELECT * FROM acesso WHERE email = @email and senha = @senha";
                cn.Parameters.Add("email", SqlDbType.NVarChar).Value = obj.Login;
                cn.Parameters.Add("senha", SqlDbType.NVarChar).Value = obj.Senha;
                SqlDataReader reader;

                try
                {
                    cn.Connection = con;
                    reader = cn.ExecuteReader();
                    if (reader.HasRows)
                    {
                        tem = true;
                    }

                    reader.Close();
                }
                catch (Exception)
                {
                    this.mensagem = "Erro com a base de dados "; 
                }
                return result;
            }
        }
        //public bool Acessar(string login, string senha)
        //{
        //    using (SqlConnection con = new SqlConnection())
        //    {
        //        con.ConnectionString = Properties.Settings.Default.Setting;
        //        SqlCommand cn = new SqlCommand();

        //    }
        //    return;
        //}
    }
}
