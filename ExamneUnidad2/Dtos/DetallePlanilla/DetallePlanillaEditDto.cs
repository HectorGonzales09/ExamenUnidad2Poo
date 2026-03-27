using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamneUnidad2.Dtos.DetallePlanilla
{
    public class DetallePlanillaEditDto 
    {
        [Display(Name = "Salario Base")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El {0} debe ser un valor positivo")]
        public decimal SalarioBase { get; set; }
        
        [Display(Name = "Horas Extra")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El {0} debe ser un valor positivo")]
        public decimal HorasExtra { get; set; }

        [Display(Name = "Monto Horas Extra")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El {0} debe ser un valor positivo")]
        public decimal MontoHorasExtra { get; set; }
        
        [Display(Name = "Bonificaciones")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El {0} debe ser un valor positivo")]
        public decimal Bonificaciones { get; set; }
       
        [Display(Name = "Deducciones")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El {0} debe ser un valor positivo")]
        public decimal Deducciones { get; set; }
        public string Comentarios { get; set; }
    }
}