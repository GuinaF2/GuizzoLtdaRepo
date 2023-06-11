﻿using Controle;
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
    public partial class CRUDUser : Form
    {
        Conexao conexaosql = new Conexao();
        UsuarioModelo UsuarioModelo = new UsuarioModelo();
        UsuarioControle Controle = new UsuarioControle();
        int id;
        public CRUDUser()
        {
            InitializeComponent();
        }

        private void dataGridCRUD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveCreate_Click_1(object sender, EventArgs e)
        {


            UsuarioModelo.NomeUser = txtNome.Text;
            UsuarioModelo.SenhaUser = txtSenha.Text;

            if (txtNome.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                if (Controle.Cadastrar(UsuarioModelo) >= 1)
                {
                    MessageBox.Show("Usuário Cadastrado.");
                    CRUDUser fadmincrud = new CRUDUser();
                    this.Hide();
                    fadmincrud.Show();
                    dataGridCRUD.Visible = true;
                }

            }
        }

        

        private void SaveUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Selecione o Id do Usuario");
                txtNome.Text = String.Empty;
                txtSenha.Text = String.Empty;
                txtID.Text = String.Empty;
                cbCargo.Text = String.Empty;

            }
            else
            {
                UsuarioModelo.CodUsuario = Convert.ToInt32(txtID.Text);
                UsuarioModelo.NomeUser = txtNome.Text;
                UsuarioModelo.SenhaUser = txtSenha.Text;
                UsuarioModelo.CodCargo = Convert.ToInt32(cbCargo.Text);

                var resposta = DialogResult;
                resposta = MessageBox.Show("Tem certeza que deseja atualizar os dados do usuário?", "! Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    if (Controle.AtualizarUsuario(UsuarioModelo) == true)
                    {
                        MessageBox.Show("Dados Atualizados.");
                    }
                    CRUDUser fadmincrud = new CRUDUser();
                    this.Hide();
                    fadmincrud.Show();
                }
                else if (resposta == DialogResult.No)
                {
                    MessageBox.Show("Processo cancelado.");
                }
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }


        private void btnReturn_Click_2(object sender, EventArgs e)
        {
            AdminMenu fmenureturn = new AdminMenu();
            this.Hide();
            fmenureturn.Show();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtSenha.Text = String.Empty;
            txtID.Text = String.Empty;
            cbCargo.Text = String.Empty;

            dataGridCRUD.Visible = true;

            SaveUpdate.Visible = true;
 
            SaveCreate.Visible = false;


            txtID.Enabled = false;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            cbCargo.Enabled = true;

            txtID.Visible = true;
            txtNome.Visible = true;
            txtSenha.Visible = true;
            cbCargo.Visible = true;

            labelcargo.Visible = true;
            labelid.Visible = true;
            labelnome.Visible = true;
            labelsenha.Visible = true;

            MessageBox.Show("Selecione o ID do Usuario a ser alterado!");
            dataGridCRUD.Focus();
        }

        private void btnCad_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtSenha.Text = String.Empty;
            txtID.Text = String.Empty;
            cbCargo.Text = String.Empty;

            dataGridCRUD.Visible = false;
            txtID.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;

            SaveUpdate.Visible = false;

            SaveCreate.Visible = true;

            txtID.Visible = false;
            txtNome.Visible = true;
            txtSenha.Visible = true;
            cbCargo.Visible = false;

            labelcargo.Visible = false;
            labelid.Visible = false;
            labelnome.Visible = true;
            labelsenha.Visible = true;
        }

        private void btnApaga_Click_1(object sender, EventArgs e)
        {
            dataGridCRUD.Visible = true;

            txtNome.Text = String.Empty;
            txtSenha.Text = String.Empty;
            txtID.Text = String.Empty;
            cbCargo.Text = String.Empty;

            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            cbCargo.Enabled = false;

            cbCargo.Visible = true;
            txtID.Visible = true;
            txtNome.Visible = true;
            txtSenha.Visible = true;

            labelsenha.Visible = true;
            labelcargo.Visible = true;
            labelid.Visible = true;
            labelnome.Visible = true;
            labelsenha.Enabled = true;

            SaveCreate.Visible = false;
            SaveUpdate.Visible = false;


            MessageBox.Show("Selecione o ID do Usuario a ser deletado!");
            dataGridCRUD.Focus();

        }

        private void dataGridCRUD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (dataGridCRUD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridCRUD.CurrentRow.Selected = true;

                    txtID.Text = dataGridCRUD.Rows[e.RowIndex].Cells["idfuncionario"].Value.ToString();
                    txtNome.Text = dataGridCRUD.Rows[e.RowIndex].Cells["NomeUser"].Value.ToString();
                    txtSenha.Text = dataGridCRUD.Rows[e.RowIndex].Cells["SenhaUser"].Value.ToString();
                    cbCargo.Text = dataGridCRUD.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
                }

                else
                {
                    MessageBox.Show("Favor selecionar ID do usuário");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\t    Favor selecionar ID do usuário. \n\nERRO: " + ex.Message);
            }
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            AdminMenu fmenureturn = new AdminMenu();
            this.Hide();
            fmenureturn.Show();
        }

        private void CRUDUser_Load(object sender, EventArgs e)
        {
            dataGridCRUD.DataSource = conexaosql.verDados("SELECT * FROM tb_funcionario");

            SaveUpdate.Visible = false;

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

        private void dataGridCRUD_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Click(object sender, EventArgs e)
        {


        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
