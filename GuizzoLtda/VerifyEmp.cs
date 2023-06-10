using Controle;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuizzoLtda
{
    public partial class VerifyEmp : Form
    {
        Conexao conexaosql = new Conexao();
        EmpresaModelo EmpresaModelo = new EmpresaModelo();
        EmpresaControle Controle = new EmpresaControle();
        public VerifyEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            (dgVerEmp.DataSource as DataTable).DefaultView.RowFilter = String.Format("razao_social like '%" + txtRazaoSoc.Text + "%'");

            dgVerEmp.Visible = true;

            labelCnpj.Visible = false;
            labelInscEstad.Visible = false;
            labelRazaoSoc.Visible = false;

            txtCnpj.Visible = false;
            txtInscriEstad.Visible = false;
            txtRazaoSoc.Visible = false;
            btnConfirmar.Visible = false;
            returnBtn.Visible = true;
            btnMenu.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerifyEmp_Load(object sender, EventArgs e)
        {
            dgVerEmp.DataSource = conexaosql.verDados("SELECT * FROM tb_cliente");


        }

        private void dgVerEmp_Click(object sender, EventArgs e)
        {

        }

        private void txtRazaoSoc_Click(object sender, EventArgs e)
        {
            txtRazaoSoc.Text = "";
        }

        private void txtRazaoSoc_TextChanged(object sender, EventArgs e)
        {
            txtRazaoSoc.ForeColor = System.Drawing.Color.Black;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtRazaoSoc.Visible = true;
            txtInscriEstad.Visible = true;
            txtCnpj.Visible = true;

            labelCnpj.Visible = true;
            labelInscEstad.Visible = true;
            labelRazaoSoc.Visible = true;
            btnConfirmar.Visible = true;
            btnMenu.Visible = true;
            dgVerEmp.Visible = false;
            returnBtn.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FuncionarioMenu fmenureturn = new FuncionarioMenu();
            this.Hide();
            fmenureturn.Show();
        }
    }
}
