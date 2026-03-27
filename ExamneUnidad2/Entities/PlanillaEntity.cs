using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamneUnidad2.Entities
{
    
    public class PlanillaEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Periodo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPago { get; set; }
        public string Estado { get; set; } 
    }
}