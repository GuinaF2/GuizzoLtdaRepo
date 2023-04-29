using Modelos;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;

namespace Controle
{
    public class UsuarioControle : UsuarioModelo
    {
        Conexao conexaosql = new Conexao();
        bool resultado;
        public UsuarioControle()
        {
        }
        public int cadastrar(UsuarioModelo modelo)
        {
            //variável de confirmação do banco
            int valorCadastro = -1;

            try
            {
                string SQL = "INSERT INTO tb_funcionario(nomeuser,senhauser) values(@nome,@senha)";
                //declaração de vetor de campos
                string[] campos = { "@nome","@senha"};
                //declaração de vetor de informações
                string[] valores = { modelo.NomeUser, modelo.SenhaUser };

               
                if (conexaosql.cadastrar(campos, valores, SQL) >= 1)
                {
                    valorCadastro = 1;
                }
                else
                {
                    valorCadastro = 0;
                }
            }
            catch (Exception ex)
            {
                //Lança erros do sistema
                throw new Exception(ex.Message);
            }
            return valorCadastro;
        }

        public bool DeletarUsuario(UsuarioModelo us)
        {
            try
            {
                string sql = "DELETE from tb_funcionario where idusuario = @codigo";
                if (conexaosql.deletarDados(us.CodUsuario, sql) >= 1)
                {
                    return resultado = true;
                }
                else
                {
                    return resultado = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AtualizarUsuario(UsuarioModelo us)
        {
            try
            {
                string sql = "UPDATE tb_funcionario set nomeuser=@nome, senhauser=@senha where idfuncionario= @codigo";
                string[] campos = { "@nome", "@senha" };
                string[] valores = { us.NomeUser, us.SenhaUser };
                if (conexaosql.atualizarDados(us.CodUsuario, campos, valores, sql) >= 1)
                {
                    return resultado = true;
                }
                else
                {
                    return resultado = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Login(UsuarioModelo us)
        {
            int registro;
            try
            {
                string sql = "SELECT COUNT(*) FROM tb_funcionario where nomeuser=@nome and senhauser=@senha";
                MySqlConnection conexaologin = conexaosql.getConexao();
                conexaologin.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conexaologin);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", us.NomeUser);
                cmd.Parameters.AddWithValue("@senha", us.SenhaUser);
                registro = Convert.ToInt32(cmd.ExecuteScalar()); //retorna um inteiro
                conexaologin.Close();
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public UsuarioModelo CarregaUsuario(int id)
        {
            UsuarioModelo us = new UsuarioModelo();
            try
            {
                conexaosql = new Conexao();
                MySqlConnection con = conexaosql.getConexao();
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * from tb_pessoa where idpessoa = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    us.NomeUser = registro["nome"].ToString();
                    us.CpfUser = registro["cpf"].ToString();
                    us.ContatoUser = registro["contato"].ToString();
                    us.SenhaUser = registro["senha"].ToString();
                }
                con.Close();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return us;
        }
        public int LogarAdm(UsuarioModelo us)
        {
            int registro;
            try
            {
                string sql = "SELECT COUNT(*) FROM tb_funcionario where nomeuser=@nome and senhauser=@senha and cargo=2";
                MySqlConnection conexaologin = conexaosql.getConexao();
                conexaologin.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conexaologin);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cargo",us.CodCargo);
                cmd.Parameters.AddWithValue("@nome", us.NomeUser);
                cmd.Parameters.AddWithValue("@senha", us.SenhaUser);
                registro = Convert.ToInt32(cmd.ExecuteScalar()); //retorna um inteiro
                conexaologin.Close();
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
