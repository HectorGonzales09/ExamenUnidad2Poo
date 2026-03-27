using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamneUnidad2.Dtos.DetallePlanilla
{
    public class DetallePlanillaDto
    {
        public int Id { get; set; }
        public int Planilla { get; set; }
        public string PeriodoPlanilla { get; set; }
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