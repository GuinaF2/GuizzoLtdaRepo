using Microsoft.VisualBasic.Logging;

namespace GuizzoLtda
{
    public partial class Principal : Form
    {
        OpenFileDialog Abrirfoto;
        Image Foto;
        string caminhofoto= "\\foto";

        public Principal()
        {
            InitializeComponent();
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

        private void PBEmpresa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFotoEmp_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadEmpresa fcadastroemp = new CadEmpresa();
            this.Hide();
            fcadastroemp.Show();
        }
    }
}