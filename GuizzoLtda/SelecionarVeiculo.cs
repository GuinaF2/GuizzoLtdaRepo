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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GuizzoLtda
{
    public partial class SelecionarVeiculo : Form
    {
        public int idveic;
        int idcliente;
        Conexao conexaosql = new Conexao();

        VeiculoModelo ve = new VeiculoModelo();
        VeiculoControle vei = new VeiculoControle();
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();

        public SelecionarVeiculo(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
        }


        private void dgSelectVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSelectVeiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void SelecionarVeiculo_Load_1(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);

            dgSelectVeiculo.DataSource = conexaosql.verDados("SELECT idveiculo,placa_motorista,tipo_veiculo,seguro_data,renavam FROM tb_veiculo");
        }

        private void dgSelectVeiculo_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
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
                MessageBox.Show("Favor selecionar ID do Veiculo.");
            }
        }
    }
}
