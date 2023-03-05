using Sistema2.modelos;
using Sistema2.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema2
{
    public partial class NuevoUser : Form
    {
        user usuario=new user();    

        spicServices spic=new spicServices();
        public NuevoUser()
        {
            InitializeComponent();
            txtPassword.Text = spic.ramdonPassword();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            usuario.usernames=txtNombres.Text+" "+txtApellidoPaterno.Text+" "+txtApellidoMaterno.Text;
            usuario.names = txtNombres.Text;
            usuario.apellidoPater = txtApellidoPaterno.Text;
            usuario.apellidoMater = txtApellidoMaterno.Text;
            usuario.correo = txtEmail.Text;
            usuario.contraseña=txtPassword.Text;
            usuario.institucion = txtDependencia.Text;
            usuario.scopes = tpUsuario();
            spic.nuevoUsuario(usuario);
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text=spic.ramdonPassword();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtEmail.Text = "";
            txtDependencia.Text = "";
        }

        private string[] tpUsuario()
        {
            string[] tp = new string[] { };
            if (rbtnAdministrador.Checked)
            {
                tp = new string[] {"readWrite","Admin"};
            }else if(rbtnUsuario.Checked)
            {
                tp = new string[] { "readWrite"};
            }
            return tp;
        }
    }
}
