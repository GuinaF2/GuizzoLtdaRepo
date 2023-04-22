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
            UsuarioCadLog fusercad = new UsuarioCadLog();
            this.Hide();
            fusercad.Show();
        }
    }
}