using DummyProject.API.Enums;

namespace DummyProject.API.DTOs
{
    public class ProfessorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Seniority Seniority { get; set; }

    }
}
