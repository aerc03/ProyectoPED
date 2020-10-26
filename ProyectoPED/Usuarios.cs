using ProyectoPED.Controladores;
using ProyectoPED.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        UsuariosC Control = new UsuariosC();

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Control.Consultar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            UsuarioM Modelo = new UsuarioM();
            Modelo.Username = txtUserName.Text;
            Modelo.Contra = txtUserName.Text;
            Modelo.Nivel = Convert.ToBoolean(txtNivel.Text);
            Modelo.Nombres = txtNombres.Text;
            Modelo.Apellidos = txtApellidos.Text;
            Modelo.NombresApellidos = txtUserName.Text + " " + txtApellidos.Text;
            Modelo.Correo = txtCorreo.Text;
            Control.Guardar(Modelo);
            //dgvUsuarios.Rows.Clear();
            dgvUsuarios.DataSource = Control.Consultar();
        }
    }
}
