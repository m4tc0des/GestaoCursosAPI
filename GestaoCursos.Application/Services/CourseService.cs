using GestaoCursos.Application.Dtos.Requests;
using GestaoCursos.Application.Dtos.Responses;
using GestaoCursos.Application.Interfaces;
using GestaoCursos.Domain.Interfaces;
using Mapster;

namespace GestaoCursos.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;

        public CourseService(ICourseRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateCourseAsync(CreateCourseRequest request)
        {
            var course = request.Adapt<Course>();
            await _repository.AddAsync(course);
        }

        public async Task<IEnumerable<CourseResponse>> GetAllActiveCoursesAsync()
        {
            var courses = await _repository.GetAllActiveAsync();
            return courses.Adapt<IEnumerable<CourseResponse>>();
        }

        public async Task<CourseResponse?> GetByIdAsync(int id)
        {
            var course = await _repository.GetByIdAsync(id);

            if (course == null)
            {
                return null;
            }
            return course.Adapt<CourseResponse>();
        }

        public async Task<bool> UpdatePriceAsync(int id, decimal price)
        {
            var course = await _repository.GetByIdAsync(id);

            if (course == null)
            {
                return false;
            }
            course.UpdatePrice(price);
            await _repository.UpdateAsync(course);
            return true;
        }

        public async Task<bool> ActivateAsync(int id)
        {
            var course = await _repository.GetByIdAsync(id);
            if (course == null)
            {
                return false;
            }
            course.Activate();
            await _repository.UpdateAsync(course);
            return true;
        }

        public async Task<bool> DeactivateAsync(int id)
        {
            var course = await _repository.GetByIdAsync(id);
            if (course == null)
            {
                return false;
            }
            course.Deactivate();
            await _repository.UpdateAsync(course);
            return true;
        }

        public async Task<bool> UpdateCreatedAtAsync(int id, DateTime newDate)
        {
            var course = await _repository.GetByIdAsync(id);
            if (course == null)
            {
                return false;
            }
            course.UpdateCreatedAt(newDate);
            await _repository.UpdateAsync(course);
            return true;    
        }
    }
}
