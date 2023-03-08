using Sistema2.modelos;
using Sistema2.modelos.bodyClass;
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
        newUser newUser = new newUser();   

        spicServices spic=new spicServices();

        public NuevoUser()
        {
            InitializeComponent();
            txtPassword.Text = spic.ramdonPassword();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            newUser.username=txtNombres.Text+" "+txtApellidoPaterno.Text+" "+txtApellidoMaterno.Text;
            newUser.nombres = txtNombres.Text;
            newUser.apellidoPaterno = txtApellidoPaterno.Text;
            newUser.apellidoMaterno = txtApellidoMaterno.Text;
            newUser.email = txtEmail.Text;
            newUser.password=txtPassword.Text;
            newUser.dependencia = txtDependencia.Text;
            newUser.scope = tpUsuario();
            spic.nuevoUsuario(newUser);
            limpiarCampos();
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text=spic.ramdonPassword();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
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
