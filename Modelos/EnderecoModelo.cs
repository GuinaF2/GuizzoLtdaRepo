﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class EnderecoModelo
    {
        private int idEndereco;
        private string rua;
        private string bairro;
        private string cep;
        private string numero;
        private string complemento;

        public EnderecoModelo()
        {
            idEndereco = 0;
            rua = "";
            bairro = "";
            cep = "";
            numero = "";
            complemento = "";
        }

        public int CodEndereco
        {
            get { return idEndereco; }
            set { idEndereco = value; }

        }
        public string RuaUser
        {
            get { return rua; }
            set { rua = value; }

        }
        public string BairroUser
        {
            get { return bairro; }
            set { bairro = value; }

        }
        public string CepUser
        {
            get { return cep; }
            set { cep = value; }

        }

        public string NmrUser
        {
            get { return numero; }
            set { numero = value; }

        }
        public string CompUser
        {
            get { return complemento; }
            set { complemento = value; }

        }
    }
}
