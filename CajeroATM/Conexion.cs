using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CajeroATM
{
    class Conexion
    {
        //Creamos la conexion con la base de datos
        public SqlConnection conexion = new SqlConnection(@"server = (local)\sqlexpress;
        integrated security = true; database = GenesysATM");
        
        public void AbrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Errors + ex.StackTrace + "Error al abrir la conexion");
            }
    
        }
        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Errors + ex.StackTrace + "Error al cerrar la conexion");
            }

        }
    }
}
