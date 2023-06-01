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
    public partial class PedidoFunc : Form
    {
        public PedidoFunc()
        {
            InitializeComponent();
        }

        private void cbAberto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAberto.Checked)
            {
                cbEncerrado.Checked = false;
            }
        }

        private void cbEncerrado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEncerrado.Checked)
            {
                cbAberto.Checked = false;
            }
        }
    }
}
