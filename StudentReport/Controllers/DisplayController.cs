using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisplayController : ControllerBase
    {
        private readonly IDisplayServices _IDisplayServices;
        public DisplayController(IDisplayServices iDisplayServices)
        {
            _IDisplayServices = iDisplayServices;
        }
        [HttpGet("GetDisplaysById")]
        public async Task<ActionResult<Display>> GetDisplaysById(int id)
        {
            var address = await _IDisplayServices.GetDisplaysById(id);
            return address;
        }
    }
}
