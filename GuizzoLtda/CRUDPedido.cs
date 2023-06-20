using Controle;
using Modelos;
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
    public partial class CRUDPedido : Form
    {
        Conexao conexaosql = new Conexao();
        MotoristaModelo MotoristaModelo = new MotoristaModelo();
        MotoristaControle Controle = new MotoristaControle();
        int id;
        public CRUDPedido()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void CRUDPedido_Load(object sender, EventArgs e)
        {
            dataGridCRUD.DataSource = conexaosql.verDados("SELECT * FROM tb_motorista");
        }
    }
}
