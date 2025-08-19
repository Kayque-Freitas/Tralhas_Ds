using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioBasico
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtnome.Clear();
            txtcpf.Clear();
            cbbprofissao.ResetText();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
