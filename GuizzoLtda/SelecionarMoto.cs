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
    public partial class SelecionarMoto : Form
    {
        public int idmoto;
        int idcliente;
        Conexao conexaosql = new Conexao();

        MotoristaModelo ve = new MotoristaModelo();
        MotoristaControle vei = new MotoristaControle();
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();
        public SelecionarMoto(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
        }

        private void SelecionarMoto_Load(object sender, EventArgs e)
        {
            dgSelectMoto.DataSource = conexaosql.verDados("SELECT * FROM tb_motorista");
        }

        private void dgSelectMoto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSelectMoto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSelectMoto.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgSelectMoto.CurrentRow.Selected = true;
                idmoto = Convert.ToInt32(dgSelectMoto.Rows[e.RowIndex].Cells["idmotorista"].FormattedValue);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (dgSelectMoto.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                MessageBox.Show("Favor selecionar ID do Veiculo.");
            }
        }

        private void SelecionarMoto_Load_1(object sender, EventArgs e)
        {

        }
    }
}
