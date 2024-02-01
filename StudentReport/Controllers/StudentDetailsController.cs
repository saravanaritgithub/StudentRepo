using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace StudentReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentDetailsController : ControllerBase
    {
        private readonly IStudentDetailsServices _IStudentDetailsServices;
        public StudentDetailsController(IStudentDetailsServices iStudentDetailsServices)
        {
            _IStudentDetailsServices = iStudentDetailsServices;
        }
        [HttpGet("GetStudentDetails")]
        public async Task<IEnumerable<StudentDetails>> GetStudentDetails()
        {
            var address = await _IStudentDetailsServices.GetStudentDetails();
            return address;
        }
        [HttpGet("GetStudentDetailsById")]
        public async Task<ActionResult<StudentDetails>> GetStudentDetailsById(int id)
        {
            var address = await _IStudentDetailsServices.GetStudentDetailsById(id);
            return address;
        }
        [HttpPost("AddStudentDetails")]
        public async Task<ActionResult<StudentDetails>> AddStudentDetails(StudentDetails studentdetails)
        {
            StudentDetails Response = new StudentDetails();
            if (studentdetails != null)
            {
                studentdetails.Regno = 0;
                Response = await _IStudentDetailsServices.AddStudentDetails(studentdetails);
            }
            return Response;
        }
        [HttpPut("UpdateStudentDetails/{id}")]
        public async Task<ActionResult<StudentDetails>> UpdateStudentDetails(StudentDetails studentdetails)
        {
            var update = await _IStudentDetailsServices.UpdateStudentDetails(studentdetails);
            return update;
        }
        [HttpDelete("DeleteStudentDetails/{id}")]
        public async Task<IActionResult> DeleteStudentDetails(int id)
        {
            await _IStudentDetailsServices.DeleteStudentDetails(id);
            return NoContent();
        }
    }
}
