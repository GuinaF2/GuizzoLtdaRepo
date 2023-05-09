using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Controle
{
    public class Conexao
    {
        static private string servidor = "localhost";
        static private string db = "dbguizzo";
        static private string usuario = "root";
        static private string senha = "";
        static private string StrConexao = "server=" + servidor + ";database=" + db + ";user id=" + usuario + ";password=" + senha;
        //variável da conexão
        public MySqlConnection conexaosql = null;
        //método de conexão
        public MySqlConnection getConexao()
        {
            conexaosql = new MySqlConnection(StrConexao);
            return conexaosql;
        }

        //obter as informações do banco
        public DataTable verDados(string sql)
        {
            DataTable dt = new DataTable();
            conexaosql = getConexao();
            conexaosql.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conexaosql);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            //consulta
            MySqlDataAdapter dados = new MySqlDataAdapter(cmd);
            dados.Fill(dt);
            conexaosql.Close();
            return dt;
        }


        //método de cadastro
        //passando os atributos da entidade, dados da view e a instrução para inserir no sql
        public int cadastrar(string[] campos, string[] valores, string SQLInsert)
        {
            int registro = -1;
            try
            {
                conexaosql = getConexao(); //procura a conexão
                conexaosql.Open();         //abre o banco
                MySqlCommand cmd = new MySqlCommand(SQLInsert, conexaosql);

                cmd.CommandType = CommandType.Text; //passando uma instrução de texto
                cmd.CommandText = SQLInsert;
                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                registro = cmd.ExecuteNonQuery();

                conexaosql.Close();
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int deletarDados(int codigo, string sql)
        {
            int registro = -1;
            try
            {
                conexaosql = getConexao();
                conexaosql.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conexaosql);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@codigo", codigo);

                registro = cmd.ExecuteNonQuery();
                conexaosql.Close();
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); ;
            }
        }

        public int atualizarDados(int codigo, string[] campos, string[] valores, string sql)
        {
            int registro = -1;
            try
            {
                conexaosql = getConexao();
                conexaosql.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conexaosql);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;

                for (int i = 0; i < campos.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                cmd.Parameters.AddWithValue("@codigo", codigo);
                registro = cmd.ExecuteNonQuery();
                conexaosql.Close();
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); ;
            }
        }
    }
}

