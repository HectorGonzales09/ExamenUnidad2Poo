using ExamneUnidad2.Dtos.Common;
using ExamneUnidad2.Dtos.Planilla;

namespace ExamneUnidad2.Services.Planilla
{
    public interface IPlanillaService
    {
        Task<ResponseDto<PageDto<List<PlanillaDto>>>> GetPageAsync(int page = 1, int pageSize = 10);
        Task<ResponseDto<PlanillaDto>> GetOneByIdAsync(string id);
        Task<ResponseDto<List<PlanillaDto>>> GetByPeriodoAsync(string periodo);
        Task<ResponseDto<PlanillaActionResponseDto>> CreateAsync(PlanillaCreateDto dto);
        Task<ResponseDto<PlanillaActionResponseDto>> EditAsync(string id, PlantillaEditDto dto);
        Task<ResponseDto<PlanillaActionResponseDto>> DeleteAsync(string id);
        Task<ResponseDto<PlanillaActionResponseDto>> UpdateEstadoAsync(string id, PlatillaEstadoDto dto);
        Task<ResponseDto<PlanillaDto>> GenerarPlanillaAsync(PlanillaCreateDto dto);
    }
}