using s2_services.models;
using Sistema2.modelos.bodyClass;
using Sistema2.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema2
{
    public partial class spicForm : Form
    {
        spicServices spic = new spicServices();
        searchSP sp=new searchSP();
        public spicForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Acciones")
                {

                    MessageBox.Show("dato" + dataGridView1.CurrentRow.Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            sp.nombres=txtNombres.Text;
            sp.primerApellido=txtApellidoPaterno.Text;
            sp.segundoApellido = txtApellidoMaterno.Text;
            sp.institucionDependencia = txtDependencia.Text;   
            foreach (Spic spicdata in spic.GetAllSpic(sp))
            {
                dataGridView1.Rows.Add(spicdata.id, spicdata.fechaCaptura, spicdata.nombres, spicdata.primerApellido, spicdata.segundoApellido, spicdata.institucionDependencia.nombre, spicdata.ejercicioFiscal);
            }
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
            txtDependencia.Text = "";
            dataGridView1.Rows.Clear();
        }
    }
}
