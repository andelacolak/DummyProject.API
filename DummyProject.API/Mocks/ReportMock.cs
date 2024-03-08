using DummyProject.API.DTOs;

namespace DummyProject.API.Mocks
{
    public static class ReportMock
    {
        public static List<StudentDTO> GetReportForAllStudents()
        {
            return new List<StudentDTO>()
            {
                new StudentDTO
                {
                    Id = 1,
                    FirstName = "Maria",
                    LastName = "Maria",
                    Classes = new List<ClassDTO> 
                    { 
                        new ClassDTO 
                        { 
                            Id = 1,
                            Name = "Biology",
                            Difficulty = 8,
                            Professor = new ProfessorDTO
                            {
                                Id = 1,
                                FirstName = "David",
                                LastName = "David",
                                Seniority = Enums.Seniority.Medior
                            }
                        },
                        new ClassDTO 
                        { 
                            Id = 2,
                            Name = "Math",
                            Difficulty = 6,
                            Professor = new ProfessorDTO
                            { 
                                Id = 2,
                                FirstName = "William",
                                LastName = "William",
                                Seniority = Enums.Seniority.Senior
                            }
                        }
                    }
                },
                new StudentDTO 
                { 
                    Id = 2,
                    FirstName = "Jason",
                    LastName = "Jason",
                    Classes = new List<ClassDTO>
                    {
                        new ClassDTO
                        {
                            Id = 3,
                            Name = "Art",
                            Difficulty = 3,
                            Professor = new ProfessorDTO
                            {
                                Id = 3,
                                FirstName = "Nella",
                                LastName = "Nella",
                                Seniority = Enums.Seniority.Junior
                            }
                        }
                    }
                }
            };
        }
    }
}
