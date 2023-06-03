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
    public partial class CRUDEmpresa : Form
    {
        Conexao conexaosql = new Conexao();
        EmpresaModelo EmpresaModelo = new EmpresaModelo();
        EmpresaControle Controle = new EmpresaControle();
        int id;
        public CRUDEmpresa()
        {
            InitializeComponent();
        }

        private void CRUDEmpresa_Load(object sender, EventArgs e)
        {
            dataGridCRUDEmpresa.DataSource = conexaosql.verDados("SELECT * FROM tb_cliente");

            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtIdEmpresa.Visible = false;
            txtCnpj.Visible = false;
            txtInscEstadual.Visible = false;
            txtNome.Visible = false;



            labelid.Visible = false;
            labelinscestad.Visible = false;
            labelcnpj.Visible = false;
            labelrazaosocial.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = true;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtIdEmpresa.Visible = true;
            txtCnpj.Visible = true;
            txtInscEstadual.Visible = true;
            txtNome.Visible = true;
            txtNome.Visible=true;

            labelfoto.Visible = true;
            labelid.Visible = true;
            labelinscestad.Visible = true;
            labelcnpj.Visible = true;
            labelrazaosocial.Visible = true;
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SaveDelete_Click(object sender, EventArgs e)
        {

        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
