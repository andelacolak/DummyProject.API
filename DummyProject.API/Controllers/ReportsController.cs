using DummyProject.API.DTOs;
using DummyProject.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DummyProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportsController : ControllerBase
    {
        private ReportService reportService = new ReportService();

        [HttpGet(Name = "GetAllStudents")]
        public List<StudentDTO> Index()
        {
            return reportService.GetReportForAllStudents();
        }

        //[HttpGet(Name = "GetStudent")]
        //public List<StudentDTO> Index([FromRoute] int id)
        //{
        //    return reportService.GetReportForAllStudents();
        //}
    }
}
