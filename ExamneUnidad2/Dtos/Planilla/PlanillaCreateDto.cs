using System.ComponentModel.DataAnnotations;

namespace ExamneUnidad2.Dtos.Planilla
{
    public class PlanillaCreateDto
    {   
        [Display(Name = "Periodo")]
        [Required(ErrorMessage = "El periodo es requerido")]
        [StringLength(40, ErrorMessage = "El {0} debe tener máximo {1} caracteres")]
        public string Periodo { get; set; }
        public DateTime FechaPago { get; set; }
    }
}