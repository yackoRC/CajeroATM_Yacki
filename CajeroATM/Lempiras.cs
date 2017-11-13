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
    public partial class Lempiras : Form
    {
        Conexion conn = new Conexion();
        /*public delegate void enviar(string dato);
        public event enviar enviado;*/
        
        public Lempiras()
        {
            InitializeComponent();
        }

        private void Lempiras_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio fm = new Inicio();
            this.Hide();
            fm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MenuOpciones menu = new MenuOpciones();
            this.Hide();
            menu.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crear el comando con el procedimiento
            SqlCommand cmd = new SqlCommand("TarjetasCliente.SP_RetiroLemp", conn.conexion);

            //Establecer el comando como stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                //parametros 
                cmd.Parameters.Add(new SqlParameter("Cantidad", SqlDbType.Float, 12));
                cmd.Parameters["Cantidad"].Value = txtcantidad.ToString();
                cmd.Parameters.Add(new SqlParameter("Pin", SqlDbType.Int));
                cmd.Parameters["Pin"].Value = txtPiN.ToString();

                //abrir la conexion
                conn.AbrirConexion();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Ud retiro su dinero correctamente");
            }
            catch (SqlException ex)
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
