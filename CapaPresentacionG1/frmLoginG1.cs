using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacionG1
{
    public partial class frmLoginG1 : Form
    {
        
        private Image imagenLogoG1 = null;

        public frmLoginG1()
        {
            InitializeComponent();
            this.AcceptButton = btnIniciarSesionG1; // Enter ejecuta el botón
            SubAplicarEstiloG1();
            SubCargarImagenesG1();
            
        }

        private void SubAplicarEstiloG1()
        {
            // Fondo del formulario (negro profundo)
            this.BackColor = ColorTranslator.FromHtml("#0A0A0A");

            // Títulos (dorado)
            lblTituloG1.BackColor = Color.Transparent;
            lblTituloG1.ForeColor = ColorTranslator.FromHtml("#D4AF37");
            lblTituloG1.Font = new Font("Segoe UI", 20, FontStyle.Bold);



            // Labels (dorado)
            lblUsuarioG1.BackColor = Color.Transparent;
            lblUsuarioG1.ForeColor = ColorTranslator.FromHtml("#D4AF37");
            lblUsuarioG1.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            lblContrasenaG1.BackColor = Color.Transparent;
            lblContrasenaG1.ForeColor = ColorTranslator.FromHtml("#D4AF37");
            lblContrasenaG1.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // TextBox (fondo oscuro, texto blanco)
            txtUsuarioG1.BackColor = ColorTranslator.FromHtml("#1A1A1A");
            txtUsuarioG1.ForeColor = Color.White;
            txtUsuarioG1.BorderStyle = BorderStyle.FixedSingle;
            txtUsuarioG1.Font = new Font("Segoe UI", 11);

            txtContrasenaG1.BackColor = ColorTranslator.FromHtml("#1A1A1A");
            txtContrasenaG1.ForeColor = Color.White;
            txtContrasenaG1.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenaG1.Font = new Font("Segoe UI", 11);

            // Botón (dorado con texto negro)
            btnIniciarSesionG1.BackColor = ColorTranslator.FromHtml("#D4AF37");
            btnIniciarSesionG1.ForeColor = Color.Black;
            btnIniciarSesionG1.FlatStyle = FlatStyle.Flat;
            btnIniciarSesionG1.FlatAppearance.BorderSize = 0;
            btnIniciarSesionG1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void SubCargarImagenesG1()
        {
            // Ruta de la carpeta icon
            string rutaIconos = Path.Combine(Application.StartupPath, "icon");

            // Cargar logo (sinfondo.png)
            string rutaLogo = Path.Combine(rutaIconos, "sinfondo.png");
            if (File.Exists(rutaLogo))
            {
                imagenLogoG1 = Image.FromFile(rutaLogo);
                picLogoG1.Image = imagenLogoG1;
                picLogoG1.SizeMode = PictureBoxSizeMode.Zoom;
                picLogoG1.BackColor = Color.Transparent;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo sinfondo.png en: " + rutaLogo,
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Cargar icono de usuario (iconUsuarioG1)
            string rutaUsuario = Path.Combine(rutaIconos, "icono_usuario.png");
            if (File.Exists(rutaUsuario))
            {
                iconUsuarioG1.Image = Image.FromFile(rutaUsuario);
                
                iconUsuarioG1.SizeMode = PictureBoxSizeMode.Zoom;
                iconUsuarioG1.BackColor = Color.Transparent;
            }

            // Cargar icono de contraseña (iconContrasenaG1)
            string rutaContrasena = Path.Combine(rutaIconos, "icono_lock.png");
            if (File.Exists(rutaContrasena))
            {
                iconContrasenaG1.Image = Image.FromFile(rutaContrasena);
                iconContrasenaG1.SizeMode = PictureBoxSizeMode.Zoom;
                iconContrasenaG1.BackColor = Color.Transparent;
            }
        }




        private Image SubAjustarOpacidadG1(Image imagen, double opacidad)
        {
            Bitmap bmp = new Bitmap(imagen.Width, imagen.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = (float)opacidad;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(imagen, new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        private void btnIniciarSesionG1_Click(object sender, EventArgs e)
        {
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