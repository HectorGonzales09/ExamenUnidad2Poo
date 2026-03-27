using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamneUnidad2.Dtos.Planilla
{
    public class PlanillaDto
    {
        public string Id { get; set; }
        public string Periodo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPago { get; set; }
        public string Estado { get; set; }
        public int TotalEmpleados { get; set; }
        public decimal TotalNeto { get; set; }
    }
}