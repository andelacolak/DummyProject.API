namespace DummyProject.API.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ClassDTO> Classes { get; set; }
    }
}
