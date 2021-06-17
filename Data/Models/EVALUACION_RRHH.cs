using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class EVALUACION_RRHH
    {
        public int ID { get; set; }
        public string Evaluador { get; set; }
        public int Evaluado { get; set; }
        public DateTime Fec_Eva { get; set; }
        public string Resumen { get; set; }
        public int Nota { get; set; }
        public string Cat_Eva { get; set; }

    }
}
