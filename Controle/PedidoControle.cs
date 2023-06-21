using Modelos;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Reflection;

namespace Controle
{
    public class PedidoControle :PedidoModelo
    {
        Conexao conexaosql = new Conexao();
        bool resultado;

        public PedidoControle()
        {

        }

        public int CadastrarPedido(PedidoModelo modelo)
        {
            //variável de confirmação do banco
            int valorCadastroPed = -1;

            try
            {
                string SQL = "INSERT INTO tb_pedido(cpf,registrogeral,nome,idveiculo,carteiramotorista,tipocarteira) values(@cpf,@registrogeral,@nome,@idveiculo,@carteiramotorista,@tipocarteira)";
                //declaração de vetor de campos
                string[] campos = { "@cpf", "@registrogeral", "@nome", "@idveiculo", "@carteiramotorista", "@tipocarteira" };
                //declaração de vetor de informações
                string[] valores = { modelo.CodPedido.ToString(), modelo.CodCliente.ToString(),modelo.CodMotorista.ToString(), modelo.PedidoData, modelo.PedidoVolumes, modelo.PedidoStatus, modelo.ValorPedido};



                if (conexaosql.cadastrar(campos, valores, SQL) >= 1)
                {
                    valorCadastroPed = 1;
                }
                else
                {
                    valorCadastroPed = 0;
                }
            }
            catch (Exception ex)
            {
                //Lança erros do sistema
                throw new Exception(ex.Message);
            }
            return valorCadastroPed;
        }

    }
}
