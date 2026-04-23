using System.ComponentModel.DataAnnotations;

namespace GestaoCursos.Application.Dtos.Requests
{
    public class UpdateCourseDateRequest
    {
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
    }
}
