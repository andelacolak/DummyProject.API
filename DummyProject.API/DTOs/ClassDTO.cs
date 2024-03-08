namespace DummyProject.API.DTOs
{
    public class ClassDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Difficulty { get; set; }
        public ProfessorDTO Professor { get; set; }
    }
}
