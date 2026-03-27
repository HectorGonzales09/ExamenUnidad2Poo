using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamenUnidad2Poo.Constants;
using ExamneUnidad2.Database;
using ExamneUnidad2.Dtos.Common;
using ExamneUnidad2.Dtos.Empleado;
using ExamneUnidad2.Mappers;

namespace ExamneUnidad2.Services.Empleado
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly PlanillaDbContext _context;
        private readonly int PAGE_SIZE;
        private readonly int PAGE_SIZE_LIMIT;

        public EmpleadoService(PlanillaDbContext context, IConfiguration configuration)
        {
            _context = context;
            PAGE_SIZE = configuration.GetValue<int>("PageSize");
            PAGE_SIZE_LIMIT = configuration.GetValue<int>("PageSizeLimit");
        }

        public async Task<ResponseDto<PageDto<List<EmpleadoDto>>>> GetPageAsync(string searchTerm = "", int page = 1, int pageSize = 10)
        {
            page = Math.Abs(page);
            pageSize = Math.Abs(pageSize);
            pageSize = pageSize <= 0 ? PAGE_SIZE : pageSize;
            pageSize = pageSize > PAGE_SIZE_LIMIT ? PAGE_SIZE_LIMIT : pageSize;

            int startIndex = (page - 1) * pageSize;

            var query = _context.Empleados.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(e =>
                    (e.Nombre + " " + e.Apellido + " " + e.DNI).Contains(searchTerm));
            }

            int totalRows = await query.CountAsync();

            var entities = await query
                .OrderBy(e => e.Apellido)
                .Skip(startIndex)
                .Take(pageSize)
                .ToListAsync();

            return new ResponseDto<PageDto<List<EmpleadoDto>>>
            {
                StatusCode = HttpStatusCode.Ok,
                Status = true,
                Message = HttpMessageResponse.REGISTERS_FOUND,
                Data = new PageDto<List<EmpleadoDto>>
                {
                    CurrentPage = page == 0 ? 1 : page,
                    PageSize = pageSize,
                    TotalItems = totalRows,
                    TotalPages = (int)Math.Ceiling((double)totalRows / pageSize),
                    Items = EmpleadoMapper.ListEntityToListDto(entities),
                    HasNextPage = startIndex + pageSize < totalRows,
                    HasPreviousPage = page > 1
                }
            };
        }

        public async Task<ResponseDto<List<EmpleadoDto>>> GetActivosAsync()
        {
            var entities = await _context.Empleados
                .Where(e => e.Activo)
                .OrderBy(e => e.Apellido).ThenBy(e => e.Nombre)
                .ToListAsync();

            return new ResponseDto<List<EmpleadoDto>>
            {
                StatusCode = HttpStatusCode.Ok,
                Status = true,
                Message = HttpMessageResponse.REGISTERS_FOUND,
                Data = EmpleadoMapper.ListEntityToListDto(entities)
            };
        }

        public async Task<ResponseDto<EmpleadoDto>> GetOneByIdAsync(string id)
        {
            var entity = await _context.Empleados.FirstOrDefaultAsync(e => e.Id == id);

            if (entity is null)
            {
                return new ResponseDto<EmpleadoDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = HttpMessageResponse.REGISTER_NOT_FOUND
                };
            }

            return new ResponseDto<EmpleadoDto>
            {
                StatusCode = HttpStatusCode.Ok,
                Status = true,
                Message = HttpMessageResponse.REGISTER_FOUND,
                Data = EmpleadoMapper.EntityToDto(entity)
            };
        }

        public async Task<ResponseDto<EmpleadoActionResponseDto>> CreateAsync(EmpleadoCreateDto dto)
        {
            // Validar que no exista otro empleado con el mismo documento
            bool DNIExiste = await _context.Empleados
                .AnyAsync(e => e.DNI == dto.DNI);

            if (DNIExiste)
            {
                return new ResponseDto<EmpleadoActionResponseDto>
                {
                    StatusCode = HttpStatusCode.CONFLICT,
                    Status = false,
                    Message = HttpMessageResponse.DNI_DUPLICADO
                };
            }

            var entity = EmpleadoMapper.CreateDtoToEntity(dto);
            _context.Empleados.Add(entity);
            await _context.SaveChangesAsync();

            return new ResponseDto<EmpleadoActionResponseDto>
            {
                StatusCode = HttpStatusCode.CREATED,
                Status = true,
                Message = HttpMessageResponse.REGISTER_CREATED,
                Data = new EmpleadoActionResponseDto { Id = entity.Id }
            };
        }

        public async Task<ResponseDto<EmpleadoActionResponseDto>> DeleteAsync(string id)
        {
            var Entity = await _context.Empleados.FirstOrDefaultAsync(p => p.Id == id);

            if(Entity is null)
            {
                return new ResponseDto<EmpleadoActionResponseDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = HttpMessageResponse.REGISTER_NOT_FOUND,  
                };
            }

            _context.Empleados.Remove(Entity);

            await _context.SaveChangesAsync();

            return new ResponseDto<EmpleadoActionResponseDto>
            {
                StatusCode = HttpStatusCode.Ok,
                Status = true,
                Message = HttpMessageResponse.REGISTER_DELETED,
                Data = new EmpleadoActionResponseDto
                {
                    Id = id,
                }  
            }; 
        }

    }
}