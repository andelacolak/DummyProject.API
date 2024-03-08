using DummyProject.API.DTOs;
using DummyProject.API.Mocks;

namespace DummyProject.API.Services
{
    public class ReportService
    {
        public List<StudentDTO> GetReportForAllStudents() 
        {
            return ReportMock.GetReportForAllStudents();
        }

        public StudentDTO GetReportForStudent(int studentId)
        {
            return ReportMock.GetReportForAllStudents().FirstOrDefault(x => x.Id == studentId);
        }
    }
}
