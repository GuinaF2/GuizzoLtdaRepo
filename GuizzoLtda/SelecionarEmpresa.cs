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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Program.thePictureBox = pbLogoEmp;
        }





        private void dgViewSelEmp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgViewSelEmp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgViewSelEmp.CurrentRow.Selected = true;
                    textBox1.Text = dgViewSelEmp.Rows[e.RowIndex].Cells["logo"].Value.ToString();
                    pbLogoEmp.ImageLocation = textBox1.Text;




                }
            }
            catch
            {
                MessageBox.Show("Selecione your company plese!!!!!!");
            }
        }

        private void SelecionarEmpresa_Load_1(object sender, EventArgs e)
        {

            dgViewSelEmp.DataSource = conexaosql.verDados("SELECT idcliente, razao_social,logo FROM tb_cliente");
        }

        private void dgViewSelEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Inicio finicioreturn = new Inicio();
            this.Hide();
            finicioreturn.Show();
            
        }

        private void pbLogoEmp_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
