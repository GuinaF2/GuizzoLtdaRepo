using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class VeiculoControle : VeiculoModelo
    {
        Conexao conexaosql = new Conexao();
        bool resultado;
        public VeiculoControle()
        {

        }
        public int CadastrarVeiculo(VeiculoModelo modelo)
        {
            //variável de confirmação do banco
            int valorCadastro = -1;

            try
            {
                string SQL = "INSERT INTO tb_veiculo(placa_motorista,tipo_veiculo,rota_veiculo,seguro_data) values(@placa_motorista,@tipo_veiculo,@rota_veiculo,@seguro_data)";
                //declaração de vetor de campos
                string[] campos = { "@placa_motorista", "@tipo_veiculo", "@rota_veiculo", "@seguro_data" };
                //declaração de vetor de informações
                string[] valores = { modelo.PlacaVeiculo, modelo.TipoVeiculo, modelo.RotaVeiculo,modelo.SeguroVeiculo };



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

        public bool DeletarUsuario(VeiculoModelo us)
        {
            try
            {
                string sql = "DELETE from tb_veiculo where idveiculo = @codigo";
                if (conexaosql.deletarDados(us.CodVeiculo, sql) >= 1)
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

        public bool AtualizarUsuario(VeiculoModelo us)
        {
            try
            {
                string sql = "UPDATE tb_veiculo set placa_motorista=@placa_motorista, tipo_veiculo=@tipo_veiculo, rota_veiculo=@rota_veiculo,seguro_data=@seguro_data where idveiculo= @codigo";
                string[] campos = { "@nome", "@senha", "@cargo" };
                string[] valores = { us.PlacaVeiculo, us.TipoVeiculo, us.RotaVeiculo, us.SeguroVeiculo };
                if (conexaosql.atualizarDados(us.CodVeiculo, campos, valores, sql) >= 1)
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
        
        public VeiculoModelo CarregaUsuario(int id)
        {
            VeiculoModelo us = new VeiculoModelo();
            try
            {
                conexaosql = new Conexao();
                MySqlConnection con = conexaosql.getConexao();
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * from tb_veiculo where idveiculo = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    us.PlacaVeiculo = registro["placa_motorista"].ToString();
                    us.TipoVeiculo = registro["tipo_veiculo"].ToString();
                    us.RotaVeiculo = registro["rota_veiculo"].ToString();
                    us.SeguroVeiculo = registro["seguro_data"].ToString();

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
