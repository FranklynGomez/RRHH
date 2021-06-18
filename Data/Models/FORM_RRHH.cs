using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class FORM_RRHH
    {   
        [Key]
        public int ID { get; set; }
        [Required]
        public string NOMBRE { get; set; }
        [Required]
        public string APELLIDO { get; set; }
        [Required]
        public string EMAIL { get; set; }
        [Required]
        public string TELEFONO { get; set; }
        [Required]
        public string IDENTIFICACION { get; set; }
        [Required]
        public string GENERO { get; set; }
        [Required]
        public DateTime FECHA_NACIMIENTO { get; set; }
        [Required]
        public string REFERENCIA { get; set; }
        [Required]
        public int NIVEL_INGLES { get; set; }
        [Required]
        public string DIRECCION { get; set; }
        [Required]
        public int ULTIMO_SALARIO { get; set; }
        [Required]
        public int SALARIO_MINIMO { get; set; }
        [Required]
        public DateTime FEC_TRA { get; set; }

    }
}
