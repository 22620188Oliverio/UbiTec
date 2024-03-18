using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UbiTec
{
    public partial class OpcionQ_1 : Form
    {
        public OpcionQ_1()
        {
            InitializeComponent();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btonMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btonMaximizar.Visible = false;
            btonMinimizar.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btonRestaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btonMinimizar.Visible = false;
            btonMaximizar.Visible = true;
        }

        private void btonMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
