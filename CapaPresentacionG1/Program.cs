using System;
using System.Windows.Forms;

namespace CapaPresentacionG1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInicioG1()); // <-- Aquí se define el formulario de inicio
        }
    }
}