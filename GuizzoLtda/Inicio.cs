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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2Obj = new SelecionarEmpresa();
            form2Obj.Shown += (o, args) => { btnAcessarSys.Enabled = false; };
            form2Obj.FormClosed += (o, args) => { btnAcessarSys.Enabled = true; };
            form2Obj.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnAcessarSys_Click(object sender, EventArgs e)
        {
            Principal fcomeco = new Principal();
            this.Hide();
            fcomeco.Show();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnAcessarSys_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_Leave(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
