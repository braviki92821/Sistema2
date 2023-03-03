
using Sistema2.modelos;
using System;
using System.Collections.Generic;

namespace s2_services.models
{
    public class Spic
    { 
        public DateTime fechaCaptura { get; set; }
        public string ejercicioFiscal { get; set; }
        public string rfc { get; set; }
        public string curp { get; set; }
        public string nombres { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public ramo ramo { get; set; }
        public Genero genero { get; set; }
        public institucionDependencia institucionDependencia { get; set; }
        public puesto puesto { get; set; }
        public List<tipoArea> tipoArea { get; set; }
        public List<nivelResponsabilidad> nivelResponsabilidad { get; set; }
        public List<tipoProcedimiento> tipoProcedimiento { get; set; }
        public superiorInmediato superiorInmediato { get; set; }
        public string observaciones { get; set; }

    }
}
