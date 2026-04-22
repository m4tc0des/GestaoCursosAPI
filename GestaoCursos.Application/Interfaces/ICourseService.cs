using GestaoCursos.Application.Dtos.Requests;
using GestaoCursos.Application.Dtos.Responses;

namespace GestaoCursos.Application.Interfaces
{
    public interface ICourseService
    {
        Task CreateCourseAsync(CreateCourseRequest request);
        Task<IEnumerable<CourseResponse>> GetAllActiveCoursesAsync();
        Task<CourseResponse?> GetByIdAsync(int id);
    }
}
