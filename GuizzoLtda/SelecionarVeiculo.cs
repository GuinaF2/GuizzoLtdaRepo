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
    public partial class SelecionarVeiculo : Form
    {
        public int idped;
        int idusuario;
        Conexao conexaosql = new Conexao();
        VeiculoModelo VeiculoModelo = new VeiculoModelo();
        VeiculoControle Controle = new VeiculoControle();
        UsuarioModelo us = new UsuarioModelo();
        public SelecionarVeiculo()
        {
            InitializeComponent();
        }

        private void SelecionarVeiculo_Load(object sender, EventArgs e)
        {
            dgSelectVeiculo.DataSource = conexaosql.verDados("SELECT * FROM tb_veiculo");
        }

        private void dgSelectVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSelectVeiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSelectVeiculo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgSelectVeiculo.CurrentRow.Selected = true;
                idped = Convert.ToInt32(dgSelectVeiculo.Rows[e.RowIndex].Cells["idveiculo"].FormattedValue);
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
