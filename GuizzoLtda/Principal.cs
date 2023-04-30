using Microsoft.VisualBasic.Logging;

namespace GuizzoLtda
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

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
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "imagem file |*.png; *.jpg; *.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {

                    PBEmpresa.Image = Image.FromFile(open.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha" + ex.Message);
            }
        }
    }
}