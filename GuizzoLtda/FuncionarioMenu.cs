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
    public partial class FuncionarioMenu : Form
    {
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();
        public FuncionarioMenu(EmpresaModelo um, int id)
        {

            us = um;
            idcliente = id;
            InitializeComponent();
            pbFotoMenuFunc.Image = Program.thePictureBox.Image;
        }


        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            VerificarEmp fempresaver = new VerificarEmp(us, idcliente);
            this.Hide();
            fempresaver.Show();
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            PedidoFunc fpedidofuncionario = new PedidoFunc(us, idcliente);
            this.Hide();
            fpedidofuncionario.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Principal fprincipalreturn = new Principal(us, idcliente);
            this.Hide();
            fprincipalreturn.Show();
        }

        private void FuncionarioMenu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            MapaTeste ftestemapa = new MapaTeste();
            this.Hide();
            ftestemapa.Show();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            FuncionarioSolicit ffuncsoli = new FuncionarioSolicit();
            this.Hide();
            ffuncsoli.Show();
        }

        private void btnVerifyEmp_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarPedi_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {

        }

        

        private void FuncionarioMenu_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
