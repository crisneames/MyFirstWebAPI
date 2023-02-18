using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        [HttpGet]
        public District Get()
        {
            return new District() { Id = 1, Name = "Middle TN" };
        }

        [HttpPost]
        public IActionResult Post(District district)
        {
            return NotFound();
        }
    }
}
