using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamneUnidad2.Dtos.Empleado
{
    public class EmpleadoEditDto : EmpleadoCreateDto
    {
        public bool Activo { get; set; }
    }
}