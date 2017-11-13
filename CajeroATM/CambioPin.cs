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
    public partial class CambioPin : Form
    {
        Conexion conn = new Conexion();
        public CambioPin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNtar.Clear();
            txtPIN.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuOpciones menu = new MenuOpciones();
            this.Hide();
            menu.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //crear el comando con el procedimiento
            SqlCommand cmd = new SqlCommand("TarjetasCliente.SP_modificarPin",conn.conexion);

            //Establecer el comando como stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                //parametros 
                cmd.Parameters.Add(new SqlParameter("Numero", SqlDbType.Char, 14));
                cmd.Parameters["Numero"].Value = txtNtar.ToString();
                cmd.Parameters.Add(new SqlParameter("Pin", SqlDbType.Int));
                cmd.Parameters["Pin"].Value = txtPIN.ToString();

                //abrir la conexion
                conn.AbrirConexion();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Pin modificado correctamente");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Informacion" + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                // Cerrar la conexión
                conn.CerrarConexion();
            }
        }
    }
}
