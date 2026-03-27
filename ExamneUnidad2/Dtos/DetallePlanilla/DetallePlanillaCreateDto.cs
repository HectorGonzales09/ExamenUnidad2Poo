using System.ComponentModel.DataAnnotations;

namespace ExamneUnidad2.Dtos.DetallePlanilla
{
    public class DetalleCreatePlanillaDto
    {
        [Required(ErrorMessage = "El PlanillaId es requerido")]
        public string PlanillaId { get; set; }

        [Required(ErrorMessage = "El empleadoId es requerido")]
        public string EmpleadoId { get; set; }
        
        [Display(Name = "Salario Base")]
        public decimal SalarioBase { get; set; }
        
        [Display(Name = "Horas Extra")]
        public decimal HorasExtra { get; set; }

        [Display(Name = "Monto Horas Extra")]
        public decimal MontoHorasExtra { get; set; }
        
        [Display(Name = "Bonificaciones")]
        public decimal Bonificaciones { get; set; }
       
        [Display(Name = "Deducciones")]
        public decimal Deducciones { get; set; }
        public string Comentarios { get; set; }
    }
}