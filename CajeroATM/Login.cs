using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CajeroATM
{
    public partial class Login : Form
    {
        //Creamos el objeo de conexion 
        Conexion conn = new Conexion();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio fm = new Inicio();
            this.Hide();
            fm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sqlSelect = ("Select *from ATM.TarjetasCliente where Numero = '" + txtNumTarjeta.Text + "' and Pin = '" + txtPin.Text + "'");

            //creamos el comando 
            SqlCommand cmd = new SqlCommand(sqlSelect,conn.conexion);
            conn.AbrirConexion();
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                MenuOpciones menu = new MenuOpciones();
                this.Hide();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Numero de tarjeta o pin incorrectos, favor verifique nuevamente");
            }
            conn.CerrarConexion();
        }

        private void txtNumTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                // Se despliega mensaje en caso de que el usuario ingrese letras
                MessageBox.Show("No se permiten letras");
                e.Handled = true;
            }*/
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else{
                //Se despliega mensaje en caso de que el usuario ingrese letras
                MessageBox.Show("No se permiten letras");
            }

        }
        /*mandar informacion de aqui al fomulario retiro
            Lempiras lemp = new Lempiras();
            lemp.enviado += new Lempiras.enviar(ejecutar);
            lemp.ShowDialog();
        public void ejecutar(string datos)
        {
            txtNumTarjeta.Text = datos;
        }*/
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumTarjeta.Clear();
            txtPin.Clear();
        }

        private void txtNumTarjeta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
