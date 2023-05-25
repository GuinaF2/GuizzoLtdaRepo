using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class VeiculoModelo
    {
        private int idVeiculo;
        private string placa_motorista;
        private string tipo_veiculo;
        private string rota_veiculo;
        private string seguro_data;



        public VeiculoModelo()
        {
            idVeiculo = 0;
            placa_motorista = "";
            tipo_veiculo = "";
            rota_veiculo = "";
            seguro_data="";
        }

        public int CodVeiculo
        {
            get { return idVeiculo; }
            set { idVeiculo = value; }
        }

        public string PlacaVeiculo
        {
            get { return placa_motorista; }
            set { placa_motorista = value; }
        }
        public string TipoVeiculo
        {
            get { return tipo_veiculo; }
            set { tipo_veiculo = value; }
        }
        public string RotaVeiculo
        {
            get { return rota_veiculo; }
            set { rota_veiculo = value; }
        }
        public string SeguroVeiculo
        {
            get { return seguro_data; }
            set { seguro_data = value; }
        }
    }
}
