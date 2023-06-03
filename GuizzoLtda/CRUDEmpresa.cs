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

            txtIdEmpresa.Visible = false;
            txtCnpj.Visible = false;
            txtInscEstadual.Visible = false;
            txtRazaoSocial.Visible = false;

            labelfoto.Visible = false;

            btnFoto.Visible = false;
            labelid.Visible = false;
            labelinscestad.Visible = false;
            labelcnpj.Visible = false;
            labelrazaosocial.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AdminMenu fmenureturn = new AdminMenu();
            this.Hide();
            fmenureturn.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = true;
            SaveDelete.Visible = false;

            txtIdEmpresa.Visible = true;
            txtCnpj.Visible = true;
            txtInscEstadual.Visible = true;
            txtRazaoSocial.Visible = true;
            btnFoto.Visible = true;

            labelfoto.Visible = true;
            labelid.Visible = true;
            labelinscestad.Visible = true;
            labelcnpj.Visible = true;
            labelrazaosocial.Visible = true;
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = false;
            SaveDelete.Visible = true;

            txtIdEmpresa.Visible = true;
            txtCnpj.Visible = true;
            txtInscEstadual.Visible = true;
            txtRazaoSocial.Visible = true;
            btnFoto.Visible = true;

            labelfoto.Visible = true;
            labelid.Visible = true;
            labelinscestad.Visible = true;
            labelcnpj.Visible = true;
            labelrazaosocial.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SaveDelete_Click(object sender, EventArgs e)
        {
            EmpresaModelo.CodCliente = Convert.ToInt32(txtIdEmpresa.Text);
            var resposta = DialogResult;
            resposta = MessageBox.Show("Tem certeza que deseja deletar a Empresa?", "! Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                if (Controle.DeletarEmpresa(EmpresaModelo) == true)
                {
                    MessageBox.Show("Cliente Deletado!.");
                }
            }
            else if (resposta == DialogResult.No)
            {
                MessageBox.Show("Processo Cancelado.");
            }
            CRUDEmpresa fempresacrud = new CRUDEmpresa();
            this.Hide();
            fempresacrud.Show();
        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {
            EmpresaModelo.CodCliente = Convert.ToInt32(txtIdEmpresa.Text);
            EmpresaModelo.CnpjUser = txtCnpj.Text;
            EmpresaModelo.RazaoSocialUser = txtRazaoSocial.Text;
            EmpresaModelo.InscEstadUser = txtInscEstadual.Text;

            if (Controle.AtualizarEmpresa(EmpresaModelo) == true)
            {
                MessageBox.Show("Cadastro Atualizado.");

                CRUDEmpresa fempresacrud = new CRUDEmpresa();
                this.Hide();
                fempresacrud.Show();
            }
            else
            {
                MessageBox.Show("Erro na atualização.");
            }
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void dataGridCRUDEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridCRUDEmpresa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridCRUDEmpresa.CurrentRow.Selected = true;

                    txtIdEmpresa.Text = dataGridCRUDEmpresa.Rows[e.RowIndex].Cells["idcliente"].Value.ToString();
                    txtCnpj.Text = dataGridCRUDEmpresa.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
                    txtRazaoSocial.Text = dataGridCRUDEmpresa.Rows[e.RowIndex].Cells["razao_social"].Value.ToString();
                    txtInscEstadual.Text = dataGridCRUDEmpresa.Rows[e.RowIndex].Cells["inscricao_estadual"].Value.ToString();
                }

                else
                {
                    MessageBox.Show("Favor selecionar ID da Empresa");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\t    Favor selecionar ID do Motorista. \n\nERRO: " + ex.Message);
            }
        }
    }
}
