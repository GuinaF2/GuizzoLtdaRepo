using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Reflection;

namespace Controle
{
    public class SolicitacaoControle : SolicitacaoModelo
    {
        Conexao conexaosql = new Conexao();
        bool resultado;
        public SolicitacaoControle()
        {
        }
        public int CadastrarSolicitacao(SolicitacaoModelo modelo)
        {
            int valorCadastro = -1;
            try
            {
                string SQL = "INSERT INTO tb_solicitacao(idfuncionario, tipo_solicit, descricao, condicao) values(@codigo, @tipo_solicit, @descricao, @status)";
                string[] campos = { "@codigo", "@tipo_solicit", "@descricao", "@status" };
                string[] valores = { modelo.CodFuncionario.ToString(), modelo.TipoSolicitacao, modelo.DescSolicitacao, modelo.StatusSolicitacao };

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
                MessageBox.Show("Erro ao enviar solicitação. \n" + ex);
            }
            return valorCadastro;
        }

        public bool AtualizarSolicitacao(SolicitacaoModelo uss)
        {
            try
            {
                string sql = "UPDATE tb_solicitacao set condicao=@condicao where idsolicitacao= @codigo";
                string[] campos = { "@condicao" };
                string[] valores = { uss.StatusSolicitacao };
                if (conexaosql.atualizarDados(uss.CodSolicitacao, campos, valores, sql) >= 1)
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
