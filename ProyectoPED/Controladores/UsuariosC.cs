using ProyectoPED.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Controladores
{
    class UsuariosC
    {
        //List<UsuarioM> lista = new List<UsuarioM>();
        Conexion cn = new Conexion();

        public void Guardar(UsuarioM Modelo)
        {
            //lista.Add(Modelo);
            string query = "INSERT INTO [dbo].[usr_usuario]([usr_username],[usr_contra],[usr_nivel],[usr_nombres],[usr_apellidos],[usr_nombres_apellidos],[usr_email]) VALUES (@user,@con,@niv,@nom,@ape,@nap,@cor)";
            cn.Abrir();
            SqlCommand insert = new SqlCommand(query, cn.conexion);
            insert.Parameters.AddWithValue("@user", Modelo.Username);
            insert.Parameters.AddWithValue("@con", Modelo.Contra);
            insert.Parameters.AddWithValue("@niv", Modelo.Nivel);
            insert.Parameters.AddWithValue("@nom", Modelo.Nombres);
            insert.Parameters.AddWithValue("@ape", Modelo.Apellidos);
            insert.Parameters.AddWithValue("@nap", Modelo.NombresApellidos);
            insert.Parameters.AddWithValue("@cor", Modelo.Correo);
            insert.ExecuteNonQuery();
        }

        public DataTable Consultar()
        {
            SqlCommand select = new SqlCommand("select usr_codigo Codigo, usr_username UserName, case when usr_nivel = 1 then 'admin' else 'cliente' end Tipo, usr_nombres_apellidos Nombre, usr_email Correo from usr_usuario", cn.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = select;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
    }
}
