using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaCola;


namespace UbiTec
{
    public partial class Sacar_Turno : Form
    {

        public Sacar_Turno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string mensaje = Cola.Encolar(nombre);
            MessageBox.Show(mensaje);
        }

        private void Sacar_Turno_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
