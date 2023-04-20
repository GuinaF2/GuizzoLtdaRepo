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
                string SQL = "INSERT INTO tb_usuario(nome, cpf, email, telefone, senha) values(@nome, @cpf, @email, @telefone, @senha)";
                //declaração de vetor de campos
                string[] campos = { "@nome", "@cpf", "@email", "@telefone", "@senha" };
                //declaração de vetor de informações
                string[] valores = { modelo.NomeUser, modelo.CpfUser, modelo.EmailUser, modelo.FoneUser, modelo.SenhaUser };

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
                string sql = "DELETE from tb_usuario where idusuario = @codigo";
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
                string sql = "UPDATE tb_usuario set nome=@nome, cpf=@cpf, email=@email, telefone=@telefone, senha=@senha where idusuario= @codigo";
                string[] campos = { "@nome", "@cpf", "@email", "@telefone", "@senha" };
                string[] valores = { us.NomeUser, us.CpfUser, us.EmailUser, us.FoneUser, us.SenhaUser };
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
        public int logar(UsuarioModelo us)
        {
            int registro;
            try
            {
                string sql = "SELECT COUNT(*) FROM tb_usuario where email=@email and senha=@senha";
                MySqlConnection conexaologin = conexaosql.getConexao();
                conexaologin.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conexaologin);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@email", us.EmailUser);
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

                cmd.CommandText = "SELECT * from tb_usuario where idusuario = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    us.CpfUser = registro["cpf"].ToString();
                    us.EmailUser = registro["email"].ToString();
                    us.NomeUser = registro["nome"].ToString();
                    us.FoneUser = registro["telefone"].ToString();
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
    }
}
