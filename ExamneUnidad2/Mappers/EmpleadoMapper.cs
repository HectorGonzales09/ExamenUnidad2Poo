using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamneUnidad2.Dtos.Empleado;
using ExamneUnidad2.Entities;

namespace ExamneUnidad2.Mappers
{
    public class EmpleadoMapper
    {
        public static EmpleadoEntity CreateDtoToEntity(EmpleadoCreateDto dto) => new EmpleadoEntity
        {
            Id = Guid.NewGuid().ToString(),
            Nombre = dto.Nombre,
            Apellido = dto.Apellido,
            DNI = dto.DNI,
            FechaContratacion = dto.FechaContratacion,
            Departamento = dto.Departamento,
            PuestoTrabajo = dto.PuestoTrabajo,
            SalarioBase = dto.SalarioBase,
            Activo = true,
        };

        public static EmpleadoEntity EditDtoToEntity(EmpleadoEntity entity, EmpleadoEditDto dto)
        {
            entity.Nombre = dto.Nombre;
            entity.Apellido = dto.Apellido;
            entity.DNI = dto.DNI;
            entity.FechaContratacion = dto.FechaContratacion;
            entity.Departamento = dto.Departamento;
            entity.PuestoTrabajo = dto.PuestoTrabajo;
            entity.SalarioBase = dto.SalarioBase;
            entity.Activo = dto.Activo;

            return entity;
        }

        public static EmpleadoDto EntityToDto(EmpleadoEntity entity)
        {
            return new EmpleadoDto
            {
                Nombre = entity.Nombre,
                Apellido = entity.Apellido,
                DNI = entity.DNI,
                FechaContratacion = entity.FechaContratacion,
                Departamento = entity.Departamento,
                PuestoTrabajo = entity.PuestoTrabajo,
                SalarioBase = entity.SalarioBase,
                Activo = entity.Activo
            };
        }

        public static List<EmpleadoDto> ListEntityToListDto(List<EmpleadoEntity> entities)
        {
            return entities.Select(e => EntityToDto(e)).ToList();
        }
    }
}