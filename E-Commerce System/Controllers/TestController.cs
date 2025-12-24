using Microsoft.AspNetCore.Mvc;
using E_Commerce_System.Data;

namespace E_Commerce_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TestController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Example usage
            return Ok("DbContext is working!");
        }
    }
}
