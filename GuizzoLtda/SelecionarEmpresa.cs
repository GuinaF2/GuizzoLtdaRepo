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
            dgViewSelEmp.DataSource = conexaosql.verDados("SELECT * FROM tb_cliente");
        }

        private void dgViewSelEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgViewSelEmp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgViewSelEmp.CurrentRow.Selected = true;
                

                conexaosql = new Conexao();
                MySqlConnection con = conexaosql.getConexao();
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * from tb_cliente where idcliente = @id";
                cmd.Parameters.AddWithValue("@id", id);
                string img = cmd.ExecuteScalar().ToString();
                pbLogoEmp.Image = Image.FromFile(img);
                con.Close();


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
