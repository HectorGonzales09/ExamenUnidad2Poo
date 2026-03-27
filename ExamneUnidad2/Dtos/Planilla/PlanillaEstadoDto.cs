using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamneUnidad2.Dtos.Planilla
{
    public class PlatillaEstadoDto
    {
        [Required(ErrorMessage = "El estado es requerido")]
        [RegularExpression("Pendiente|Pagada|Anulada", ErrorMessage = "El estado debe ser Pendiente, Pagado o Anulada")]
        public string Estado { get; set; }
    }
}