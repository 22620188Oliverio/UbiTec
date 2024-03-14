using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UbiTec
{
    public partial class OpcionA_1 : Form
    {
        public OpcionA_1()
        {
            InitializeComponent();
            Form3 fr3 = new Form3();
            fr3.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void OpcionA_1_Load(object sender, EventArgs e)
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
            this.WindowState = FormWindowState.Maximized;
            btonMaximizar.Visible = false;
            btonRestaurar.Visible = true;
            
        }

        private void btonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btonRestaurar.Visible = false;
            btonMaximizar.Visible = true;
        }

        private void btonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }
    }
}
