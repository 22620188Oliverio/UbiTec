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
    public partial class OpcionR_1 : Form
    {
        public OpcionR_1()
        {
            InitializeComponent();
            Form3 fr3 = new Form3();
            fr3.Close();
        }

        private void OpcionR_1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Close();
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

        private void btonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btonRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btonMinimizar.Visible = false;
            btonMaximizar.Visible = true;
        }
    }
}
