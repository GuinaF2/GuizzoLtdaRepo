using Controle;
using Microsoft.VisualBasic.Logging;
using Modelos;
using System.Windows.Forms;

namespace GuizzoLtda
{
    public partial class Principal : Form
    {
        OpenFileDialog Abrirfoto;
        Image Foto;
        string caminhofoto = "\\foto";
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();
        public Principal(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;


            InitializeComponent();
            PBEmpresa.Image = Program.thePictureBox.Image;

        }



        private void Principal_Load_1(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);
            MessageBox.Show(idcliente.ToString());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FuncionarioCadLog ffunccad = new FuncionarioCadLog();
            this.Hide();
            ffunccad.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin fadminlog = new AdminLogin(us, idcliente);
            this.Hide();
            fadminlog.Show();
        }

        public void PBEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void btnFotoEmp_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Principal_Activated(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}