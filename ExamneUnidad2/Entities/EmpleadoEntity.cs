using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamneUnidad2.Entities
{
    public class EmpleadoEntity
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Required]
        [Column("nombre")]
        public string Nombre { get; set; }

        [Required]
        [Column("apellido")]
        public string Apellido { get; set; }
        
        [Required]
        [Column("dni")]
        public string DNI { get; set; }

        [Column("fecha_de:contratación")]
        public DateTime FechaContratacion { get; set; }

        [Column("departamento")]
        public string Departamento { get; set; }

        [Column("puesto_de_trabajo")]
        public string PuestoTrabajo { get; set; }

        [Column("salario_base")]
        public decimal SalarioBase { get; set; }
        public bool Activo { get; set; }
    }
}