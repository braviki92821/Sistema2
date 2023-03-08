using s2_services.models;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Sistema2
{
    public partial class nuevoSp : Form
    {
        Spic spic = new Spic();
        ramo ram = new ramo();
        Genero gen = new Genero();
        institucionDependencia dep = new institucionDependencia();
        puesto puest = new puesto();
        tipoArea tp = new tipoArea();
        nivelResponsabilidad resp = new nivelResponsabilidad();
        tipoProcedimiento proc = new tipoProcedimiento();
        superiorInmediato supe = new superiorInmediato();
        superiorInmediatoPuesto suPuest = new superiorInmediatoPuesto();
        spicServices services = new spicServices();
        public nuevoSp()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "" || txtPrimerApellido.Text == "" || txtSegundoApellido.Text == "")
            {
                MessageBox.Show("nombres o apellidos no proporcionados");
            }
            else
            {
                if (txtNombreDep.Text == "" || txtSiglasDep.Text == "" || txtClaveDep.Text == "" || txtPuesto.Text == "" || txtNivel.Text == ""
                    || txtRamo.Text == "" || txtValorRamo.Text == "")
                {
                    MessageBox.Show("Datos de Institucion o dependencia incompletos");
                }
                else
                {
                    if (txtNombresS.Text=="" || txtPrimerApellidoS.Text=="" || txtSegundoApellidoS.Text=="" || txtPuestoS.Text=="" || txtNivelS.Text=="")
                    {
                        MessageBox.Show("Datos de Superior incompletos o vacios");
                    }
                    else
                    {
                        saveSp();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private string[] Genero()
        {
            string[] genero = new string[] { };
            if (rbtnMasc.Checked)
            {
                genero = new string[] { "M", "MASCULINO" };
            }
            else if (rbtnFem.Checked)
            {
                genero = new string[] { "F", "FEMENINO" };
            }
            else if (rbtnOtro.Checked)
            {
                genero = new string[] { "O", "OTRO" };
            }
            return genero;
        }

        private bool issomeTypeAreaSelected()
        {
            bool marcado = false;
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked
               || checkBox6.Checked)
            {
                marcado = true;
            }
            else
            {
                marcado = false;
            }
            return marcado;
        }
        //retorno de tipoArea
        private List<tipoArea> tipoAreaSelected()
        {
            List<tipoArea> tipoArea = new List<tipoArea>();
            if (tecnica().Length != 0)
            {
                tp.clave = tecnica()[0];
                tp.valor = tecnica()[1];
                tipoArea.Add(tp);
            }
            else if (requirente().Length != 0)
            {
                tp.clave = requirente()[0];
                tp.valor = requirente()[1];
                tipoArea.Add(tp);
            }
            else if (responsableEjec().Length != 0)
            {
                tp.clave = responsableEjec()[0];
                tp.valor = responsableEjec()[1];
                tipoArea.Add(tp);
            }
            else if (responsableCont().Length != 0)
            {
                tp.clave = responsableCont()[0];
                tp.valor = responsableCont()[1];
                tipoArea.Add(tp);
            }
            else if (contratante().Length != 0)
            {
                tp.clave = contratante()[0];
                tp.valor = contratante()[1];
                tipoArea.Add(tp);
            }
            else if (otro().Length != 0)
            {
                tp.clave = otro()[0];
                tp.valor = otro()[1];
                tipoArea.Add(tp);
            }
            return tipoArea;
        }
        //retorno de responsabilidad
        private List<nivelResponsabilidad> nivelResponsabilidadSelected()
        {
            List<nivelResponsabilidad> nivels = new List<nivelResponsabilidad>();
            if (atencion().Length != 0)
            {
                resp.clave = atencion()[0];
                resp.valor = atencion()[1];
                nivels.Add(resp);
            }
            else if (tramitacion().Length != 0)
            {
                resp.clave = tramitacion()[0];
                resp.valor = tramitacion()[1];
                nivels.Add(resp);
            }
            else if (resolucion().Length != 0)
            {
                resp.clave = resolucion()[0];
                resp.valor = resolucion()[1];
                nivels.Add(resp);
            }
            else if (otro().Length != 0)
            {
                resp.clave = otro()[0];
                resp.valor = otro()[1];
                nivels.Add(resp);
            }
            return nivels;
        }
        //retorno de procedimientos
        private List<tipoProcedimiento> tipoProcedimientoSelected()
        {
            List<tipoProcedimiento> tipoProcedimientos = new List<tipoProcedimiento>();
            if (contrataciones().Length != 0)
            {
                proc.clave = int.Parse(contrataciones()[0]);
                proc.valor = contrataciones()[1];
                tipoProcedimientos.Add(proc);
            }
            else if (concesiones().Length != 0)
            {
                proc.clave = int.Parse(concesiones()[0]);
                proc.valor = concesiones()[1];
                tipoProcedimientos.Add(proc);
            }
            else if (enanjenaciones().Length != 0)
            {
                proc.clave = int.Parse(enanjenaciones()[0]);
                proc.valor = enanjenaciones()[1];
                tipoProcedimientos.Add(proc);
            }
            else if (dictamenes().Length != 0)
            {
                proc.clave = int.Parse(dictamenes()[0]);
                proc.valor = dictamenes()[1];
                tipoProcedimientos.Add(proc);
            }
            else if (otroP().Length != 0)
            {
                proc.clave = int.Parse(otroP()[0]);
                proc.valor = otroP()[1];
                tipoProcedimientos.Add(proc);
            }
            return tipoProcedimientos;
        }
        //checksbox de tipoArea
        private string[] tecnica()
        {
            string[] tecnica = new string[] { };
            if (checkBox1.Checked)
            {
                tecnica = new string[] { "T", checkBox1.Text };
            }
            return tecnica;
        }

        private string[] requirente()
        {
            string[] requirente = new string[] { };
            if (checkBox1.Checked)
            {
                requirente = new string[] { "R", checkBox3.Text };
            }
            return requirente;
        }

        private string[] responsableEjec()
        {
            string[] responsableEjec = new string[] { };
            if (checkBox4.Checked)
            {
                responsableEjec = new string[] { "RE", checkBox4.Text };
            }
            return responsableEjec;
        }

        private string[] responsableCont()
        {
            string[] responsableCont = new string[] { };
            if (checkBox5.Checked)
            {
                responsableCont = new string[] { "RC", checkBox5.Text };
            }
            return responsableCont;
        }

        private string[] contratante()
        {
            string[] contratante = new string[] { };
            if (checkBox2.Checked)
            {
                contratante = new string[] { "C", checkBox2.Text };
            }
            return contratante;
        }

        private string[] otro()
        {
            string[] otro = new string[] { };
            if (checkBox6.Checked || checkBox10.Checked)
            {
                otro = new string[] { "O", checkBox6.Text };
            }
            return otro;
        }

        //checksbox de nivel de resposabilidad
        private string[] atencion()
        {
            string[] atencion = new string[] { };
            if (checkBox7.Checked)
            {
                atencion = new string[] { "A", checkBox7.Text };
            }
            return atencion;
        }

        private string[] tramitacion()
        {
            string[] tramitacion = new string[] { };
            if (checkBox8.Checked)
            {
                tramitacion = new string[] { "T", checkBox8.Text };
            }
            return tramitacion;
        }

        private string[] resolucion()
        {
            string[] resolucion = new string[] { };
            if (checkBox9.Checked)
            {
                resolucion = new string[] { "R", checkBox9.Text };
            }
            return resolucion;
        }

        //checksbox de tipo de procedimiento

        private string[] contrataciones()
        {
            string[] contra = new string[] { };
            if (checkBox12.Checked)
            {
                contra = new string[] { "1", checkBox12.Text };
            }
            return contra;
        }

        private string[] concesiones()
        {
            string[] concesiones = new string[] { };
            if (checkBox11.Checked)
            {
                concesiones = new string[] { "2", checkBox11.Text };
            }
            return concesiones;
        }

        private string[] enanjenaciones()
        {
            string[] enaje = new string[] { };
            if (checkBox13.Checked)
            {
                enaje = new string[] { "3", checkBox13.Text };
            }
            return enaje;
        }

        private string[] dictamenes()
        {
            string[] dictamen = new string[] { };
            if (checkBox14.Checked)
            {
                dictamen = new string[] { "4", checkBox14.Text };
            }
            return dictamen;
        }

        private string[] otroP()
        {
            string[] otro = new string[] { };
            if (checkBox15.Checked)
            {
                otro = new string[] { "5", checkBox15.Text };
            }
            return otro;
        }

        private void saveSp()
        {
            spic.id = "";
            spic.fechaCaptura = DateTime.Now;
            spic.ejercicioFiscal = txtEjercicioFiscal.Text;
            spic.rfc = txtRFC.Text;
            spic.curp = txtCURP.Text;
            spic.nombres = txtNombres.Text;
            spic.primerApellido = txtPrimerApellido.Text;
            spic.segundoApellido = txtSegundoApellido.Text;
            ram.clave = int.Parse(txtRamo.Text);
            ram.valor = txtValorRamo.Text;
            gen.clave = Genero()[0];
            gen.valor = Genero()[1];
            dep.nombre = txtNombreDep.Text;
            dep.siglas = txtSiglasDep.Text;
            dep.clave = txtClaveDep.Text;
            puest.nombre = txtPuesto.Text;
            puest.nivel = txtNivel.Text;
            spic.tipoArea = tipoAreaSelected();
            spic.nivelResponsabilidad = nivelResponsabilidadSelected();
            spic.tipoProcedimiento = tipoProcedimientoSelected();
            supe.nombres = txtNombresS.Text;
            supe.primerApellido = txtPrimerApellidoS.Text;
            supe.segundoApellido = txtSegundoApellidoS.Text;
            supe.curp = txtCURPS.Text;
            supe.rfc = txtRFCS.Text;
            suPuest.nombre = txtPuestoS.Text;
            suPuest.nivel = txtNivelS.Text;
            spic.observaciones = "";
            spic.ramo = ram;
            spic.genero = gen;
            spic.institucionDependencia = dep;
            spic.puesto = puest;
            spic.superiorInmediato = supe;
            spic.superiorInmediato.puesto = supe.puesto = suPuest;
            services.nuevoServidor(spic);
        }

        private void txtEjercicioFiscal_Leave(object sender, EventArgs e)
        {
            if (txtEjercicioFiscal.Text == "")
            {
                panel3.BackColor = Color.Red;
            }
            else
            {
                panel3.BackColor = SystemColors.InfoText;
            }
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                panel4.BackColor = Color.Red;
            }
            else
            {
                panel4.BackColor = SystemColors.InfoText;
            }
        }

        private void txtPrimerApellido_Leave(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text == "")
            {
                panel5.BackColor = Color.Red;
            }
            else
            {
                panel5.BackColor = SystemColors.InfoText;
            }
        }

        private void txtSegundoApellido_Leave(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text == "")
            {
                panel6.BackColor = Color.Red;
            }
            else
            {
                panel6.BackColor = SystemColors.InfoText;
            }
        }

        private void txtNombreDep_Leave(object sender, EventArgs e)
        {
            if (txtNombreDep.Text == "")
            {
                panel11.BackColor = Color.Red;
            }
            else
            {
                panel11.BackColor = SystemColors.InfoText;
            }
        }

        private void txtSiglasDep_Leave(object sender, EventArgs e)
        {
            if (txtSiglasDep.Text == "")
            {
                panel9.BackColor = Color.Red;
            }
            else
            {
                panel9.BackColor = SystemColors.InfoText;
            }
        }

        private void txtClaveDep_Leave(object sender, EventArgs e)
        {
            if (txtClaveDep.Text == "")
            {
                panel10.BackColor = Color.Red;
            }
            else
            {
                panel10.BackColor = SystemColors.InfoText;
            }
        }

        private void txtPuesto_Leave(object sender, EventArgs e)
        {
            if (txtPuesto.Text == "")
            {
                panel13.BackColor = Color.Red;
            }
            else
            {
                panel13.BackColor = SystemColors.InfoText;
            }
        }

        private void txtNivel_Leave(object sender, EventArgs e)
        {
            if (txtNivel.Text == "")
            {
                panel12.BackColor = Color.Red;
            }
            else
            {
                panel12.BackColor = SystemColors.InfoText;
            }
        }

        private void txtRamo_Leave(object sender, EventArgs e)
        {
            if (txtRamo.Text == "")
            {
                panel15.BackColor = Color.Red;
            }
            else
            {
                panel15.BackColor = SystemColors.InfoText;
            }
        }

        private void txtValorRamo_Leave(object sender, EventArgs e)
        {
            if (txtValorRamo.Text == "")
            {
                panel14.BackColor = Color.Red;
            }
            else
            {
                panel14.BackColor = SystemColors.InfoText;
            }
        }

        private void txtNombresS_Leave(object sender, EventArgs e)
        {
            if (txtNombresS.Text == "")
            {
                panel19.BackColor = Color.Red;
            }
            else
            {
                panel19.BackColor = SystemColors.InfoText;
            }
        }

        private void txtPrimerApellidoS_Leave(object sender, EventArgs e)
        {
            if (txtPrimerApellidoS.Text == "")
            {
                panel18.BackColor = Color.Red;
            }
            else
            {
                panel18.BackColor = SystemColors.InfoText;
            }
        }

        private void txtSegundoApellidoS_Leave(object sender, EventArgs e)
        {
            if (txtSegundoApellidoS.Text == "")
            {
                panel17.BackColor = Color.Red;
            }
            else
            {
                panel17.BackColor = SystemColors.InfoText;
            }
        }

        private void txtPuestoS_Leave(object sender, EventArgs e)
        {
            if (txtPuestoS.Text == "")
            {
                panel23.BackColor = Color.Red;
            }
            else
            {
                panel4.BackColor = SystemColors.InfoText;
            }
        }

        private void txtNivelS_Leave(object sender, EventArgs e)
        {
            if (txtNivelS.Text == "")
            {
                panel22.BackColor = Color.Red;
            }
            else
            {
                panel22.BackColor = SystemColors.InfoText;
            }
        }

    }
}
