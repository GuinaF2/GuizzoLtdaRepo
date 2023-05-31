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

    }
}
