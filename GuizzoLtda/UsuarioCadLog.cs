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
    public partial class UsuarioCadLog : Form
    {
        public UsuarioCadLog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionarioCadLog ffunccad = new FuncionarioCadLog();
            this.Hide();
            ffunccad.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaCadLog fempcad = new EmpresaCadLog();
            this.Hide();
            fempcad.Show();
        }
    }
}
