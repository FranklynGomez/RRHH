using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class FORM_RRHH
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string EMAIL { get; set; }
        public string TELEFONO { get; set; }
        public string IDENTIFICACION { get; set; }
        public string GENERO { get; set; }
        public DateTime FECHA_NACIMIENTO { get; set; }
        public string REFERENCIA { get; set; }
        public int NIVEL_INGLES { get; set; }
        public string DIRECCION { get; set; }
        public int ULTIMO_SALARIO { get; set; }
        public int SALARIO_MINIMO { get; set; }
        public DateTime FEC_TRA { get; set; }

    }
}
