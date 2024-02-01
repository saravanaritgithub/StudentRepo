using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarksController : ControllerBase
    {
        private readonly IMarkServices _IMarkServices;
        public MarksController(IMarkServices iMarkServices)
        {
            _IMarkServices = iMarkServices;
        }
        [HttpGet("GetMarks")]
        public async Task<IEnumerable<Marks>> GetMarks()
        {
            var address = await _IMarkServices.GetMarks();
            return address;
        }
        [HttpGet("GetMarksById")]
        public async Task<ActionResult<Marks>> GetMarksById(int id)
        {
            var address = await _IMarkServices.GetMarksById(id);
            return address;
        }
        [HttpPost("AddMarks")]
        public async Task<ActionResult<Marks>> AddMarks(Marks marks)
        {
            Marks Response = new Marks();
            if (marks != null)
            {
                marks.MarkId = 0;
                Response = await _IMarkServices.AddMarks(marks);
            }
            return Response;
        }
        [HttpPut("UpdateMarks/{id}")]
        public async Task<ActionResult<Marks>> UpdateMarks(Marks marks)
        {
            var update = await _IMarkServices.UpdateMarks(marks);
            return update;
        }
    }
}
