using Controle;
using Modelos;
using MySql.Data.MySqlClient;
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
    public partial class SelecionarEmpresa : Form
    {
        Conexao conexaosql = new Conexao();

        EmpresaModelo EmpresaModelo = new EmpresaModelo();
        EmpresaControle Controle = new EmpresaControle();
        int id;
        public SelecionarEmpresa()
        {
            InitializeComponent();
        }

        private void SelecionarEmpresa_Load(object sender, EventArgs e)
        {
            dgViewSelEmp.DataSource = conexaosql.verDados("SELECT idcliente, logo FROM tb_cliente");
        }

        private void dgViewSelEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgViewSelEmp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgViewSelEmp.CurrentRow.Selected = true;


               


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
