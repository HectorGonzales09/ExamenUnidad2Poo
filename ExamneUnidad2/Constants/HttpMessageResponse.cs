using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenUnidad2Poo.Constants
{
    public class HttpMessageResponse
    {
        public const string REGISTER_NOT_FOUND = "Registro no encontrado.";
        public const string REGISTER_FOUND = "Registro encontrado.";
        public const string REGISTER_CREATED = "Registro creado correctamente.";
        public const string REGISTER_UPDATED = "Registro editado correctamente.";
        public const string REGISTER_DELETED = "Registro eliminado correctamente.";
        public const string REGISTERS_FOUND = "Registros encontrados.";

        
        public const string DNI_DUPLICADO = "Ya existe un empleado con ese numero de DNI";
        

        public const string PERIODO_DUPLICADO = "Ya existe una planilla para ese periodo.";
        public const string PLANILLA_PAGADA_NO_ELIMINAR = "No se puede eliminar una planilla con estado 'Pagada'.";
        public const string PLANILLA_GENERADA = "Planilla generada automáticamente para todos los empleados activos.";
        public const string ESTADO_ACTUALIZADO = "Estado de la planilla actualizado correctamente.";
        public const string NO_EMPLEADOS_ACTIVOS = "No hay empleados activos para generar la planilla.";

        
        public const string VALORES_NEGATIVOS = "Los montos deben ser valores positivo";
    }
}