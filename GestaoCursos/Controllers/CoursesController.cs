using GestaoCursos.Application.Dtos.Requests;
using GestaoCursos.Application.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace GestaoCursos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _service;

        public CoursesController(ICourseService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourseAsync(CreateCourseRequest request)
        {
            await _service.CreateCourseAsync(request);

            return Created(string.Empty, new { message = "Curso criado com sucesso!" });
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {
            var courses = await _service.GetAllActiveCoursesAsync();
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseById(int id)
        {
            var course = await _service.GetByIdAsync(id);
            if (course == null)
            {
                return NotFound(new { message = "Curso não encontrado." });
            }
            return Ok(course);
        }

        [HttpPatch("update-price/{id}")]
        public async Task<IActionResult> UpdatePriceAsync(int id, [FromBody] UpdatePriceCourseRequest request)
        {
            var courseUpdated = await _service.UpdatePriceAsync(id, request.Price);

            if (!courseUpdated)
            {
                return NotFound(new { message = "Curso não encontrado." });
            }
            return NoContent();
        }

        [HttpPatch("Ativar/usuario{id}")]
        public async Task<IActionResult> ActivateAsync(int id)
        {
            var courseActivated = await _service.ActivateAsync(id);
            if (!courseActivated)
            {
                return NotFound(new { message = "Curso não encontrado." });
            }
            return NoContent();
        }

        [HttpDelete("Desativar-usuario/{id}")]
        public async Task<IActionResult> DeactivateAsync(int id)
        {
            var courseDeactivated = await _service.DeactivateAsync(id);
            if (!courseDeactivated)
            {
                return NotFound(new { message = "Curso não encontrado." });
            }
            return NoContent();
        }

        [HttpPatch("Atualizar-data/{id}")]
        public async Task<IActionResult> UpdateCreateAtAsync(int id, [FromBody] UpdateCourseDateRequest request)
        {
            var courseUpdated = await _service.UpdateCreatedAtAsync(id, request.CreatedAt);
            if (!courseUpdated)
            {
                return NotFound(new { message = "Curso não encontrado." });
            }
            return NoContent();
        }
    }
}
