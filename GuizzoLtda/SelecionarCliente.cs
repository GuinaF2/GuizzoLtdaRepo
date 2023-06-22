using Controle;
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
    public partial class SelecionarCliente : Form
    {
        public int idemp;
        int idcliente;
        Conexao conexaosql = new Conexao();

        VeiculoModelo ve = new VeiculoModelo();
        VeiculoControle vei = new VeiculoControle();
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();
        public SelecionarCliente()
        {
            InitializeComponent();
        }

        private void SelecionarCliente_Load(object sender, EventArgs e)
        {
            dgCliente.DataSource = conexaosql.verDados("SELECT * FROM tb_cliente");
        }

        private void dgVeiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCliente.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgCliente.CurrentRow.Selected = true;
                idemp = Convert.ToInt32(dgCliente.Rows[e.RowIndex].Cells["idcliente"].FormattedValue);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (dgCliente.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                MessageBox.Show("Favor selecionar ID do Cliente.");
            }
        }
    }
}
