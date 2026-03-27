using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamneUnidad2.Dtos.Common;
using ExamneUnidad2.Dtos.DetallePlanilla;

namespace ExamneUnidad2.Services.DetallePlanilla
{
    public interface IDetallePlanilla
    {
        Task<ResponseDto<List<DetallePlanillaDto>>> GetByPlanillaIdAsync(string planillaId);
        Task<ResponseDto<List<DetallePlanillaDto>>> GetByEmpleadoIdAsync(string empleadoId);
        Task<ResponseDto<DetallePlanillaDto>> GetOneByIdAsync(string id);
        Task<ResponseDto<DetallePlanillaActionResponseDto>> CreateAsync(DetalleCreatePlanillaDto dto);
        Task<ResponseDto<DetallePlanillaActionResponseDto>> EditAsync(string id, DetallePlanillaEditDto dto);
        Task<ResponseDto<DetallePlanillaActionResponseDto>> DeleteAsync(string id);
    }
}