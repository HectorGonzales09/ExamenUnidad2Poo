using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamneUnidad2.Dtos.Empleado
{
    public class EmpleadoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string Departamento { get; set; }
        public string PuestoTrabajo { get; set; }
        public decimal SalarioBase { get; set; }
        public bool Activo { get; set; }
    }
}