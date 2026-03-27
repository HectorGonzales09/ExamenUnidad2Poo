using ExamneUnidad2.Dtos.Empleado;
using ExamneUnidad2.Services.Empleado;
using Microsoft.AspNetCore.Mvc;

namespace ExamneUnidad2.Controllers
{
    [Route("api/empleado")]
    [ApiController]
    public class EmpleadoController :ControllerBase
    {
        private readonly IEmpleadoService _empleadoService;

        public EmpleadoController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        [HttpGet]
        public async Task<ActionResult> GetPage(
            string searchTerm = "", int page = 1, int pageSize = 10)
        {
            var response = await _empleadoService.GetPageAsync(searchTerm, page, pageSize);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("activos")]
        public async Task<ActionResult> GetActivos()
        {
            var response = await _empleadoService.GetActivosAsync();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetOne(string id)
        {
            var response = await _empleadoService.GetOneByIdAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<ActionResult> Create(EmpleadoCreateDto dto)
        {
            var response = await _empleadoService.CreateAsync(dto);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Edit(string id, EmpleadoEditDto dto)
        {
            var response = await _empleadoService.EditAsync(id, dto);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var response = await _empleadoService.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
    }
}