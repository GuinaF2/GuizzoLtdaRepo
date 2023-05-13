using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class EnderecoControle : EnderecoModelo
    {
        Conexao conexaosql = new Conexao();
        bool resultado;
        public EnderecoControle()
        {

        }
        public int CadastrarEndereco(EnderecoModelo modelo)
        {
            //variável de confirmação do banco
            int valorCadastro = -1;

            try
            {
                string SQL = "INSERT INTO tb_endereco(rua,bairro,cep,numero,complemento) values(@rua,@bairro,@cep,@numero,@complemento)";
                //declaração de vetor de campos
                string[] campos = { "@rua", "@bairro" ,"@cep","@numero","@complemento"};
                //declaração de vetor de informações
                string[] valores = { modelo.RuaUser, modelo.BairroUser, modelo.CepUser, modelo.NmrUser, modelo.CompUser };


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
    }
}
