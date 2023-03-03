using s2_services.models;
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
        spicServices spicService=new spicServices();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Spic spic=new Spic();
            bool acceso = spicService.Login("Brandon Jared Ruiz Diaz", "12345678");// pal login
            if (acceso)
            {
                MessageBox.Show("Acceso Correcto");
                spicService.GetAllSpic();///pa calar este metodo una vez obtenido el tokenzzzzz
                spic.fechaCaptura = DateTime.Now;
                spic.ejercicioFiscal = "nose xf";
                spic.rfc = "sdasdadescurpdeimpuestos";
                spic.curp = "curpnormal";
                spic.nombres = "sasasass";
                spic.primerApellido = "1apell";
                spic.segundoApellido = "2apell";
                spicService.nuevoServidor(spic); ////pues funciona xd i

            }
            else
            {
                 MessageBox.Show("troleado");
            }

           
        }
    }
}
