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
    public partial class Menu : Form
    {
        spicServices spic = new spicServices();

        public Menu()
        {
            InitializeComponent();
            panelSpic.Visible = false;
            panelUsuarios.Visible = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnPanelSp_Click(object sender, EventArgs e)
        {
            if (panelSpic.Visible == false)
            {
                panelSpic.Visible = true;
            }
            else
            {
                panelSpic.Visible = false;
            }
        }

        private void btnPanelUsers_Click(object sender, EventArgs e)
        {
            Console.WriteLine(spic.tokenAcceso);
            if (panelUsuarios.Visible==false)
            {
                panelUsuarios.Visible=true;
            }
            else
            {
                panelUsuarios.Visible=false;
            }
        }
    }
}
