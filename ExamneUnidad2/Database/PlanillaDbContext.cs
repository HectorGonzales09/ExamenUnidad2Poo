using ExamneUnidad2.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamneUnidad2.Database
{
    public class PlanillaDbContext : DbContext
    {
        public DbSet<EmpleadoEntity> Empleados { get; set; }
        public DbSet<PlanillaEntity> Planillas { get; set; }
        public DbSet<DetallePlanillaEntity> DetallePlanillas { get; set; }
    }
}