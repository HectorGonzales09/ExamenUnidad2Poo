using System.ComponentModel.DataAnnotations;

namespace ExamneUnidad2.Dtos.Empleado
{
    public class EmpleadoCreateDto
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(40, ErrorMessage = "Los {0} deben tener un mínimo de {2} y máximo de {1}", MinimumLength = 3)]
        public string Nombre { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(40, ErrorMessage = "Los {0} deben tener un mínimo de {2} y máximo de {1}", MinimumLength = 3)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El DNI es requerido")]
        [StringLength(13, ErrorMessage = "EL DNI debe tener 13 dígitos", MinimumLength = 13)]
        public string DNI { get; set; }
        public DateTime FechaContratacion { get; set; }

        public string Departamento { get; set; }
        public string PuestoTrabajo { get; set; }

        [Display(Name = "SalariO Base")]
        public decimal SalarioBase { get; set; }
    }
}