namespace GestaoCursos.Domain.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

        protected Enrollment() { }

        public Enrollment(int studentId, int courseId)
        {
            StudentId = studentId;
            CourseId = courseId;
            EnrollmentDate = DateTime.UtcNow;
        }
    }
}
