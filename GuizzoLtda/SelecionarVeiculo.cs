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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GuizzoLtda
{
    public partial class SelecionarVeiculo : Form
    {
        public int idveic;
        int idcliente;
        Conexao conexaosql = new Conexao();
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();

        public SelecionarVeiculo(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
        }

        private void SelecionarVeiculo_Load(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);
            dgSelectVeiculo.DataSource = conexaosql.verDados("SELECT * FROM tb_veiculo RIGHT JOIN tb_cliente ON tb_veiculo.idcliente = tb_cliente.idcliente WHERE idcliente != '' AND tb_veiculo.idcliente = " + us.CodCliente.ToString());
        }

        private void dgSelectVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSelectVeiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSelectVeiculo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgSelectVeiculo.CurrentRow.Selected = true;
                idveic = Convert.ToInt32(dgSelectVeiculo.Rows[e.RowIndex].Cells["idveiculo"].FormattedValue);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (dgSelectVeiculo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                MessageBox.Show("Favor selecionar ID do pedido.");
            }
        }
    }
}
