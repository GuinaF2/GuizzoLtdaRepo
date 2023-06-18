﻿using Modelos;
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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            pbFotoAdminMenu.Image = Program.thePictureBox.Image;
        }



        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDPedido fpedidocrud = new CRUDPedido();
            fpedidocrud.Show();
            Hide();
        }

        private void abrirPedidoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CRUDUser fcrudusuario = new CRUDUser();
            fcrudusuario.Show();
            Hide();
        }

        private void toolStripTextBox2_ButtonClick(object sender, EventArgs e)
        {

        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDVeiculo fveiculocrud = new CRUDVeiculo();
            fveiculocrud.Show();
            Hide();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDEmpresa fcrudemp = new CRUDEmpresa();
            fcrudemp.Show();
            Hide();
        }

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDMotorista fmotoristacrud = new CRUDMotorista();
            fmotoristacrud.Show();
            Hide();
        }

        private void pbFotoAdminMenu_Click(object sender, EventArgs e)
        {

        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
            resposta = MessageBox.Show("Tem certeza que deseja sair do sistema?", "! Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                if (resposta == DialogResult.Yes)
                {
                    this.Close();
                    Principal logout = new Principal();
                    logout.Show();
                }
            }
            else if (resposta == DialogResult.No)
            {

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AdminLogin freturnlogin = new AdminLogin();
            freturnlogin.Show();
            Hide();
        }
    }
}
