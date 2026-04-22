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
    }
}
