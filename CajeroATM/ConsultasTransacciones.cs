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
    public partial class ConsultasTransacciones : Form
    {
        public ConsultasTransacciones()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            // Query
            string sql = @"SELECT * FROM ATM.Configuracion";

            // Crear la conexión
            Conexion conn = new Conexion(); ;

            try
            {
                // Crear el DataAdapter
                SqlDataAdapter sqlAD = new SqlDataAdapter();
                sqlAD.SelectCommand = new SqlCommand(sql, conn.conexion);

                // Abrir la conexión
                conn.AbrirConexion();

                // Crear y llenar el DataSet
                DataSet dataS = new DataSet();
                sqlAD.Fill(dataS, "Production.Product");

                // Extraer el dataset a un archivo XML
                dataS.WriteXml(@"C:\Users\Yacki R. Carrillo\Desktop\productos.xml");
                MessageBox.Show("El archivo se creo de manera correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Información");
            }
            finally
            {
                // Cerrar la conexión
                conn.CerrarConexion();
            }
  
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MenuOpciones menu = new MenuOpciones();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
