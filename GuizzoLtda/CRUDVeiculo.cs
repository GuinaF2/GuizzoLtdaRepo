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
    public partial class CRUDVeiculo : Form
    {
        Conexao conexaosql = new Conexao();
        VeiculoModelo VeiculoModelo = new VeiculoModelo();
        VeiculoControle Controle = new VeiculoControle();
        int id;
        public CRUDVeiculo()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {

        }

        private void btnApaga_Click(object sender, EventArgs e)
        {

        }

        private void CRUDVeiculo_Load(object sender, EventArgs e)
        {
            dataGridVeiculo.DataSource = conexaosql.verDados("SELECT * FROM tb_veiculo");

            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtPlaca.Visible = false;
            txtTipo.Visible = false;
            txtRota.Visible = false;
            dataSeguro.Visible = false;

            labelseguro.Visible = false;
            labelplaca.Visible = false;
            labeltipo.Visible = false;
            labelrota.Visible = false;
        }
    }
}
