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
    public partial class AdminMenu : Form
    {
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();

        public AdminMenu(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
            pbFotoAdminMenu.Image = Program.thePictureBox.Image;
        }



        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDPedido fpedidocrud = new CRUDPedido(us, idcliente);
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
            CRUDVeiculo fveiculocrud = new CRUDVeiculo(us, idcliente);
            fveiculocrud.Show();
            Hide();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDEmpresa fcrudemp = new CRUDEmpresa(us, idcliente);
            fcrudemp.Show();
            Hide();
        }

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDMotorista fmotoristacrud = new CRUDMotorista(us, idcliente);
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
                    Principal logout = new Principal(us, idcliente);
                    logout.Show();
                }
            }
            else if (resposta == DialogResult.No)
            {

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AdminLogin freturnlogin = new AdminLogin(us, idcliente);
            freturnlogin.Show();
            Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MapaTeste fmapago = new MapaTeste();
            fmapago.Show();
            Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AdminSolicitacao solicitacaoadm = new AdminSolicitacao();
            this.Hide();
            solicitacaoadm.Show();
        }
    }
}
