using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class EVALUACION_RRHH
    {
        public int ID { get; set; }
        [Required]
        public string EVALUADOR { get; set; }
        [Required]
        public int EVALUADO { get; set; }
        [ForeignKey("EVALUADO")]
        public virtual FORM_RRHH CFORM_RRHH { get; set; }
        [Required]
        public DateTime FEC_EVA { get; set; }
        public string RESUMEN { get; set; }
        [Required]
        public int NOTA { get; set; }
        [Required]
        public string CAT_EVA { get; set; }

    }
}
