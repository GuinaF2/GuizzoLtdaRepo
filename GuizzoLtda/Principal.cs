using Microsoft.VisualBasic.Logging;

namespace GuizzoLtda
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminCadLog fadmincad = new AdminCadLog();
            this.Hide();
            fadmincad.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FuncionarioCadLog ffunccad = new FuncionarioCadLog();
            this.Hide();
            ffunccad.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}