using Microsoft.AspNetCore.Mvc;
using CyberShieldApi.Models;

namespace CyberShieldApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Send([FromBody] ContactModel data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Contacts.Add(data);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Request received successfully",
                name = data.Name,
                email = data.Email,
                company = data.Company,
                plan = data.Plan
            });
        }
    }
}