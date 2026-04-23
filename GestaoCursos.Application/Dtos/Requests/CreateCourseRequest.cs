namespace GestaoCursos.Application.Dtos.Requests
{
    public class CreateCourseRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int DurationInHours { get; set; }
        public decimal Price { get; set; }

    }
}
