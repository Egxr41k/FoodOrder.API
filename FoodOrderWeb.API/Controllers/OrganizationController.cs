using FoodOrderWeb.Service.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationService organizationService;

        public OrganizationController(IOrganizationService organizationService)
        {
            this.organizationService = organizationService;
        }

        [HttpGet("GetForGuest")]
        public IActionResult GetOrganizations()
        {
            return Ok();
        }

        [HttpGet("GetForUser")]
        [Authorize(Roles = "User")]
        public IActionResult GetOrganizationsForUser()
        {
            return Ok();
        }

        [HttpGet("GetForAdmin")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetOrganizationsForAdmin()
        {
            return Ok();
        }

        [HttpPost("Create")]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateOrganizationsForAdmin()
        {
            return Ok();
        }

        [HttpPost("EditForm/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult EditOrganizationsForAdmin(int id)
        {
            return Ok();
        }

        [HttpPost("DeleteForm/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteOrganizationsForAdmin(int id)
        {
            return Ok();
        }
    }
}