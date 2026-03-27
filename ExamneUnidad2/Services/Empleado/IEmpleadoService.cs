using ExamneUnidad2.Dtos.Common;
using ExamneUnidad2.Dtos.Empleado;

namespace ExamneUnidad2.Services.Empleado
{
    public interface IEmpleadoService
    {
        Task<ResponseDto<PageDto<List<EmpleadoDto>>>> GetPageAsync(string searchTerm = "", int page = 1, int pageSize = 10);
        Task<ResponseDto<List<EmpleadoDto>>> GetActivosAsync();
        Task<ResponseDto<EmpleadoDto>> GetOneByIdAsync(string id);
        Task<ResponseDto<EmpleadoActionResponseDto>> CreateAsync(EmpleadoCreateDto dto);
        Task<ResponseDto<EmpleadoActionResponseDto>> EditAsync(string id, EmpleadoEditDto dto);
        Task<ResponseDto<EmpleadoActionResponseDto>> DeleteAsync(string id);
    }
}