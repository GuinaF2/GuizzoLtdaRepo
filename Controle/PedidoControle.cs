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
                string SQL = "INSERT INTO tb_pedido(idcliente,idmotorista,nmrvolumes,dtpedido,valorpedido) values(@idcliente,@idmotorista,@nmrvolumes,@dtpedido,@valorpedido)";
                //declaração de vetor de campos
                string[] campos = {"@idcliente", "@idmotorista", "@nmrvolumes", "@dtpedido", "@valorpedido" };
                //declaração de vetor de informações
                string[] valores = { modelo.CodCliente.ToString(),modelo.CodMotorista.ToString(), modelo.PedidoVolumes, modelo.PedidoData, modelo.ValorPedido};



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
        public bool DeletarPedido(PedidoModelo us)
        {
            try
            {
                string sql = "DELETE from tb_pedido where idpedido = @codigo";
                if (conexaosql.deletarDados(us.CodPedido, sql) >= 1)
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
        public bool AtualizarPedido(PedidoModelo us)
        {
            try
            {
                string sql = "UPDATE tb_pedido set idcliente=@idcliente,idmotorista=@idmotorista,nmrvolumes=@nmrvolumes, statuspedido=@statuspedido,dtpedido=@dtpedido,valorpedido=@valorpedido where idpedido= @codigo";
                string[] campos = { "@idcliente","@idmotorista","@nmrvolumes", "@statuspedido", "@dtpedido", "@valorpedido" };
                string[] valores = { us.CodCliente.ToString(), us.CodMotorista.ToString(), us.PedidoVolumes, us.PedidoStatus, us.PedidoData, us.ValorPedido };
                if (conexaosql.atualizarDados(us.CodPedido, campos, valores, sql) >= 1)
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
    }
}
