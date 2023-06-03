using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class MotoristaModelo
    {
        private int idMotorista;
        private int idVeiculo;
        private string cpf;
        private string registrogeral;

        public MotoristaModelo()
        {
            idMotorista = 0;
            idVeiculo= 0;
            cpf = "";
            registrogeral = "";
        }

        public int CodMotorista
        {
            get { return idMotorista; }
            set { idMotorista = value; }

        }
        public int CodVeiculo
        {
            get { return idVeiculo; }
            set { idVeiculo = value; }

        }
        public string cpfMotorista
        {
            get { return cpf; }
            set { cpf = value; }

        }
        public string RgMotorista
        {
            get { return registrogeral; }
            set { registrogeral = value; }

        }

        
    }
}
