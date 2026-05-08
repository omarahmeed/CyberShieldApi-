using Microsoft.AspNetCore.Mvc;
using CyberShieldApi.Models;

namespace CyberShieldApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        [HttpPost]
        public IActionResult Send([FromBody] ContactModel data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

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