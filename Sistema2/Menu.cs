using Sistema2.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema2
{
    public partial class Menu : Form
    {
        spicServices spic = new spicServices();

        public Menu()
        {
            InitializeComponent();
            initialDesing();
            var timer = new System.Timers.Timer(TimeSpan.FromMinutes(1).TotalMilliseconds); // se ejecutara cada 3 minutos
            timer.Elapsed += async (sender, e) => {
                spic.actualizarSesion();
            };
            timer.Start();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            openChildForm(new PantallaInicio());
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void initialDesing()
        {
            panelSpic.Visible=false;
            panelUsuarios.Visible=false;
        }

        private void btnPanelSp_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSpic);
        }

        private void btnPanelUsers_Click(object sender, EventArgs e)
        {
            
            if (spic.getScopes().Length==2 && spic.getScopes()[1] == "Admin") {
                showSubMenu(panelUsuarios);
            }
            else
            {
                MessageBox.Show("Solo usuarios Administradores pueden acceder");
            }
        }

        private void hideSubMenu()
        {
            if (panelSpic.Visible == true)
                panelSpic.Visible = false;
            if (panelUsuarios.Visible == true)
                panelUsuarios.Visible=false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }else
                submenu.Visible = false;
        }

        private Form activeForm = null;

        private void openChildForm(Form form)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock= DockStyle.Fill;
            panelContenedor.Controls.Add(form);
            panelContenedor.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaInicio());
        }

        private void btnPNU_Click(object sender, EventArgs e)
        {
            openChildForm(new NuevoUser());
        }

        private void btnCargarD_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            spic.logout();
            Login log=new Login();
            log.Show();
            this.Hide();
        }

        private void btnBuscarSp_Click(object sender, EventArgs e)
        {
            openChildForm(new spicForm());
        }

        private void btnAgregarSP_Click(object sender, EventArgs e)
        {
            openChildForm(new nuevoSp());
        }
    }
}
