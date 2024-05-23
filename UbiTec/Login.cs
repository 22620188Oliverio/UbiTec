using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UbiTec
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            try
            {
                Control ctrl = new Control();
                string respuesta = ctrl.ctrlLogin(usuario, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Form1 frm = new Form1();
                    frm.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro frmReg = new Registro();

            frmReg.Show();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }

        //Metodopara poder mover la barra del panel principal del titulo a diferentes lugares

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btonMaximizar.Visible = false;
            btonRestaurar.Visible = true;
        }

        private void btonMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btonRestaurar.Visible = false;
            btonMaximizar.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
