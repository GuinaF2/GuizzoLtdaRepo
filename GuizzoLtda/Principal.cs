using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;

namespace GuizzoLtda
{
    public partial class Principal : Form
    {
        OpenFileDialog Abrirfoto;
        Image Foto;
        string caminhofoto = "\\foto";

        public Principal()
        {
            InitializeComponent();
            PBEmpresa.Image = Program.thePictureBox.Image;

        }



        private void Principal_Load_1(object sender, EventArgs e)
        {
       
        }

        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            FuncionarioCadLog ffunccad = new FuncionarioCadLog();
            this.Hide();
            ffunccad.Show();
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            AdminLogin fadminlog = new AdminLogin();
            this.Hide();
            fadminlog.Show();
        }

        public void PBEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void btnFotoEmp_Click(object sender, EventArgs e)
        {
            SelecionarEmpresa fselecemp = new SelecionarEmpresa();
            this.Hide();
            fselecemp.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadEmpresa fcadastroemp = new CadEmpresa();
            this.Hide();
            fcadastroemp.Show();
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
           
        }
    }
}