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
    public partial class VerificarEmp : Form
    {
        Conexao conexaosql = new Conexao();
        EmpresaModelo EmpresaModelo = new EmpresaModelo();
        EmpresaControle Controle = new EmpresaControle();
        public VerificarEmp()
        {
            InitializeComponent();
        }

        private void VerificarEmp_Load(object sender, EventArgs e)
        {

        }

        private void dgVerEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgVerEmp.DataSource = conexaosql.verDados("SELECT (idcliente,cnpj,razao_social,inscricao_estadual) FROM tb_cliente");
        }

        private void txtRazaoSoc_Click(object sender, EventArgs e)
        {
            txtRazaoSoc.Text = "";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FuncionarioMenu fmenureturn = new FuncionarioMenu();
            this.Hide();
            fmenureturn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void returnBtn_Click(object sender, EventArgs e)
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
    }
}


