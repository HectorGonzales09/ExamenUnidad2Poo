using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamneUnidad2.Dtos.Common;
using ExamneUnidad2.Dtos.Planilla;

namespace ExamneUnidad2.Services.Planilla
{
    public class PlanillaService : IPlanillaService
    {
        public Task<ResponseDto<PlanillaActionResponseDto>> CreateAsync(PlanillaCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<PlanillaActionResponseDto>> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<PlanillaActionResponseDto>> EditAsync(string id, PlantillaEditDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<PlanillaDto>> GenerarPlanillaAsync(PlanillaCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<PlanillaDto>>> GetByPeriodoAsync(string periodo)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<PlanillaDto>> GetOneByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<PageDto<List<PlanillaDto>>>> GetPageAsync(int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<PlanillaActionResponseDto>> UpdateEstadoAsync(string id, PlatillaEstadoDto dto)
        {
            throw new NotImplementedException();
        }
    }
}