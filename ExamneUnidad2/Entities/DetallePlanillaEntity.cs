using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ExamneUnidad2.Entities
{
    public class DetallePlanillaEntity
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public int Planilla { get; set; }
        [Key]
        public int EmpleadoId { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal HorasExtra { get; set; }
        public decimal MontoHorasExtra { get; set; }
        public decimal Bonificaciones { get; set; }
        public decimal Deducciones { get; set; }
        public decimal SalarioNeto { get; set; }
        public string Comentarios { get; set; }
    }
}