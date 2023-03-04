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
    public partial class Login : Form
    {
        spicServices spicServices=new spicServices();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           bool log= spicServices.Login(txtUserName.Text,txtPassword.Text);
            if (log)
            {
                Menu menu = new Menu();
                MessageBox.Show("Acceso correcto");
                menu.Show();
                spicServices.getScopes();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
