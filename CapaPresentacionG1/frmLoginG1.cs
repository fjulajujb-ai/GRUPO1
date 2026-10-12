using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacionG1
{
    public partial class frmLoginG1 : Form
    {
        public frmLoginG1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesionG1_Click(object sender, EventArgs e)
        {
            // Validación simple (luego se puede cambiar por consulta a BD)
            if (txtUsuarioG1.Text == "admin" && txtContrasenaG1.Text == "1234")
            {
                frmPrincipalG1 menu = new frmPrincipalG1();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}