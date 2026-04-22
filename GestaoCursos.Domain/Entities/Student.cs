namespace GestaoCursos.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public Student(string name, string email)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                throw new ArgumentException("Email inválido.");
            Name = name;
            Email = email;
            Active = true;
        }
    }
}
