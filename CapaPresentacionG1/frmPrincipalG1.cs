using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacionG1
{
    public partial class frmPrincipalG1 : Form
    {
        public frmPrincipalG1()
        {
            InitializeComponent();
            SubAbrirFormularioG1(new frmInicioG1());
        }

        private void SubAbrirFormularioG1(Form formularioHijo)
        {
            if (pnlContenedorG1.Controls.Count > 0)
                pnlContenedorG1.Controls[0].Dispose();

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedorG1.Controls.Add(formularioHijo);
            pnlContenedorG1.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void btnInicioG1_Click(object sender, EventArgs e) => SubAbrirFormularioG1(new frmInicioG1());
        private void btnAsistenciaG1_Click(object sender, EventArgs e) => SubAbrirFormularioG1(new frmReporteAsistenciaG1());
        private void btnDepartamentosG1_Click(object sender, EventArgs e) => SubAbrirFormularioG1(new frmDepartamentosG1());
        private void btnTurnosG1_Click(object sender, EventArgs e) => SubAbrirFormularioG1(new frmTurnosG1());
        private void btnEmpleadosG1_Click(object sender, EventArgs e) => SubAbrirFormularioG1(new frmEmpleadosG1());

        private void btnCerrarSesionG1_Click(object sender, EventArgs e)
        {
            frmLoginG1 login = new frmLoginG1();
            login.Show();
            this.Close();
        }
    }
}