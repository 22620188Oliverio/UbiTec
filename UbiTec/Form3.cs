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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           // diseñoVisible();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

       /* private void diseñoVisible()
        {
            panel1.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }
         
        private void showSubmenu(Panel sub)
        {
            if(panel1.Visible == false)
            {
                hideSubMenu();
                panel1.Visible = true;
            }
            else { panel1.Visible = false; }
        }*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Ubicaciones_Click(object sender, EventArgs e)
        {
            //showSubmenu(panel1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            OpcionI_1 I1 = new OpcionI_1();
            I1.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpcionA_1 A1 = new OpcionA_1();
            
            A1.Show();
            this.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            OpcionB_1 B1 = new OpcionB_1();
            B1.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpcionC_1 C1 = new OpcionC_1();
            C1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpcionD_1 D1 = new OpcionD_1();
            D1.Show();;
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpcionE_1 E1 = new OpcionE_1();
            E1.Show();
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            OpcionF_1 F1 = new OpcionF_1();
            F1.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpcionG1 G1 = new OpcionG1();
            G1.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpcionH1 H1 = new OpcionH1();
            H1.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpcionJ_1 J1 = new OpcionJ_1();
            J1.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpcionK_1 K1 = new OpcionK_1();
            K1.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpcionL_1 L1 = new OpcionL_1();
            L1.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpcionM_1 M1 = new OpcionM_1();
            M1.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpcionN_1 N1 = new OpcionN_1();
            N1.Show();
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OpcionO_1 O1 = new OpcionO_1();
            O1.Show();
            this.Close();   
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpcionP_1 P1 = new OpcionP_1(); 
            P1.Show(); 
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpcionQ_1 Q1 = new OpcionQ_1(); 
            Q1.Show();
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OpcionR_1 R1 = new OpcionR_1(); 
            R1.Show();
            this.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            OpcionS_1 S1 = new OpcionS_1();
            S1.Show();
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {

                Application.Exit();
            }

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
            btonRestaurar.Visible=false;
            btonMaximizar.Visible=true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
