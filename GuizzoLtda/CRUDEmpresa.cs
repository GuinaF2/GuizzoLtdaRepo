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

        private void labelInscricao_Click(object sender, EventArgs e)
        {

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

        private void SaveCreate_Click(object sender, EventArgs e)
        {

        }

        private void SaveDelete_Click(object sender, EventArgs e)
        {

        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CRUDEmpresa_Load(object sender, EventArgs e)
        {
            dataGridEmpresa.DataSource = conexaosql.verDados("SELECT * FROM tb_cliente");

            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtID.Visible = false;
            txtNome.Visible = false;
            txtSenha.Visible = false;
            cbCargo.Visible = false;

            labelcargo.Visible = false;
            labelid.Visible = false;
            labelnome.Visible = false;
            labelsenha.Visible = false;
        }
    }
}
