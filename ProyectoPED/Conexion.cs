using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED
{
    class Conexion
    {
        readonly string cadena = "Data Source=.;Initial Catalog=prueba; Integrated Security=True";
        public SqlConnection conexion = new SqlConnection();
        //readonly SqlDataReader dr;

        public Conexion()
        {
            conexion.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                conexion.Open();
                //MessageBox.Show("Conexion abierta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public void Cerrar()
        {
            conexion.Close();
            //MessageBox.Show("Conexion cerrada");
        }

        public Boolean Sesion(string usuario, string contrasena)
        {
            SqlCommand s = new SqlCommand("select 1 from dbo.usuarios where usuario = '" + usuario + "' and contrasena = '" + contrasena + "'", conexion);
            return s.ExecuteScalar() != null;
        }
    }
}
