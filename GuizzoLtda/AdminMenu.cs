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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void abrirPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDUser fadmcrud = new CRUDUser();
            fadmcrud.Show();
            Hide();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoFunc ffuncpedid = new PedidoFunc();
            ffuncpedid.Show();
            Hide();
        }
    }
}
