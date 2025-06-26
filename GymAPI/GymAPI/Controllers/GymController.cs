using GymBL;
using GymCommon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymMemberController : ControllerBase
    {
        private readonly GymBAL gymBAL = new GymBAL();

        [HttpGet]
        public IEnumerable<string> GetMembers()
        {
            return gymBAL.GetMemberSummaries();
        }

        [HttpPost]
        public IActionResult AddMember([FromBody] Member request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Name) ||
                string.IsNullOrWhiteSpace(request.MembershipType) ||
                string.IsNullOrWhiteSpace(request.registeredMonth))
            {
                return BadRequest("Invalid, Fix the error");
            }

            gymBAL.AddMember(request.Name, request.MembershipType, request.registeredMonth);
            return Ok(true);
        }

        [HttpDelete]
        public IActionResult RemoveMember([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return BadRequest("Name is required.");

            bool removed = gymBAL.RemoveMember(name);
            if (removed)
                return Ok(true);
            else
                return NotFound("Member is not existing.");
        }

        [HttpPatch("payment")]
        public IActionResult UpdatePaymentStatus([FromQuery] string name, [FromQuery] string newStatus)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(newStatus))
                return BadRequest("Info are required.");

            bool updated = gymBAL.UpdatePaymentStatus(name, newStatus);
            if (updated)
                return Ok(true);
            else
                return NotFound("Member not existing");
        }
    }
}