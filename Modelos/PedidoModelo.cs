using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class PedidoModelo
    {
        private int idPedido;
        private int idCliente;
        private int idMotorista;
        private string nmrvolumes;
        private float pedidovalor;
        private string statuspedido;
        private string dtpedido;

        public PedidoModelo()
        {
            idPedido = 0;
            idMotorista = 0;
            idCliente = 0;
            nmrvolumes = "";
            pedidovalor = 0;
            statuspedido = "";
            dtpedido = "";
        }

        public int CodPedido
        {
            get { return idPedido; }
            set { idPedido = value; }

        }
        public int CodMotorista
        {
            get { return idMotorista; }
            set { idMotorista = value; }
        }
        public int CodCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string PedidoVolumes
        {
            get { return nmrvolumes; }
            set { nmrvolumes = value; }

        }
        public string PedidoData
        {
            get { return dtpedido; }
            set { dtpedido = value; }

        }
        public string PedidoStatus
        {
            get { return statuspedido; }
            set { statuspedido = value; }

        }
        public float ValorPedido
        {
            get { return pedidovalor; }
            set { pedidovalor = value; }
        }

    }
}
