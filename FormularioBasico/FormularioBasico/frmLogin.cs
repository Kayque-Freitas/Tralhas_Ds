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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string User = "admin";
            int Pass = 123456789;

            User = txtuser.Text;
            Pass = Convert.ToInt32(txtsenha.Text);

            if (User == "admin" & Pass == 123456789)
            {
                MessageBox.Show("Logado com sucesso!");
                frmCliente abrir = new frmCliente();
                abrir.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario ou senha incorretos!");
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtsenha.Clear();
            txtuser.Clear();
        }
    }
}
