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
    public partial class SelecionarEmpresa : Form
    {
        Conexao conexaosql = new Conexao();
        UsuarioModelo UsuarioModelo = new UsuarioModelo();
        UsuarioControle Controle = new UsuarioControle();
        int id;
        public SelecionarEmpresa()
        {
            InitializeComponent();
        }

        private void SelecionarEmpresa_Load(object sender, EventArgs e)
        {
            dgViewSelEmp.DataSource = conexaosql.verDados("SELECT * FROM tb_cliente");
        }

        private void dgViewSelEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgViewSelEmp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (id <= 0)
                {
                    MessageBox.Show("Favor selecionar Empresa");
                }

                else
                {
                    UsuarioModelo = Controle.CarregaUsuario(id);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\t    Favor selecionar ID do usuário. \n\nERRO: " + ex.Message);
            }
        }
    }
}
