﻿using Controle;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuizzoLtda
{
    public partial class PedidoFunc : Form
    {
        Conexao conexaosql = new Conexao();
        PedidoModelo PedidoModelo = new PedidoModelo();
        PedidoControle Controle = new PedidoControle();
        public PedidoFunc()
        {
            InitializeComponent();
        }

        private void cbAberto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAberto.Checked)
            {
                cbEncerrado.Checked = false;
            }
        }

        private void cbEncerrado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEncerrado.Checked)
            {
                cbAberto.Checked = false;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            dtgPedido.Visible = true;

            txtDtPedido.Visible = false;
            labelDtPedido.Visible = false;
            cbAberto.Visible = false;
            cbEncerrado.Visible = false;
            btnConfirma.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FuncionarioMenu fmenureturn = new FuncionarioMenu();
            this.Hide();
            fmenureturn.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PedidoFunc_Load(object sender, EventArgs e)
        {
            dtgPedido.DataSource = conexaosql.verDados("SELECT * FROM tb_pedido");
        }
    }
}
