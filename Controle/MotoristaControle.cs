using Modelos;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Reflection;

namespace Controle
{
    public class MotoristaControle : MotoristaModelo
    {
        Conexao conexaosql = new Conexao();
        bool resultado;
        public MotoristaControle()
        {

        }
        public int CadastrarMotorista(MotoristaModelo modelo)
        {
            //variável de confirmação do banco
            int valorCadastroMot = -1;

            try
            {
                string SQL = "INSERT INTO tb_motorista(cpf,registrogeral,nome,idveiculo,carteiramotorista,tipocarteira) values(@cpf,@registrogeral,@nome,@idveiculo,@carteiramotorista,@tipocarteira)";
                //declaração de vetor de campos
                string[] campos = { "@cpf", "@registrogeral","@nome" ,"@idveiculo","@carteiramotorista","@tipocarteira"};
                //declaração de vetor de informações
                string[] valores = { modelo.cpfMotorista, modelo.RgMotorista, modelo.nomeMotorista, modelo.CodVeiculo.ToString(), modelo.CnhMotorista, modelo.TipoCnhMotorista  };



                if (conexaosql.cadastrar(campos, valores, SQL) >= 1)
                {
                    valorCadastroMot = 1;
                }
                else
                {
                    valorCadastroMot = 0;
                }
            }
            catch (Exception ex)
            {
                //Lança erros do sistema
                throw new Exception(ex.Message);
            }
            return valorCadastroMot;
        }

        public bool DeletarMotorista(MotoristaModelo us)
        {
            try
            {
                string sql = "DELETE from tb_motorista where idmotorista = @codigo";
                if (conexaosql.deletarDados(us.CodMotorista, sql) >= 1)
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

        public bool AtualizarMotorista(MotoristaModelo us)
        {
            try
            {
                string sql = "UPDATE tb_motorista set cpf=@cpf, registrogeral=@registrogeral,nome=@nome,carteiramotorista=@carteiramotorista,tipocarteira=@tipocarteira,where idmotorista= @codigo";
                string[] campos = { "@cpf", "@registrogeral","@nome","@carteiramotorista","@tipocarteira"};
                string[] valores = { us.cpfMotorista, us.RgMotorista, us.nomeMotorista, us.CnhMotorista, us.TipoCnhMotorista };  
                if (conexaosql.atualizarDados(us.CodMotorista, campos, valores, sql) >= 1)
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
        
        public MotoristaModelo CarregaUsuario(int id)
        {
            MotoristaModelo us = new MotoristaModelo();
            try
            {
                conexaosql = new Conexao();
                MySqlConnection con = conexaosql.getConexao();
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * from tb_motorista where idmotorista = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    us.nomeMotorista = registro["nome"].ToString();
                    us.cpfMotorista = registro["cpf"].ToString();
                    us.RgMotorista = registro["registrogeral"].ToString();
                    us.CnhMotorista = registro["carteiramotorista"].ToString();
                    us.TipoCnhMotorista = registro["tipocarteira"].ToString();

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
