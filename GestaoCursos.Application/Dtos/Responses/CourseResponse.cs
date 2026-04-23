namespace GestaoCursos.Application.Dtos.Responses
{
    public class CourseResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DurationInHours { get; set; }
        public decimal Price { get; set; }
        public DateOnly CreatedAt { get; set; }
    }
}
