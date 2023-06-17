﻿using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class EmpresaControle : EmpresaModelo
    {
        Conexao conexaosql = new Conexao();
        bool resultado;
        public EmpresaControle()
        {
        }
            public int CadastroEmpresa(EmpresaModelo modelo)
            {
                int valorCadastro = -1;

                try
                {
                    string SQL = "INSERT INTO tb_cliente (cnpj,razao_social,inscricao_estadual,idendereco,logo) values(@cnpj,@razao_social,@inscricao_estadual,(SELECT idendereco FROM tb_endereco ORDER BY idendereco DESC LIMIT 1),@logo) ";
                     //declaração de vetor de campos         
                    string[] campos = { "@cnpj", "@razao_social", "@inscricao_estadual","@logo" };
                    //declaração de vetor de informações
                    string[] valores = { modelo.CnpjUser, modelo.RazaoSocialUser, modelo.InscEstadUser, modelo.LogoEmpresa };
                    
                 

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
        public EmpresaModelo CarregaEmpresa(int id)
        {
            EmpresaModelo us = new EmpresaModelo();
            try
            {
                conexaosql = new Conexao();
                MySqlConnection con = conexaosql.getConexao();
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT idcliente from tb_cliente where idcliente = @idcliente";
                cmd.Parameters.AddWithValue("@idcliente", id);

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    

                }
                con.Close();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return us;
        }
        public bool DeletarEmpresa(EmpresaModelo us)
        {
            try
            {
                string sql = "DELETE from tb_cliente where idcliente = @codigo";
                if (conexaosql.deletarDados(us.CodCliente, sql) >= 1)
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

        
        public bool AtualizarEmpresa(EmpresaModelo us)
        {
            try
            {
                string sql = "UPDATE tb_cliente set cnpj=@cnpj, razao_social=@razao_social,inscricao_estadual=@inscricao_estadual where idcliente= @codigo";
                string[] campos = { "@cnpj", "@razao_social", "@inscricao_estadual" };
                string[] valores = { us.CnpjUser, us.RazaoSocialUser, us.InscEstadUser };
                if (conexaosql.atualizarDados(us.CodCliente, campos, valores, sql) >= 1)
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
