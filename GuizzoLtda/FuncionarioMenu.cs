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
        public FuncionarioMenu()
        {
            InitializeComponent();
            pbFotoMenuFunc.Image = Program.thePictureBox.Image;
        }


        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            VerifyEmp fempresaver = new VerifyEmp();
            this.Hide();
            fempresaver.Show();
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            PedidoFunc fpedidofuncionario = new PedidoFunc();
            this.Hide();
            fpedidofuncionario.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Principal fprincipalreturn = new Principal();
            this.Hide();
            fprincipalreturn.Show();
        }

        private void FuncionarioMenu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {

        }
    }
}
