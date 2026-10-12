using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CapaAccesoDatosG1;



namespace CapaPresentacionG1
{
    public partial class frmInicioG1 : Form
    {
        public frmInicioG1()
        {
            InitializeComponent();
            SubCargarDatosInicioG1();
        }

        private void btnMarcarAsistenciaG1_Click(object sender, EventArgs e)
        {
            frmReporteAsistenciaG1 reporte = new frmReporteAsistenciaG1();
            reporte.ShowDialog();
            SubCargarDatosInicioG1();
        }

        private void SubCargarDatosInicioG1()
        {
            
        }
    }
}