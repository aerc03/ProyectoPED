using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED
{
    class Conexion
    {
        readonly string cadena = "Server=DESKTOP-RD5467U\\SQLEXPRESS;Database=Proyecto;Trusted_Connection=True;";
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
            SqlCommand s = new SqlCommand("select 1 from usr_usuario where usr_username = '" + usuario + "' and usr_contra = '" + contrasena + "'", conexion);
            return s.ExecuteScalar() != null;
        }
    }
}
