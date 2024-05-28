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
using MySql.Data.MySqlClient;


namespace UbiTec
{
    public partial class Sacar_Turno : Form
    {

        public Sacar_Turno()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String num_control = No_Control.Text;
            String carrera = combo_Carrera.Text;


            String sql = "INSERT  INTO alumno(nombre, No_control, carrera) VALUES ('" + nombre + "', '" + num_control + "', '" + carrera + "');";

            MySqlConnection conexionBD = Conexion.getConexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se hizo tiempo de espera");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }finally { conexionBD.Close(); }    

            string mensaje = Cola.Encolar(nombre);
            MessageBox.Show(mensaje);
        }



        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
